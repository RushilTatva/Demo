using EducationSite;
using System;
using System.ComponentModel;
using System.Web.UI.WebControls.WebParts;
using LappiaSPWeb.Data;
using System.Collections.Generic;
using System.Linq;

namespace LappiaSPWeb.Root.Webparts.ProjectDetail
{
    [ToolboxItemAttribute(false)]
    public partial class ProjectDetail : WebPart
    {
        // Uncomment the following SecurityPermission attribute only when doing Performance Profiling on a farm solution
        // using the Instrumentation method, and then remove the SecurityPermission attribute when the code is ready
        // for production. Because the SecurityPermission attribute bypasses the security check for callers of
        // your constructor, it's not recommended for production purposes.
        // [System.Security.Permissions.SecurityPermission(System.Security.Permissions.SecurityAction.Assert, UnmanagedCode = true)]
        public ProjectDetail()
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
                    BindResources();
                    BindProjectDetail();
                }
            }
            catch (Exception ex)
            {
                lblMessage.Text = "Page_Load Error : " + ex.Message;
            }
        }

        private void BindResources()
        {
            try
            {
                ResourceClass.GetResources res = new ResourceClass.GetResources();
                lblTarget.Text = res.LoadResource("lblTarget");
                lblFinding.Text = res.LoadResource("lblFinding");
                lblSupervisor.Text = res.LoadResource("lblSupervisor");
                lblOurPartners.Text = res.LoadResource("lblOurPartners");
                lblTimeTable.Text = res.LoadResource("lblTimeTable");
                lblMoreInfo.Text = res.LoadResource("lblMoreInfo");
                lblWebsite.Text = res.LoadResource("lblWebsite");
                lblSourceFinding.Text = res.LoadResource("lblSourceFinding");
                lblLogo.Text = res.LoadResource("lblLogo");
                lblAttachments.Text = res.LoadResource("lblAttachments");
                lblHeading.Text = res.LoadResource("projListingHeading");

            }
            catch (Exception ex)
            {
                lblMessage.Text = "BindResources Error : " + ex.Message;
            }
        }

        private void BindProjectDetail()
        {
            try
            {
                string projID = string.Empty;
                projID = Convert.ToString(Page.Request.QueryString["projID"]);
                if (projID != null && projID != "")
                {
                    Utility objUtility = new Utility();

                    Project_Detail objProjectDetail = new Project_Detail();
                    objProjectDetail = objUtility.BindProjectDetail(projID);
                    if (objProjectDetail != null)
                    {
                        pnlProjDetail.Visible = true;
                        ProjTitle.Text = objProjectDetail.Nimi;
                        lblTavoite.Text = objProjectDetail.Tavoite;
                        lblTulokset.Text = objProjectDetail.Tulokset;
                        lblAikataulu.Text = objProjectDetail.Aikataulu;
                        lblLisatietoja.Text = objProjectDetail.Lisatietoja;
                        lblKotisivut.Text = objProjectDetail.Kotisivut;
                    }

                    List<Document_Detail> objDocumentDetail = objUtility.BindDocumentDetail(projID);
                    if (objDocumentDetail.Count > 0)
                    {
                        lblLogoUrl.Text = BindLogo(objDocumentDetail);
                        lblLiitteet.Text = BindLiitteet(objDocumentDetail);
                    }

                    List<Paatoteuttaja_Detail> objPartnetDetail = objUtility.BindPaatoteuttaja(projID);
                    if (objPartnetDetail.Count > 0)
                    {

                        lblPaatoteuttaja.Text = BindPartnet(objPartnetDetail, "1");
                        lblYhteistyokumppanit.Text = BindPartnet(objPartnetDetail, "4");
                    }


                    List<Rahoituslahde_Detail> objRahoituslahdeDetail = objUtility.BindRahoituslahde(projID);
                    if (objRahoituslahdeDetail.Count > 0)
                    {
                        lblRahoituslahde.Text = BindRahoituslahde(objRahoituslahdeDetail);
                    }

                }
                else
                {
                    lblMessage.Text = "Detail not found or ID is invalid";
                    pnlProjDetail.Visible = false;
                }
            }
            catch (Exception ex)
            {
                lblMessage.Text = "BindProjectDetail Error : " + ex.Message;
            }
        }

        private string BindLogo(List<Document_Detail> objDocumentDetail)
        {
            string strLogo = string.Empty;
            try
            {
                int c = 0;
                List<string> Logo = new List<string>();
                Logo = (from logo in objDocumentDetail
                        where logo.ReportCode == "LOGOT"
                        orderby logo.DokumenttiURL
                        select logo.DokumenttiURL).Distinct().ToList();


                for (int i = 0; i < Logo.Count; i++)
                {
                    if (c == 0)
                    {
                        strLogo = "<img alt='image' height='150px' width='150px' src='" + Logo[i].ToString() + "' />";
                        c++;
                    }
                    else
                    {
                        strLogo += "&nbsp;&nbsp;" + "<img alt='image' height='150px' width='150px' src='" + Logo[i].ToString() + "' />";
                        c++;
                    }
                }
            }
            catch (Exception ex)
            {
                lblMessage.Text = "BindLogo Error : " + ex.Message;
            }
            return strLogo;
        }

        private string BindLiitteet(List<Document_Detail> objDocumentDetail)
        {
            string strLiitteet = string.Empty;
            try
            {
                int c = 0;
                List<Document_Detail> Liitteet = new List<Document_Detail>();
                Liitteet = (from attachment in objDocumentDetail
                            where attachment.ReportCode == "LIITTEET"
                            select new Document_Detail()
                            {
                                Filename = attachment.Filename,
                                DokumenttiURL = attachment.DokumenttiURL
                            }).ToList();


                for (int i = 0; i < Liitteet.Count; i++)
                {
                    if (c == 0)
                    {

                        strLiitteet = String.Format(@"<a href='{0}'>{1}</a>", Liitteet[i].DokumenttiURL.ToString(), Liitteet[i].Filename.ToString());
                        c++;
                    }
                    else
                    {
                        strLiitteet += "<br/>" + String.Format(@"<a href='{0}'>{1}</a>", Liitteet[i].DokumenttiURL.ToString(), Liitteet[i].Filename.ToString());
                        c++;
                    }
                }
            }
            catch (Exception ex)
            {
                lblMessage.Text = "BindAttachment Error : " + ex.Message;
            }
            return strLiitteet;
        }

        private string BindRahoituslahde(List<Rahoituslahde_Detail> objPartnetDetail)
        {
            string strRahoituslahde = string.Empty;
            try
            {
                int c = 0;
                List<string> Rahoituslahde = new List<string>();
                Rahoituslahde = (from partner in objPartnetDetail
                                 orderby partner.Rahoituslahde
                                 select partner.Rahoituslahde).Distinct().ToList();
                for (int i = 0; i < Rahoituslahde.Count; i++)
                {
                    if (c == 0)
                    {
                        strRahoituslahde = Rahoituslahde[i].ToString();
                        c++;
                    }
                    else
                    {
                        strRahoituslahde += "<br/>" + Rahoituslahde[i].ToString();
                        c++;
                    }
                }
            }
            catch (Exception ex)
            {
                lblMessage.Text = "BindRahoituslahde Error : " + ex.Message;
            }
            return strRahoituslahde;
        }

        private string BindPartnet(List<Paatoteuttaja_Detail> objPartnetDetail, string RooliId)
        {
            string strPaatoteuttaja = string.Empty;
            try
            {
                int c = 0;
                List<string> Paatoteuttaja = new List<string>();
                Paatoteuttaja = (from mainExecuter in objPartnetDetail
                                 orderby mainExecuter.Yhteiso
                                 where mainExecuter.Rooli == RooliId
                                 select mainExecuter.Yhteiso).Distinct().ToList();
                for (int i = 0; i < Paatoteuttaja.Count; i++)
                {
                    if (c == 0)
                    {
                        strPaatoteuttaja = Paatoteuttaja[i].ToString();
                        c++;
                    }
                    else
                    {
                        strPaatoteuttaja += "<br/>" + Paatoteuttaja[i].ToString();
                        c++;
                    }
                }
            }
            catch (Exception ex)
            {
                lblMessage.Text = "BindPaatoteuttaja Error : " + ex.Message;
            }
            return strPaatoteuttaja;
        }
    }
}
