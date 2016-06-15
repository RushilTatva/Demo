using EducationSite;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;

namespace LappiaSPWeb.Data
{
    public class Utility
    {
        public Project_Detail BindProjectDetail(string projID)
        {
            Project_Detail objProjectDetail = null;
            try
            {
                if (projID != null && projID != "")
                {
                    SqlHelper sqlHelp = new SqlHelper();
                    string projQuery = @"select * from QTOKEM_InternetHankkeet where Hanke_ID=" + projID;
                    SqlCommand sqCmd = sqlHelp.GetSqlQueryCommand(projQuery);
                    SqlDataReader dr = sqlHelp.ExecuteReader(sqCmd);
                    while (dr.Read())
                    {
                        objProjectDetail = new Project_Detail();
                        objProjectDetail.Nimi = dr["Nimi"] != null ? dr["Nimi"].ToString() : string.Empty;
                        objProjectDetail.Tavoite = dr["Tavoite"] != null ? dr["Tavoite"].ToString() : string.Empty;
                        objProjectDetail.Tulokset = dr["Tulokset"] != null ? dr["Tulokset"].ToString() : string.Empty;
                        objProjectDetail.Aikataulu = dr["Aikataulu"] != null ? dr["Aikataulu"].ToString() : string.Empty;
                        objProjectDetail.Kotisivut = dr["Kotisivut"] != null ? dr["Kotisivut"].ToString() : string.Empty;
                        objProjectDetail.Lisatietoja = dr["Lisatietoja"] != null ? dr["Lisatietoja"].ToString() : string.Empty;
                    }
                    dr.Close();
                    sqCmd = null;
                }
                else
                {
                    //lblMessage.Text = "Detail Not Found or ID is invalid";
                }
            }
            catch (Exception ex)
            {
                //lblMessage.Text = "BindProjects Error : " + ex.Message;
            }
            return objProjectDetail;
        }

        public List<Document_Detail> BindDocumentDetail(string projID)
        {
            List<Document_Detail> objDocDetail = null;
            try
            {
                SqlHelper sqlHelp = new SqlHelper();
                string query = @"Select ReportCode, DokumenttiURL, Filename from QTOKEM_HankeDokumentit
                                    where Hanke_ID=" + projID + "order by Filename";
                SqlCommand sqCmd = sqlHelp.GetSqlQueryCommand(query);
                SqlDataReader dr = sqlHelp.ExecuteReader(sqCmd);
                objDocDetail = new List<Document_Detail>();
                while (dr.Read())
                {
                    Document_Detail DocDetail = new Document_Detail();
                    DocDetail.ReportCode = Convert.ToString(dr["ReportCode"]);
                    DocDetail.DokumenttiURL = Convert.ToString(dr["DokumenttiURL"]);
                    DocDetail.Filename = Convert.ToString(dr["Filename"]);
                    objDocDetail.Add(DocDetail);
                }
                dr.Close();
                sqCmd = null;
            }
            catch (Exception ex)
            {

            }
            return objDocDetail;
        }

        public List<Paatoteuttaja_Detail> BindPaatoteuttaja(string projID)
        {
            List<Paatoteuttaja_Detail> objPartnerDetail = null;
            try
            {
                SqlHelper sqlHelp = new SqlHelper();
                //                string query = @"select * from QTOKEM_HankeOsapuoli a
                //                                    inner join QTOKEM_HankeRahoituslahde b
                //                                    on a.Hanke_ID = b.Hanke_ID
                //                                    where a.Hanke_ID = '" + projID + "' and (a.Rooli='1' or a.Rooli='4')";

                string query = @"select Hanke_ID,Rooli, Yhteiso from QTOKEM_HankeOsapuoli
                                    where (Rooli=1 or Rooli=4) and Yhteiso<>'' and
                                    Hanke_ID=" + projID + " order by Yhteiso";

                SqlCommand sqCmd = sqlHelp.GetSqlQueryCommand(query);
                SqlDataReader dr = sqlHelp.ExecuteReader(sqCmd);
                objPartnerDetail = new List<Paatoteuttaja_Detail>();
                while (dr.Read())
                {
                    Paatoteuttaja_Detail partnerDetail = new Paatoteuttaja_Detail();
                    partnerDetail.Hanke_ID = Convert.ToString(dr["Hanke_ID"]);
                    partnerDetail.Rooli = Convert.ToString(dr["Rooli"]);
                    partnerDetail.Yhteiso = Convert.ToString(dr["Yhteiso"]);
                    objPartnerDetail.Add(partnerDetail);
                }
                dr.Close();
                sqCmd = null;
            }
            catch (Exception ex)
            {
            }
            return objPartnerDetail;
        }

