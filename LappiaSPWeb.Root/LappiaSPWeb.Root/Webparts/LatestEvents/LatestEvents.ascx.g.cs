﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LappiaSPWeb.Root.Webparts.LatestEvents {
    using System.Web.UI.WebControls.Expressions;
    using System.Web.UI.HtmlControls;
    using System.Collections;
    using System.Text;
    using System.Web.UI;
    using System.Collections.Generic;
    using System.Linq;
    using System.Xml.Linq;
    using Microsoft.SharePoint.WebPartPages;
    using System.Web.SessionState;
    using System.Configuration;
    using Microsoft.SharePoint;
    using System.Web;
    using System.Web.DynamicData;
    using System.Web.Caching;
    using System.Web.Profile;
    using System.ComponentModel.DataAnnotations;
    using System.Web.UI.WebControls;
    using System.Web.Security;
    using System;
    using Microsoft.SharePoint.Utilities;
    using System.Text.RegularExpressions;
    using System.Collections.Specialized;
    using System.Web.UI.WebControls.WebParts;
    using Microsoft.SharePoint.WebControls;
    
    
    public partial class LatestEvents {
        
        public static implicit operator global::System.Web.UI.TemplateControl(LatestEvents target) 
        {
            return target == null ? null : target.TemplateControl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private void @__BuildControlTree(global::LappiaSPWeb.Root.Webparts.LatestEvents.LatestEvents @__ctrl) {
            System.Web.UI.IParserAccessor @__parser = ((System.Web.UI.IParserAccessor)(@__ctrl));
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl(@"
<h2 class=""title"">Tapahtumat</h2>
<ul class=""sec2-list"">
    <li>
        <div class=""date""><span>6</span>KESÄ</div>
        <div class=""text""><a href=""#"">Consectetur adipisci elit.</a></div>
    </li>
    <li>
        <div class=""date""><span>15</span>HEINÄ</div>
        <div class=""text""><a href=""#"">Sed eiusmod tempor incidunt ut labore.</a></div>
    </li>
    <li>
        <div class=""date""><span>20</span>MARRAS</div>
        <div class=""text""><a href=""#"">Sunt in culpa qui officia.</a></div>
    </li>
    <li>
        <div class=""date""><span>18</span>JOULU</div>
        <div class=""text""><a href=""#"">Et dolore magna aliqua.</a></div>
    </li>
</ul>
<a href=""#"">Tapahtumakalenteri</a>"));
        }
        
        private void InitializeControl() {
            this.@__BuildControlTree(this);
            this.Load += new global::System.EventHandler(this.Page_Load);
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        protected virtual object Eval(string expression) {
            return global::System.Web.UI.DataBinder.Eval(this.Page.GetDataItem(), expression);
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        protected virtual string Eval(string expression, string format) {
            return global::System.Web.UI.DataBinder.Eval(this.Page.GetDataItem(), expression, format);
        }
    }
}
