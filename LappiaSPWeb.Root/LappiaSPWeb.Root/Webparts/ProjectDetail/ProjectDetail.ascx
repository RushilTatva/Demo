<%@ Assembly Name="$SharePoint.Project.AssemblyFullName$" %>
<%@ Assembly Name="Microsoft.Web.CommandUI, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register TagPrefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register TagPrefix="Utilities" Namespace="Microsoft.SharePoint.Utilities" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register TagPrefix="asp" Namespace="System.Web.UI" Assembly="System.Web.Extensions, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" %>
<%@ Import Namespace="Microsoft.SharePoint" %>
<%@ Register TagPrefix="WebPartPages" Namespace="Microsoft.SharePoint.WebPartPages" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ProjectDetail.ascx.cs" Inherits="LappiaSPWeb.Root.Webparts.ProjectDetail.ProjectDetail" %>

<asp:Label ID="lblMessage" runat="server" Text=""></asp:Label>

<div class="wthfix">
    <h1 class="mainheading"><asp:Label ID="lblHeading" runat="server" Text=""></asp:Label></h1>
    <div class="detail_title">
        <asp:Label ID="ProjTitle" runat="server" Text=""></asp:Label>
    </div>
    <form class="form-horizontal cus-form">
        <asp:Panel ID="pnlProjDetail" runat="server">
            <div class="form-group">
                <label class="col-sm-3 control-label">
                    <asp:Label ID="lblTarget" runat="server"></asp:Label></label>
                <div class="col-sm-9">
                    <p class="form-control-static">
                        <asp:Label ID="lblTavoite" runat="server" Text=""></asp:Label>
                    </p>
                </div>
            </div>
            <div class="form-group">
                <label class="col-sm-3 control-label">
                    <asp:Label ID="lblFinding" runat="server"></asp:Label></label>
                <div class="col-sm-9">
                    <p class="form-control-static">
                        <asp:Label ID="lblTulokset" runat="server" Text=""></asp:Label>
                    </p>
                </div>
            </div>
            <div class="form-group">
                <label class="col-sm-3 control-label">
                    <asp:Label ID="lblSupervisor" runat="server"></asp:Label></label>
                <div class="col-sm-9">
                    <p class="form-control-static">
                        <asp:Label ID="lblPaatoteuttaja" runat="server" Text=""></asp:Label>
                    </p>
                </div>
            </div>
            <div class="form-group">
                <label class="col-sm-3 control-label">
                    <asp:Label ID="lblOurPartners" runat="server"></asp:Label></label>
                <div class="col-sm-9">
                    <p class="form-control-static">
                        <asp:Label ID="lblYhteistyokumppanit" runat="server" Text=""></asp:Label>
                    </p>
                </div>
            </div>
            <div class="form-group">
                <label class="col-sm-3 control-label">
                    <asp:Label ID="lblTimeTable" runat="server"></asp:Label></label>
                <div class="col-sm-9">
                    <p class="form-control-static">
                        <asp:Label ID="lblAikataulu" runat="server" Text=""></asp:Label>
                    </p>
                </div>
            </div>
            <div class="form-group">
                <label class="col-sm-3 control-label">
                    <asp:Label ID="lblMoreInfo" runat="server"></asp:Label></label>
                <div class="col-sm-9">
                    <p class="form-control-static">
                        <asp:Label ID="lblLisatietoja" runat="server" Text=""></asp:Label>
                    </p>
                </div>
            </div>
            <div class="form-group">
                <label class="col-sm-3 control-label">
                    <asp:Label ID="lblWebsite" runat="server"></asp:Label></label>
                <div class="col-sm-9">
                    <p class="form-control-static">
                        <asp:Label ID="lblKotisivut" runat="server" Text=""></asp:Label>
                    </p>
                </div>
            </div>
            <div class="form-group">
                <label class="col-sm-3 control-label">
                    <asp:Label ID="lblSourceFinding" runat="server"></asp:Label></label>
                <div class="col-sm-9">
                    <p class="form-control-static">
                        <asp:Label ID="lblRahoituslahde" runat="server" Text=""></asp:Label>
                    </p>
                </div>
            </div>

            <div class="form-group">
                <label class="col-sm-3 control-label">
                    <asp:Label ID="lblLogo" runat="server"></asp:Label></label>
                <div class="col-sm-9">
                    <p class="form-control-static">
                        <asp:Label ID="lblLogoUrl" runat="server" Text=""></asp:Label>
                    </p>
                </div>
            </div>
            <div class="form-group">
                <label class="col-sm-3 control-label">
                    <asp:Label ID="lblAttachments" runat="server"></asp:Label></label>
                <div class="col-sm-9">
                    <p class="form-control-static">
                        <asp:Label ID="lblLiitteet" runat="server" Text=""></asp:Label>
                    </p>
                </div>
            </div>
        </asp:Panel>
    </form>

</div>
