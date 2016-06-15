using EducationSite;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Publishing.Navigation;
using Microsoft.SharePoint.Taxonomy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Web.UI.WebControls.WebParts;
using System.Linq;
using System.Web;

namespace LappiaSPWeb.Root.Webparts.Breadcrumb
{
    [ToolboxItemAttribute(false)]
    public partial class Breadcrumb : WebPart
    {
        // Uncomment the following SecurityPermission attribute only when doing Performance Profiling on a farm solution
        // using the Instrumentation method, and then remove the SecurityPermission attribute when the code is ready
        // for production. Because the SecurityPermission attribute bypasses the security check for callers of
        // your constructor, it's not recommended for production purposes.
        // [System.Security.Permissions.SecurityPermission(System.Security.Permissions.SecurityAction.Assert, UnmanagedCode = true)]
        public Breadcrumb()
        {
        }

        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            InitializeControl();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!Page.IsPostBack)
                {
                    CreateBreadCrumb();
                }
            }
            catch (Exception ex)
            {
                lblMessage.Text = "Page_Load Error : " + ex.Message;
            }
        }

        private StringBuilder breadcrumb(Project_Pagemap objPagemap, List<Project_Pagemap> lstPagemap, StringBuilder sb, int id, List<lappiaBreadcrumb> lstBreadcrumb, string url)
        {
            try
            {
                if (objPagemap.Subsection.ToLower() == "root")
                {

                }
                else
                {
                    Project_Pagemap objProjPagemap = (from p in lstPagemap where p.Name.ToLower() == objPagemap.Subsection.ToLower() select p).SingleOrDefault();
                    lappiaBreadcrumb objBreadcrumb = new lappiaBreadcrumb();
                    objBreadcrumb.name = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(objProjPagemap.Name);
                    objBreadcrumb.url = url + objProjPagemap.Url;
                    objBreadcrumb.id = id;
                    lstBreadcrumb.Add(objBreadcrumb);
                    breadcrumb(objProjPagemap, lstPagemap, sb, (id + 1), lstBreadcrumb, url + "/" + objProjPagemap.Url);
                }
            }
            catch (Exception ex)
            {
                lblMessage.Text = "breadcrumb Error : " + ex.Message;
            }
            return sb;
        }

        private void CreateBreadCrumb()
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                List<Project_Pagemap> lstPagemap = GetFriendlyURLSFromTaxonomy();
                List<lappiaBreadcrumb> lstbreadCrumb = new List<lappiaBreadcrumb>();

                Uri lappiaUri = Page.Request.Url;
                var parsedQuery = HttpUtility.ParseQueryString(lappiaUri.ToString());
                string termId = parsedQuery["TermId"];
                Project_Pagemap objPagemap = (from p in lstPagemap where p.TermId.ToString() == termId select p).SingleOrDefault();
                string siteURL = SPContext.Current.Web.Url; //(uint)System.Globalization.CultureInfo.CurrentUICulture.LCID == 1033 ? "/sites/en-us" : "/sites/fi-fi";
                lappiaBreadcrumb objBreadcrumb = new lappiaBreadcrumb();
                objBreadcrumb.name = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(objPagemap.Name);
                objBreadcrumb.url = siteURL + objPagemap.Url;
                objBreadcrumb.id = 0;
                lstbreadCrumb.Add(objBreadcrumb);
                breadcrumb(objPagemap, lstPagemap, sb, 1, lstbreadCrumb, siteURL);
                lstbreadCrumb = lstbreadCrumb.OrderByDescending(x => x.id).ToList();
                sb.Append("<ol class='breadcrumb'>");
                sb.Append("<li><a href='" + siteURL + "'>Home </a></li>");
                for (int i = 0; i < lstbreadCrumb.Count; i++)
                {
                    if (i == (lstbreadCrumb.Count - 1))
                    {
                        sb.Append("<li class='active'>" + lstbreadCrumb[i].name + "</a></li>");
                    }
                    else
                    {
                        sb.Append("<li><a href='" + lstbreadCrumb[i].url + "'>" + lstbreadCrumb[i].name + "</a></li>");
                    }
                }
                sb.Append("</ol>");
                lblBeadcrumb.Text = sb.ToString();
            }
            catch (Exception ex)
            {
                lblMessage.Text = "CreateBreadCrumb Error : " + ex.Message;
            }
        }

        private List<Project_Pagemap> GetFriendlyURLSFromTaxonomy()
        {
            List<Project_Pagemap> lstPagemap = new List<Project_Pagemap>();
            try
            {
                SPSecurity.RunWithElevatedPrivileges(delegate()
                {
                    using (SPSite mySite = new SPSite(SPContext.Current.Site.Url))
                    {
                        using (SPWeb myWeb = mySite.OpenWeb())
                        {

                            TaxonomySession taxonomySession = new TaxonomySession(myWeb.Site);
                            TermStore termStore = taxonomySession.DefaultSiteCollectionTermStore;
                            Group siteCollectionGroup = termStore.GetSiteCollectionGroup(myWeb.Site, createIfMissing: false);
                            TermSet termSet = siteCollectionGroup.TermSets["Lappia Education"];
                            NavigationTermSet tsList = NavigationTermSet.GetAsResolvedByWeb(termSet, myWeb, StandardNavigationProviderNames.GlobalNavigationTaxonomyProvider);


                            for (int i = 0; i < tsList.Terms.Count; i++)
                            {
                                if (!string.IsNullOrEmpty(tsList.Terms[i].Title.Value.ToLower()))
                                {
                                    Project_Pagemap objPagemap = new Project_Pagemap();
                                    objPagemap.Name = tsList.Terms[i].Title.Value;
                                    objPagemap.Subsection = "Root";
                                    objPagemap.Url = "/" + tsList.Terms[i].FriendlyUrlSegment.Value;
                                    objPagemap.TermId = tsList.Terms[i].Id;
                                    lstPagemap.Add(objPagemap);
                                    Bind(lstPagemap, tsList.Terms[i], tsList.Terms[i].Title.Value.ToLower(), tsList.Terms[i].FriendlyUrlSegment.Value);
                                }
                            }
                        }
                    }
                });
            }
            catch (Exception ex)
            {
                lblMessage.Text = "GetFriendlyURLSFromTaxonomy Error : " + ex.Message;
            }
            return lstPagemap;
        }

        private void Bind(List<Project_Pagemap> lstPagemap, NavigationTermSetItem tsList, string root, string rootValue)
        {
            try
            {
                for (int j = 0; j < tsList.Terms.Count; j++)
                {
                    if (!string.IsNullOrEmpty(tsList.Terms[j].Title.Value.ToLower()))
                    {
                        Project_Pagemap objPagemap = new Project_Pagemap();
                        objPagemap.Name = tsList.Terms[j].Title.Value;
                        objPagemap.Subsection = root;
                        objPagemap.TermId = tsList.Terms[j].Id;
                        objPagemap.Url = "/" + rootValue + "/" + tsList.Terms[j].FriendlyUrlSegment.Value;
                        lstPagemap.Add(objPagemap);
                        if (tsList.Terms[j].Terms.Count > 0)
                        {
                            Bind(lstPagemap, tsList.Terms[j], tsList.Terms[j].Title.Value, rootValue + "/" + tsList.Terms[j].FriendlyUrlSegment.Value);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                lblMessage.Text = "Bind Error : " + ex.Message;
            }
        }

        public class lappiaBreadcrumb
        {
            public string name { get; set; }
            public string url { get; set; }
            public int id { get; set; }
        }

    }
}
