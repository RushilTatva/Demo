﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LappiaSPWeb.Root.Webparts.ProjectDetail {
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
    
    
    public partial class ProjectDetail {
        
        protected global::System.Web.UI.WebControls.Label lblMessage;
        
        protected global::System.Web.UI.WebControls.Label lblHeading;
        
        protected global::System.Web.UI.WebControls.Label ProjTitle;
        
        protected global::System.Web.UI.WebControls.Label lblTarget;
        
        protected global::System.Web.UI.WebControls.Label lblTavoite;
        
        protected global::System.Web.UI.WebControls.Label lblFinding;
        
        protected global::System.Web.UI.WebControls.Label lblTulokset;
        
        protected global::System.Web.UI.WebControls.Label lblSupervisor;
        
        protected global::System.Web.UI.WebControls.Label lblPaatoteuttaja;
        
        protected global::System.Web.UI.WebControls.Label lblOurPartners;
        
        protected global::System.Web.UI.WebControls.Label lblYhteistyokumppanit;
        
        protected global::System.Web.UI.WebControls.Label lblTimeTable;
        
        protected global::System.Web.UI.WebControls.Label lblAikataulu;
        
        protected global::System.Web.UI.WebControls.Label lblMoreInfo;
        
        protected global::System.Web.UI.WebControls.Label lblLisatietoja;
        
        protected global::System.Web.UI.WebControls.Label lblWebsite;
        
        protected global::System.Web.UI.WebControls.Label lblKotisivut;
        
        protected global::System.Web.UI.WebControls.Label lblSourceFinding;
        
        protected global::System.Web.UI.WebControls.Label lblRahoituslahde;
        
        protected global::System.Web.UI.WebControls.Label lblLogo;
        
        protected global::System.Web.UI.WebControls.Label lblLogoUrl;
        
        protected global::System.Web.UI.WebControls.Label lblAttachments;
        
        protected global::System.Web.UI.WebControls.Label lblLiitteet;
        
        protected global::System.Web.UI.WebControls.Panel pnlProjDetail;
        
        public static implicit operator global::System.Web.UI.TemplateControl(ProjectDetail target) 
        {
            return target == null ? null : target.TemplateControl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private global::System.Web.UI.WebControls.Label @__BuildControllblMessage() {
            global::System.Web.UI.WebControls.Label @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.Label();
            this.lblMessage = @__ctrl;
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.ID = "lblMessage";
            @__ctrl.Text = "";
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private global::System.Web.UI.WebControls.Label @__BuildControllblHeading() {
            global::System.Web.UI.WebControls.Label @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.Label();
            this.lblHeading = @__ctrl;
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.ID = "lblHeading";
            @__ctrl.Text = "";
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private global::System.Web.UI.WebControls.Label @__BuildControlProjTitle() {
            global::System.Web.UI.WebControls.Label @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.Label();
            this.ProjTitle = @__ctrl;
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.ID = "ProjTitle";
            @__ctrl.Text = "";
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private global::System.Web.UI.WebControls.Label @__BuildControllblTarget() {
            global::System.Web.UI.WebControls.Label @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.Label();
            this.lblTarget = @__ctrl;
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.ID = "lblTarget";
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private global::System.Web.UI.WebControls.Label @__BuildControllblTavoite() {
            global::System.Web.UI.WebControls.Label @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.Label();
            this.lblTavoite = @__ctrl;
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.ID = "lblTavoite";
            @__ctrl.Text = "";
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private global::System.Web.UI.WebControls.Label @__BuildControllblFinding() {
            global::System.Web.UI.WebControls.Label @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.Label();
            this.lblFinding = @__ctrl;
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.ID = "lblFinding";
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private global::System.Web.UI.WebControls.Label @__BuildControllblTulokset() {
            global::System.Web.UI.WebControls.Label @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.Label();
            this.lblTulokset = @__ctrl;
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.ID = "lblTulokset";
            @__ctrl.Text = "";
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private global::System.Web.UI.WebControls.Label @__BuildControllblSupervisor() {
            global::System.Web.UI.WebControls.Label @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.Label();
            this.lblSupervisor = @__ctrl;
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.ID = "lblSupervisor";
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private global::System.Web.UI.WebControls.Label @__BuildControllblPaatoteuttaja() {
            global::System.Web.UI.WebControls.Label @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.Label();
            this.lblPaatoteuttaja = @__ctrl;
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.ID = "lblPaatoteuttaja";
            @__ctrl.Text = "";
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private global::System.Web.UI.WebControls.Label @__BuildControllblOurPartners() {
            global::System.Web.UI.WebControls.Label @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.Label();
            this.lblOurPartners = @__ctrl;
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.ID = "lblOurPartners";
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private global::System.Web.UI.WebControls.Label @__BuildControllblYhteistyokumppanit() {
            global::System.Web.UI.WebControls.Label @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.Label();
            this.lblYhteistyokumppanit = @__ctrl;
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.ID = "lblYhteistyokumppanit";
            @__ctrl.Text = "";
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private global::System.Web.UI.WebControls.Label @__BuildControllblTimeTable() {
            global::System.Web.UI.WebControls.Label @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.Label();
            this.lblTimeTable = @__ctrl;
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.ID = "lblTimeTable";
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private global::System.Web.UI.WebControls.Label @__BuildControllblAikataulu() {
            global::System.Web.UI.WebControls.Label @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.Label();
            this.lblAikataulu = @__ctrl;
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.ID = "lblAikataulu";
            @__ctrl.Text = "";
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private global::System.Web.UI.WebControls.Label @__BuildControllblMoreInfo() {
            global::System.Web.UI.WebControls.Label @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.Label();
            this.lblMoreInfo = @__ctrl;
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.ID = "lblMoreInfo";
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private global::System.Web.UI.WebControls.Label @__BuildControllblLisatietoja() {
            global::System.Web.UI.WebControls.Label @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.Label();
            this.lblLisatietoja = @__ctrl;
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.ID = "lblLisatietoja";
            @__ctrl.Text = "";
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private global::System.Web.UI.WebControls.Label @__BuildControllblWebsite() {
            global::System.Web.UI.WebControls.Label @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.Label();
            this.lblWebsite = @__ctrl;
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.ID = "lblWebsite";
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private global::System.Web.UI.WebControls.Label @__BuildControllblKotisivut() {
            global::System.Web.UI.WebControls.Label @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.Label();
            this.lblKotisivut = @__ctrl;
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.ID = "lblKotisivut";
            @__ctrl.Text = "";
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private global::System.Web.UI.WebControls.Label @__BuildControllblSourceFinding() {
            global::System.Web.UI.WebControls.Label @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.Label();
            this.lblSourceFinding = @__ctrl;
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.ID = "lblSourceFinding";
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private global::System.Web.UI.WebControls.Label @__BuildControllblRahoituslahde() {
            global::System.Web.UI.WebControls.Label @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.Label();
            this.lblRahoituslahde = @__ctrl;
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.ID = "lblRahoituslahde";
            @__ctrl.Text = "";
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private global::System.Web.UI.WebControls.Label @__BuildControllblLogo() {
            global::System.Web.UI.WebControls.Label @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.Label();
            this.lblLogo = @__ctrl;
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.ID = "lblLogo";
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private global::System.Web.UI.WebControls.Label @__BuildControllblLogoUrl() {
            global::System.Web.UI.WebControls.Label @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.Label();
            this.lblLogoUrl = @__ctrl;
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.ID = "lblLogoUrl";
            @__ctrl.Text = "";
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private global::System.Web.UI.WebControls.Label @__BuildControllblAttachments() {
            global::System.Web.UI.WebControls.Label @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.Label();
            this.lblAttachments = @__ctrl;
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.ID = "lblAttachments";
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private global::System.Web.UI.WebControls.Label @__BuildControllblLiitteet() {
            global::System.Web.UI.WebControls.Label @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.Label();
            this.lblLiitteet = @__ctrl;
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.ID = "lblLiitteet";
            @__ctrl.Text = "";
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private global::System.Web.UI.WebControls.Panel @__BuildControlpnlProjDetail() {
            global::System.Web.UI.WebControls.Panel @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.Panel();
            this.pnlProjDetail = @__ctrl;
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.ID = "pnlProjDetail";
            System.Web.UI.IParserAccessor @__parser = ((System.Web.UI.IParserAccessor)(@__ctrl));
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n            <div class=\"form-group\">\r\n                <label class=\"col-sm-3 co" +
                        "ntrol-label\">\r\n                    "));
            global::System.Web.UI.WebControls.Label @__ctrl1;
            @__ctrl1 = this.@__BuildControllblTarget();
            @__parser.AddParsedSubObject(@__ctrl1);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("</label>\r\n                <div class=\"col-sm-9\">\r\n                    <p class=\"f" +
                        "orm-control-static\">\r\n                        "));
            global::System.Web.UI.WebControls.Label @__ctrl2;
            @__ctrl2 = this.@__BuildControllblTavoite();
            @__parser.AddParsedSubObject(@__ctrl2);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n                    </p>\r\n                </div>\r\n            </div>\r\n         " +
                        "   <div class=\"form-group\">\r\n                <label class=\"col-sm-3 control-labe" +
                        "l\">\r\n                    "));
            global::System.Web.UI.WebControls.Label @__ctrl3;
            @__ctrl3 = this.@__BuildControllblFinding();
            @__parser.AddParsedSubObject(@__ctrl3);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("</label>\r\n                <div class=\"col-sm-9\">\r\n                    <p class=\"f" +
                        "orm-control-static\">\r\n                        "));
            global::System.Web.UI.WebControls.Label @__ctrl4;
            @__ctrl4 = this.@__BuildControllblTulokset();
            @__parser.AddParsedSubObject(@__ctrl4);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n                    </p>\r\n                </div>\r\n            </div>\r\n         " +
                        "   <div class=\"form-group\">\r\n                <label class=\"col-sm-3 control-labe" +
                        "l\">\r\n                    "));
            global::System.Web.UI.WebControls.Label @__ctrl5;
            @__ctrl5 = this.@__BuildControllblSupervisor();
            @__parser.AddParsedSubObject(@__ctrl5);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("</label>\r\n                <div class=\"col-sm-9\">\r\n                    <p class=\"f" +
                        "orm-control-static\">\r\n                        "));
            global::System.Web.UI.WebControls.Label @__ctrl6;
            @__ctrl6 = this.@__BuildControllblPaatoteuttaja();
            @__parser.AddParsedSubObject(@__ctrl6);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n                    </p>\r\n                </div>\r\n            </div>\r\n         " +
                        "   <div class=\"form-group\">\r\n                <label class=\"col-sm-3 control-labe" +
                        "l\">\r\n                    "));
            global::System.Web.UI.WebControls.Label @__ctrl7;
            @__ctrl7 = this.@__BuildControllblOurPartners();
            @__parser.AddParsedSubObject(@__ctrl7);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("</label>\r\n                <div class=\"col-sm-9\">\r\n                    <p class=\"f" +
                        "orm-control-static\">\r\n                        "));
            global::System.Web.UI.WebControls.Label @__ctrl8;
            @__ctrl8 = this.@__BuildControllblYhteistyokumppanit();
            @__parser.AddParsedSubObject(@__ctrl8);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n                    </p>\r\n                </div>\r\n            </div>\r\n         " +
                        "   <div class=\"form-group\">\r\n                <label class=\"col-sm-3 control-labe" +
                        "l\">\r\n                    "));
            global::System.Web.UI.WebControls.Label @__ctrl9;
            @__ctrl9 = this.@__BuildControllblTimeTable();
            @__parser.AddParsedSubObject(@__ctrl9);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("</label>\r\n                <div class=\"col-sm-9\">\r\n                    <p class=\"f" +
                        "orm-control-static\">\r\n                        "));
            global::System.Web.UI.WebControls.Label @__ctrl10;
            @__ctrl10 = this.@__BuildControllblAikataulu();
            @__parser.AddParsedSubObject(@__ctrl10);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n                    </p>\r\n                </div>\r\n            </div>\r\n         " +
                        "   <div class=\"form-group\">\r\n                <label class=\"col-sm-3 control-labe" +
                        "l\">\r\n                    "));
            global::System.Web.UI.WebControls.Label @__ctrl11;
            @__ctrl11 = this.@__BuildControllblMoreInfo();
            @__parser.AddParsedSubObject(@__ctrl11);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("</label>\r\n                <div class=\"col-sm-9\">\r\n                    <p class=\"f" +
                        "orm-control-static\">\r\n                        "));
            global::System.Web.UI.WebControls.Label @__ctrl12;
            @__ctrl12 = this.@__BuildControllblLisatietoja();
            @__parser.AddParsedSubObject(@__ctrl12);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n                    </p>\r\n                </div>\r\n            </div>\r\n         " +
                        "   <div class=\"form-group\">\r\n                <label class=\"col-sm-3 control-labe" +
                        "l\">\r\n                    "));
            global::System.Web.UI.WebControls.Label @__ctrl13;
            @__ctrl13 = this.@__BuildControllblWebsite();
            @__parser.AddParsedSubObject(@__ctrl13);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("</label>\r\n                <div class=\"col-sm-9\">\r\n                    <p class=\"f" +
                        "orm-control-static\">\r\n                        "));
            global::System.Web.UI.WebControls.Label @__ctrl14;
            @__ctrl14 = this.@__BuildControllblKotisivut();
            @__parser.AddParsedSubObject(@__ctrl14);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n                    </p>\r\n                </div>\r\n            </div>\r\n         " +
                        "   <div class=\"form-group\">\r\n                <label class=\"col-sm-3 control-labe" +
                        "l\">\r\n                    "));
            global::System.Web.UI.WebControls.Label @__ctrl15;
            @__ctrl15 = this.@__BuildControllblSourceFinding();
            @__parser.AddParsedSubObject(@__ctrl15);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("</label>\r\n                <div class=\"col-sm-9\">\r\n                    <p class=\"f" +
                        "orm-control-static\">\r\n                        "));
            global::System.Web.UI.WebControls.Label @__ctrl16;
            @__ctrl16 = this.@__BuildControllblRahoituslahde();
            @__parser.AddParsedSubObject(@__ctrl16);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n                    </p>\r\n                </div>\r\n            </div>\r\n\r\n       " +
                        "     <div class=\"form-group\">\r\n                <label class=\"col-sm-3 control-la" +
                        "bel\">\r\n                    "));
            global::System.Web.UI.WebControls.Label @__ctrl17;
            @__ctrl17 = this.@__BuildControllblLogo();
            @__parser.AddParsedSubObject(@__ctrl17);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("</label>\r\n                <div class=\"col-sm-9\">\r\n                    <p class=\"f" +
                        "orm-control-static\">\r\n                        "));
            global::System.Web.UI.WebControls.Label @__ctrl18;
            @__ctrl18 = this.@__BuildControllblLogoUrl();
            @__parser.AddParsedSubObject(@__ctrl18);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n                    </p>\r\n                </div>\r\n            </div>\r\n         " +
                        "   <div class=\"form-group\">\r\n                <label class=\"col-sm-3 control-labe" +
                        "l\">\r\n                    "));
            global::System.Web.UI.WebControls.Label @__ctrl19;
            @__ctrl19 = this.@__BuildControllblAttachments();
            @__parser.AddParsedSubObject(@__ctrl19);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("</label>\r\n                <div class=\"col-sm-9\">\r\n                    <p class=\"f" +
                        "orm-control-static\">\r\n                        "));
            global::System.Web.UI.WebControls.Label @__ctrl20;
            @__ctrl20 = this.@__BuildControllblLiitteet();
            @__parser.AddParsedSubObject(@__ctrl20);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n                    </p>\r\n                </div>\r\n            </div>\r\n        "));
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        private void @__BuildControlTree(global::LappiaSPWeb.Root.Webparts.ProjectDetail.ProjectDetail @__ctrl) {
            global::System.Web.UI.WebControls.Label @__ctrl1;
            @__ctrl1 = this.@__BuildControllblMessage();
            System.Web.UI.IParserAccessor @__parser = ((System.Web.UI.IParserAccessor)(@__ctrl));
            @__parser.AddParsedSubObject(@__ctrl1);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n\r\n<div class=\"wthfix\">\r\n    <h1 class=\"mainheading\">"));
            global::System.Web.UI.WebControls.Label @__ctrl2;
            @__ctrl2 = this.@__BuildControllblHeading();
            @__parser.AddParsedSubObject(@__ctrl2);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("</h1>\r\n    <div class=\"detail_title\">\r\n        "));
            global::System.Web.UI.WebControls.Label @__ctrl3;
            @__ctrl3 = this.@__BuildControlProjTitle();
            @__parser.AddParsedSubObject(@__ctrl3);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n    </div>\r\n    <form class=\"form-horizontal cus-form\">\r\n        "));
            global::System.Web.UI.WebControls.Panel @__ctrl4;
            @__ctrl4 = this.@__BuildControlpnlProjDetail();
            @__parser.AddParsedSubObject(@__ctrl4);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n    </form>\r\n\r\n</div>\r\n"));
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
