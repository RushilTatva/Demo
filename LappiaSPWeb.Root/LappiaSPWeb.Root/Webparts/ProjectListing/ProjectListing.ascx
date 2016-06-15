<%@ Assembly Name="$SharePoint.Project.AssemblyFullName$" %>
<%@ Assembly Name="Microsoft.Web.CommandUI, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register TagPrefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register TagPrefix="Utilities" Namespace="Microsoft.SharePoint.Utilities" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register TagPrefix="asp" Namespace="System.Web.UI" Assembly="System.Web.Extensions, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" %>
<%@ Import Namespace="Microsoft.SharePoint" %>
<%@ Register TagPrefix="WebPartPages" Namespace="Microsoft.SharePoint.WebPartPages" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ProjectListing.ascx.cs" Inherits="LappiaSPWeb.Root.Webparts.ProjectListing.ProjectListing" %>
<script type='text/javascript'>
    _spOriginalFormAction = document.forms[0].action;
    _spSuppressFormOnSubmitWrapper = true;
</script>

<style type="text/css">
    .form-control {
        width: 200px !important;
        display: inline!important;
    }
</style>

<asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>
        <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label>

        <h1 class="mainheading">
            <asp:Label ID="lblHeading" runat="server" Text=""></asp:Label></h1>
        <div class="sr_block">
            <form class="form-inline">
                <div class="form-group">
                    <label class="textlabel">
                        <asp:Label ID="lblProjectStatus" runat="server" Text=""></asp:Label></label>
                    <asp:DropDownList ID="drpStatus" runat="server" AutoPostBack="True" class="form-control" Style="min-width: 200px !important;" OnSelectedIndexChanged="drpStatus_SelectedIndexChanged">
                    </asp:DropDownList>
                </div>
            </form>
        </div>
        <asp:Label ID="lblProjListing" runat="server" Text=""></asp:Label>
    </ContentTemplate>
</asp:UpdatePanel>