        public List<Rahoituslahde_Detail> BindRahoituslahde(string projID)
        {
            List<Rahoituslahde_Detail> objRahoituslahdeDetail = null;
            try
            {
                SqlHelper sqlHelp = new SqlHelper();
                //                string query = @"select * from QTOKEM_HankeOsapuoli a
                //                                    inner join QTOKEM_HankeRahoituslahde b
                //                                    on a.Hanke_ID = b.Hanke_ID
                //                                    where a.Hanke_ID = '" + projID + "' and (a.Rooli='1' or a.Rooli='4')";

                string query = @"Select * from QTOKEM_HankeRahoituslahde
                                    where Hanke_ID=" + projID + "order by Rahoituslahde";

                SqlCommand sqCmd = sqlHelp.GetSqlQueryCommand(query);
                SqlDataReader dr = sqlHelp.ExecuteReader(sqCmd);
                objRahoituslahdeDetail = new List<Rahoituslahde_Detail>();
                while (dr.Read())
                {
                    Rahoituslahde_Detail partnerDetail = new Rahoituslahde_Detail();
                    partnerDetail.Hanke_ID = Convert.ToString(dr["Hanke_ID"]);
                    partnerDetail.Rahoituslahde = Convert.ToString(dr["Rahoituslahde"]);
                    objRahoituslahdeDetail.Add(partnerDetail);
                }
                dr.Close();
                sqCmd = null;
            }
            catch (Exception ex)
            {
            }
            return objRahoituslahdeDetail;
        }

        public List<Project_Listing> BindProjects(string status)
        {
            List<Project_Listing>
                lstProjListing = new List<Project_Listing>();

            try
            {
                SqlHelper sqlHelp = new SqlHelper();
                string query = @"SELECT a.Hanke_ID, a.Nimi, b.JulkaisuPaikka
                                FROM QTOKEM_InternetHankkeet a
                                INNER JOIN QTOKEM_InternetJulkaisuPaikka b
                                ON a.Hanke_ID=b.Hanke_ID
                                order by Nimi";

                if (status == "1")
                {
                    query = @"SELECT a.Hanke_ID, a.Nimi, b.JulkaisuPaikka
                                FROM QTOKEM_InternetHankkeet a
                                INNER JOIN QTOKEM_InternetJulkaisuPaikka b
                                ON a.Hanke_ID=b.Hanke_ID
                                where a.Tila='3 Käynnissä'
                                order by Nimi";
                }
                else if (status == "2")
                {
                    query = @"SELECT a.Hanke_ID, a.Nimi, b.JulkaisuPaikka, a.Aikataulu
                                FROM QTOKEM_InternetHankkeet a
                                INNER JOIN QTOKEM_InternetJulkaisuPaikka b
                                ON a.Hanke_ID=b.Hanke_ID
                                where a.Tila='4 Päättynyt'
                                order by Nimi";
                }

                SqlCommand sqCmd = sqlHelp.GetSqlQueryCommand(query);
                SqlDataReader dr = sqlHelp.ExecuteReader(sqCmd);


                if (status == "1" || status == "0")
                {
                    while (dr.Read())
                    {
                        Project_Listing proj = new Project_Listing();
                        proj.Hanke_ID = Convert.ToString(dr["Hanke_ID"]);
                        proj.Nimi = Convert.ToString(dr["Nimi"]);
                        if (dr["JulkaisuPaikka"] != null)
                        {
                            if (Convert.ToString(dr["JulkaisuPaikka"]).StartsWith("AMK"))
                            {
                                string dptName = Convert.ToString(dr["JulkaisuPaikka"]);
                                proj.JulkaisuPaikka = dptName.Substring(4, (dptName.Length - 4));
                            }
                            else
                            {
                                proj.JulkaisuPaikka = Convert.ToString(dr["JulkaisuPaikka"]);
                            }
                        }
                        lstProjListing.Add(proj);
                    }
                    dr.Close();
                }
                else if (status == "2")
                {
                    while (dr.Read())
                    {
                        string strDt = Convert.ToString(dr["Aikataulu"]);
                        strDt = strDt.Split('-')[1].Trim();
                        DateTime dt = DateTime.ParseExact(strDt, "dd.MM.yyyy", CultureInfo.InvariantCulture);

                        //string newString = dt.ToString("MM/dd/yyyy");

                        Project_Listing proj = new Project_Listing();
                        proj.Hanke_ID = Convert.ToString(dr["Hanke_ID"]);
                        proj.Nimi = Convert.ToString(dr["Nimi"]);
                        if (dr["JulkaisuPaikka"] != null)
                        {
                            if (Convert.ToString(dr["JulkaisuPaikka"]).StartsWith("AMK"))
                            {
                                string dptName = Convert.ToString(dr["JulkaisuPaikka"]);
                                proj.JulkaisuPaikka = dptName.Substring(4, (dptName.Length - 4));
                            }
                            else
                            {
                                proj.JulkaisuPaikka = Convert.ToString(dr["JulkaisuPaikka"]);
                            }
                        }
                        if ((uint)System.Globalization.CultureInfo.CurrentUICulture.LCID == 1033)
                        {
                            proj.Aikataulu = Convert.ToDateTime(dt.ToString("MM/dd/yyyy"));//Convert.ToDateTime(dr["Aikataulu"]);
                        }
                        else if ((uint)System.Globalization.CultureInfo.CurrentUICulture.LCID == 1035)
                        {
                            proj.Aikataulu = Convert.ToDateTime(dt.ToString("dd.MM.yyyy"));
                        }
                        lstProjListing.Add(proj);
                    }
                    dr.Close();
                }

                //lstProjListing = lstProjListing.OrderByDescending(a => a.Aikataulu).ToList();
            }
            catch (Exception ex)
            {
                //lblMessage.Text = "BindProjects Error : " + ex.Message;
            }

            return lstProjListing;
        }
    }
}
