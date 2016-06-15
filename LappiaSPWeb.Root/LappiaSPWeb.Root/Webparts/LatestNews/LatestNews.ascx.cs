#region System
using Microsoft.SharePoint;
using System;
using System.ComponentModel;
using System.Web.UI.WebControls.WebParts;
#endregion

namespace LappiaSPWeb.Root.Webparts.LatestNews
{
    [ToolboxItemAttribute(false)]
    public partial class LatestNews : WebPart
    {
        #region Page events

        // Uncomment the following SecurityPermission attribute only when doing Performance Profiling on a farm solution
        // using the Instrumentation method, and then remove the SecurityPermission attribute when the code is ready
        // for production. Because the SecurityPermission attribute bypasses the security check for callers of
        // your constructor, it's not recommended for production purposes.
        // [System.Security.Permissions.SecurityPermission(System.Security.Permissions.SecurityAction.Assert, UnmanagedCode = true)]
        public LatestNews()
        {
        }

        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            InitializeControl();
        }

        /// <summary>
        /// Page load event
        /// </summary>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                //lblTitle.Text = "Tapahtumat";
                //lblDescriptions.Text = @"Lorem ipsum dolor sit amet, consectetur adipisci elit, sed eiusmod tempor incidunt ut labore et dolore magna aliqua. Lorem ipsum dolor sit amet, consectetur adipisci elit, sedeiusmod tempor incidunt ut labore et dolore magna aliqua.";
                BindLatestNews();
            }
        }

        #endregion

        #region Private methods

        /// <summary>
        /// Get last added news
        /// </summary>
        private void BindLatestNews()
        {
            using (SPSite site = new SPSite(SPContext.Current.Web.Url))
            {
                using (SPWeb web = site.OpenWeb())
                {
                    SPList _list = web.Lists.TryGetList("Customlist");
                    if (_list != null)
                    {
                        SPQuery query = new SPQuery();
                        query.RowLimit = 1;
                        query.Query = "<OrderBy><FieldRef Name='Modified' Ascending='FALSE' /></OrderBy>";
                        SPListItemCollection _items = _list.GetItems(query);
                        if (_items != null && _items.Count > 0)
                        {
                            SPListItem _item = _items[0];
                            lblTitle.Text = Convert.ToString(_item["Title"]);
                            lblDescriptions.Text = Convert.ToString(_item["Description"]);
                            imgAttachment.ImageUrl = _item.Attachments != null ? _item.Attachments.UrlPrefix + _item.Attachments[0].ToString() : SPContext.Current.Web.Url + "/Style Library/images/noimg.jpg";
                        }
                    }
                }
            }
        }

        #endregion
    }
}
