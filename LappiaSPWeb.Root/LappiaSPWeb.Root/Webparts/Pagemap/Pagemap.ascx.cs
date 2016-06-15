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

namespace LappiaSPWeb.Root.Webparts.Pagemap
{
    [ToolboxItemAttribute(false)]
    public partial class Pagemap : WebPart
    {
        // Uncomment the following SecurityPermission attribute only when doing Performance Profiling on a farm solution
        // using the Instrumentation method, and then remove the SecurityPermission attribute when the code is ready
        // for production. Because the SecurityPermission attribute bypasses the security check for callers of
        // your constructor, it's not recommended for production purposes.
        // [System.Security.Permissions.SecurityPermission(System.Security.Permissions.SecurityAction.Assert, UnmanagedCode = true)]
        public Pagemap()
        {
        }

        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            InitializeControl();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                BindSiteMap();
            }
        }

        public void BindSiteMap()
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                List<Project_Pagemap> allTaxanomies = GetFriendlyURLSFromTaxonomy();
                sb.Append("<ul class='sitemap'>");
                List<Project_Pagemap> rootTaxanomy = (from p in allTaxanomies where p.Subsection == "Root" select p).ToList();
                for (int i = 0; i < rootTaxanomy.Count; i++)
                {
                    int c = CountSubsection(rootTaxanomy[i].Name, allTaxanomies);
                    if (c > 0)
                    {
                        sb.Append("<li><a href='" + rootTaxanomy[i].Url + "' >" + rootTaxanomy[i].Name + "</a><ul>");
                        BindSubsections(rootTaxanomy[i].Name, allTaxanomies, sb);
                        sb.Append("</ul></li>");
                    }
                    else
                    {
                        sb.Append("<li><a href='" + rootTaxanomy[i].Url + "'>" + rootTaxanomy[i].Name + "</a></li>");
                    }

                }
                sb.Append("</ul>");
                lblSitemap.Text = sb.ToString();
            }
            catch (Exception ex)
            {
                //lblMsg.Text = "Page_Load Error : " + ex.Message;
            }
        }

        private int CountSubsection(string subsectionaName, List<Project_Pagemap> str)
        {
            return (from p in str where p.Subsection.ToLower() == subsectionaName.ToLower() select p).Count();
        }

        private void BindSubsections(string subsectionaName, List<Project_Pagemap> str, StringBuilder sb)
        {
            try
            {
                var subsectionTaxanomy = (from p in str where p.Subsection.ToLower() == subsectionaName.ToLower() select p).ToList();
                if (subsectionTaxanomy.Count > 0)
                {
                    for (int i = 0; i < subsectionTaxanomy.Count; i++)
                    {
                        int c = CountSubsection(subsectionTaxanomy[i].Name, str);
                        if (c > 0)
                        {
                            sb.Append("<li ><a href='" + subsectionTaxanomy[i].Url + "'>" + subsectionTaxanomy[i].Name + "</a><ul>");
                            BindSubsections(subsectionTaxanomy[i].Name, str, sb);
                            sb.Append("</ul></li>");
                        }
                        else
                        {
                            sb.Append("<li><a href='" + subsectionTaxanomy[i].Url + "' >" + subsectionTaxanomy[i].Name + "</a></li>");
                        }
                        
                    }
                }
            }
            catch (Exception ex)
            {
                //lblMessage.Text = "Page_Load Error : " + ex.Message;
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


                            for (int i = 0; i < tsList.Terms.Count; i++)
                            {
                                if (!string.IsNullOrEmpty(tsList.Terms[i].Title.Value.ToLower()))
                                {
                                    Project_Pagemap ptest = new Project_Pagemap();
                                    ptest.Name = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(tsList.Terms[i].Title.Value);
                                    ptest.Subsection = "Root";
                                    ptest.Url = "../" + tsList.Terms[i].FriendlyUrlSegment.Value;
                                    objtest.Add(ptest);
                                    Bind(objtest, tsList.Terms[i], tsList.Terms[i].Title.Value, i, 1, tsList.Terms[i].FriendlyUrlSegment.Value);
                                }
                            }
                        }
                    }
                });
            }
            catch (Exception ex)
            {
                //lblMessage.Text = "Page_Load Error : " + ex.Message;
            }
            return objtest;
        }

        private void Bind(List<Project_Pagemap> dcn, NavigationTermSetItem tsList, string root, int level, int level2, string RootURl)
        {
            try
            {
                for (int j = 0; j < tsList.Terms.Count; j++)
                {
                    if (!string.IsNullOrEmpty(tsList.Terms[j].Title.Value.ToLower()))
                    {
                        Project_Pagemap p = new Project_Pagemap();
                        p.Name = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(tsList.Terms[j].Title.Value.ToLower()); 
                        p.Subsection = root;
                        p.Url = "../" + RootURl + "/" + tsList.Terms[j].FriendlyUrlSegment.Value;
                        dcn.Add(p);
                        if (tsList.Terms[j].Terms.Count > 0)
                        {
                            Bind(dcn, tsList.Terms[j], tsList.Terms[j].Title.Value, level, level2 + 1, RootURl + "/" + tsList.Terms[j].FriendlyUrlSegment.Value);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
               // lblMessage.Text = "Page_Load Error : " + ex.Message;
            }
        }
    }
}
