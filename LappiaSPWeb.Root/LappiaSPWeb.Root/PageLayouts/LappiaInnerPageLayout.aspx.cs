using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using Microsoft.SharePoint;
using System;
using System.IO;
using System.Threading.Tasks;

namespace LappiaSPWeb.Root.PageLayouts
{
    public class LappiaInnerPageLayout : Microsoft.SharePoint.Publishing.PublishingLayoutPage
    {
        #region Declare variables
        protected System.Web.UI.HtmlControls.HtmlGenericControl inner_banner;
        #endregion
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    string temp = string.Empty;
                    if (!string.IsNullOrEmpty(Convert.ToString(SPContext.Current.File.Item["PublishingRollupImage"])))
                    {
                        temp = Convert.ToString(SPContext.Current.File.Item["PublishingRollupImage"]);
                        if (!string.IsNullOrEmpty(temp))
                        {
                            temp = temp.Substring(temp.IndexOf("src") + 3);
                            string imagesrc = temp.Substring(temp.IndexOf("src") + 3, temp.IndexOf("style") - 4);
                            //inner_banner.Style["background-image"] = imagesrc;
                            inner_banner.Style.Add("background-image", imagesrc);

                            //ScriptManager.RegisterStartupScript(this.Page, Page.GetType(), "Call Accordian", "Test('" + imagesrc + "');", true);

                        }
                        
                    }
                    else
                    {
                        inner_banner.Style.Add("display", "none");
                    }
                }
                catch(Exception ex)
                {
                    LappiaUtility.LappiaUtility.AddErrorLog(SPContext.Current.Web.Url, "LappiaInnerPageLayout -  Page_Load", Convert.ToString(ex), LappiaUtility.LappiaUtility.ErrorSeverity.High);
                }
            }
        }
    }
}
