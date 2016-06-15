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

namespace LappiaSPWeb.Root.Webparts.LeftNavigationMenu
{
    [ToolboxItemAttribute(false)]
    public partial class LeftNavigationMenu : WebPart
    {
        // Uncomment the following SecurityPermission attribute only when doing Performance Profiling on a farm solution
        // using the Instrumentation method, and then remove the SecurityPermission attribute when the code is ready
        // for production. Because the SecurityPermission attribute bypasses the security check for callers of
        // your constructor, it's not recommended for production purposes.
        // [System.Security.Permissions.SecurityPermission(System.Security.Permissions.SecurityAction.Assert, UnmanagedCode = true)]
        public LeftNavigationMenu()
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
                    BindSiteMap();
                }
            }
            catch (Exception ex)
            {
                lblMessage.Text = "Page_Load Error : " + ex.Message;
            }
        }

        public void BindSiteMap()
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                List<Project_Pagemap> allTaxanomies = GetFriendlyURLSFromTaxonomy();


                Uri lappiaUri = Page.Request.Url;
                var parsedQuery = HttpUtility.ParseQueryString(lappiaUri.ToString());
                string termId = parsedQuery["TermId"];

                Project_Pagemap str9 = (from p in allTaxanomies where p.TermId.ToString() == termId select p).SingleOrDefault();

                List<Project_Pagemap> str1 = (from p in allTaxanomies where p.Subsection.ToLower() == str9.Subsection.ToLower() select p).ToList();
                for (int i = 0; i < str1.Count; i++)
                {
                    sb.Append("<h3><a href='" + str1[i].Url + "'>" + str1[i].Name + "</a></h3>");
                    //sb.Append("<h3>" + str1[i].Name + "</h3>");
                    sb.Append("<ul class='innerlink'>");
                    List<Project_Pagemap> str8 = (from p in allTaxanomies where p.Subsection.ToLower() == str1[i].Name.ToLower() select p).ToList();
                    for (int j = 0; j < str8.Count; j++)
                    {
                        sb.Append("<li><a href='" + str8[j].Url + "'>" + str8[j].Name + "</a></li>");
                    }
                    sb.Append("</ul>");
                }

                lblSitemap.Text = sb.ToString();
            }
            catch (Exception ex)
            {
                lblMessage.Text = "Page_Load Error : " + ex.Message;
            }
        }

        private List<Project_Pagemap> GetFriendlyURLSFromTaxonomy()
        {
            List<Project_Pagemap> objtest = new List<Project_Pagemap>();
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

                            string url = (uint)System.Globalization.CultureInfo.CurrentUICulture.LCID == 1033 ? "/sites/en-us" : "/sites/fi-fi";
                            for (int i = 0; i < tsList.Terms.Count; i++)
                            {
                                if (!string.IsNullOrEmpty(tsList.Terms[i].Title.Value.ToLower()))
                                {
                                    Project_Pagemap ptest = new Project_Pagemap();
                                    ptest.Name =  System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(tsList.Terms[i].Title.Value);
                                    ptest.Subsection = "Root";
                                    ptest.Url = url + "/" + tsList.Terms[i].FriendlyUrlSegment.Value;
                                    ptest.TermId = tsList.Terms[i].Id;
                                    objtest.Add(ptest);
                                    Bind(objtest, tsList.Terms[i], tsList.Terms[i].Title.Value, i, 1, tsList.Terms[i].FriendlyUrlSegment.Value, url);
                                }
                            }
                        }
                    }
                });
            }
            catch (Exception ex)
            {

            }
            return objtest;
        }

        private void Bind(List<Project_Pagemap> dcn, NavigationTermSetItem tsList, string root, int level, int level2, string RootURl, string url)
        {
            try
            {
                for (int j = 0; j < tsList.Terms.Count; j++)
                {
                    if (!string.IsNullOrEmpty(tsList.Terms[j].Title.Value.ToLower()))
                    {
                        Project_Pagemap p = new Project_Pagemap();
                        p.Name = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(tsList.Terms[j].Title.Value);
                        p.Subsection = root;
                        p.Url = url + "/" + RootURl + "/" + tsList.Terms[j].FriendlyUrlSegment.Value;
                        p.TermId = tsList.Terms[j].Id;
                        dcn.Add(p);
                        if (tsList.Terms[j].Terms.Count > 0)
                        {
                            Bind(dcn, tsList.Terms[j], tsList.Terms[j].Title.Value, level, level2 + 1, RootURl + "/" + tsList.Terms[j].FriendlyUrlSegment.Value, url);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                lblMessage.Text = "Page_Load Error : " + ex.Message;
            }
        }
    }
}
