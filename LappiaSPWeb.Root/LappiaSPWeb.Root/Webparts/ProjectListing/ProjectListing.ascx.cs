using System;
using System.ComponentModel;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using EducationSite;
using System.Collections.Generic;
using LappiaSPWeb.Data;
using System.Text;
using System.Linq;
using Microsoft.SharePoint;

namespace LappiaSPWeb.Root.Webparts.ProjectListing
{
    [ToolboxItemAttribute(false)]
    public partial class ProjectListing : WebPart
    {
        // Uncomment the following SecurityPermission attribute only when doing Performance Profiling on a farm solution
        // using the Instrumentation method, and then remove the SecurityPermission attribute when the code is ready
        // for production. Because the SecurityPermission attribute bypasses the security check for callers of
        // your constructor, it's not recommended for production purposes.
        // [System.Security.Permissions.SecurityPermission(System.Security.Permissions.SecurityAction.Assert, UnmanagedCode = true)]

        ResourceClass.GetResources res = new ResourceClass.GetResources();

        public ProjectListing()
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
                    BindDropdownListbox();
                    BindProjects("0");
                }
            }
            catch (Exception ex)
            {
                lblMessage.Text = "Page_Load Error : " + ex.Message;
            }
        }

        private void BindProjects(string status)
        {
            try
            {
                List<Project_Listing> lstProjListing = new List<Project_Listing>();
                Utility objUtility = new Utility();
                lstProjListing = objUtility.BindProjects(status);

                List<string> dept = new List<string>();
                dept = (from d in lstProjListing orderby d.JulkaisuPaikka select d.JulkaisuPaikka).Distinct().ToList();

                StringBuilder sb = new StringBuilder();
                sb.Append("<ul class='sublink'>");
                for (int i = 0; i < dept.Count; i++)
                {
                    //if (dept[i].ToString().StartsWith("AMK"))
                    {
                        //  sb.Append("<li>" + dept[i].ToString().Substring(4, (dept[i].ToString().Length - 4)) + "<ul>");
                        //sb.Append("<div style='width:100%'><b>" + dept[i].ToString().Substring(4, (dept[i].ToString().Length - 4)) + "</b></div>");
                    }
                    //else
                    {
                        sb.Append("<li>" + dept[i].ToString() + "<ul>");
                        //sb.Append("<div style='width:100%'><b>" + dept[i].ToString() + "</b></div>");
                    }
                    List<Project_Listing> lstProj = new List<Project_Listing>();

                    if (status == "0" || status == "1")
                    {
                        lstProj = (from d in lstProjListing where d.JulkaisuPaikka == Convert.ToString(dept[i]) select d).OrderBy(x => x.Nimi).ToList();
                        for (int j = 0; j < lstProj.Count; j++)
                        {
                            string url = GenerateURL(lstProj[j]);
                            // string url = String.Format("<a href='{0}'>{1}</a>", "../" + lblPage + "/ProjectDetail.aspx?projID=" + lstProj[j].Hanke_ID, lstProj[j].Nimi);
                            sb.Append("<li><a href='#'>" + url + "</a></li>");
                        }
                    }
                    else
                    {
                        lstProj = (from d in lstProjListing where d.JulkaisuPaikka == Convert.ToString(dept[i]) select d).OrderByDescending(x => x.Aikataulu).ToList();
                        for (int j = 0; j < lstProj.Count; j++)
                        {
                            string url = GenerateURL(lstProj[j]);
                            // sb.Append("<div style='width: 100%; padding-left: 10px'>" + url + "</div>");
                            sb.Append("<li><a href='#'>" + url + "</a></li>");
                        }
                    }

                    sb.Append("</ul></li>");
                }
                sb.Append("</ul>");
                lblProjListing.Text = sb.ToString();
            }
            catch (Exception ex)
            {
                lblMessage.Text = "BindProjects Error : " + ex.Message;
            }
        }

        private void BindDropdownListbox()
        {
            try
            {
                ResourceClass.GetResources res = new ResourceClass.GetResources();
                lblProjectStatus.Text = res.LoadResource("ProjectStatus");
                lblHeading.Text = res.LoadResource("projListingHeading");
                drpStatus.Items.Insert(0, res.LoadResource("All"));
                drpStatus.Items.Insert(1, res.LoadResource("Inprogress"));
                drpStatus.Items.Insert(2, res.LoadResource("Completed"));
            }
            catch (Exception ex)
            {
                lblMessage.Text = "BindDropdownListbox Error : " + ex.Message;
            }
        }

        protected void drpStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string statusvalue = drpStatus.SelectedIndex.ToString();
                BindProjects(statusvalue);
            }
            catch (Exception ex)
            {
                lblMessage.Text = "rptProjects_ItemDataBound Error : " + ex.Message;
            }
        }

        private string GenerateURL(Project_Listing lstProj)
        {
            Uri lappiaUri = Page.Request.Url;
            string url = string.Empty;
            try
            {
                string lblPage = res.LoadResource("Pages");

                if (lappiaUri.AbsoluteUri.EndsWith(".aspx"))
                {
                    url = String.Format("<a href='{0}'>{1}</a>", "/Projects/Detail?projID=" + lstProj.Hanke_ID, lstProj.Nimi);
                }
                else
                {
                    if ((uint)System.Globalization.CultureInfo.CurrentUICulture.LCID == 1033)
                    {
                        url = String.Format("<a href='{0}'>{1}</a>", SPContext.Current.Web.Url + "/Projects/Detail?projID=" + lstProj.Hanke_ID, lstProj.Nimi);
                    }
                    else if ((uint)System.Globalization.CultureInfo.CurrentUICulture.LCID == 1035)
                    {
                        url = String.Format("<a href='{0}'>{1}</a>", SPContext.Current.Web.Url + "/Projects/Detail?projID=" + lstProj.Hanke_ID, lstProj.Nimi);
                    }
                }
            }
            catch (Exception ex)
            {
                lblMessage.Text = "BindProjects Error : " + ex.Message;
            }
            return url;
        }
    }
}
