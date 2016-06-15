#region System
using System;
using System.ComponentModel;
using System.Web.UI.WebControls.WebParts;
#endregion

namespace LappiaSPWeb.Root.Webparts.BannerWebpart
{
    [ToolboxItemAttribute(false)]
    public partial class BannerWebpart : WebPart
    {
        #region Page Events

        // Uncomment the following SecurityPermission attribute only when doing Performance Profiling on a farm solution
        // using the Instrumentation method, and then remove the SecurityPermission attribute when the code is ready
        // for production. Because the SecurityPermission attribute bypasses the security check for callers of
        // your constructor, it's not recommended for production purposes.
        // [System.Security.Permissions.SecurityPermission(System.Security.Permissions.SecurityAction.Assert, UnmanagedCode = true)]
        public BannerWebpart()
        {
        }

        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            InitializeControl();
        }

        /// <summary>
        /// Page Load event
        /// </summary>
        protected void Page_Load(object sender, EventArgs e)
        {
            string _property1 = "Text Value : " + TextProperty1;
            string _property2 = "Enum Value : " + EnumProperty1.ToString();
        }

        #endregion

        #region Custom Properties

        [WebBrowsable(true), WebDisplayName("Text Input"), WebDescription("This Accepts text Input"), Personalizable(PersonalizationScope.Shared), Category("My Category")]
        public string TextProperty1 { get; set; }

        public enum MyEnum
        {
            Option1,
            Option2
        }

        [WebBrowsable(true), WebDisplayName("Dropdown Input"), WebDescription("This Accepts My Enum"), Personalizable(PersonalizationScope.Shared), Category("My Category")]
        public MyEnum EnumProperty1 { get; set; }

        #endregion

    }
}
