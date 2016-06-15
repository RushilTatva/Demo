<%@ Assembly Name="$SharePoint.Project.AssemblyFullName$" %>
<%@ Register TagPrefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register TagPrefix="Utilities" Namespace="Microsoft.SharePoint.Utilities" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register TagPrefix="asp" Namespace="System.Web.UI" Assembly="System.Web.Extensions, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" %>
<%@ Import Namespace="Microsoft.SharePoint" %>
<%@ Assembly Name="Microsoft.Web.CommandUI, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register TagPrefix="SharePointWebControls" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register TagPrefix="WebPartPages" Namespace="Microsoft.SharePoint.WebPartPages" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>

<%@ Page Language="C#" MasterPageFile="../_catalogs/masterpage/LappiaMasterPage.master" Title="Lappia - Project Listing" %>
<%--<%@ Page Language="C#" MasterPageFile="$SPUrl:~sitecollection/_catalogs/masterpage/seattle.master" Title="Lappia - Project Listing" %>--%>

<%@ Register TagPrefix="ProjectListing" Namespace="LappiaSPWeb.Root.Webparts.ProjectListing" Assembly="LappiaSPWeb.Root, Version=1.0.0.0, Culture=neutral, PublicKeyToken=969e4a4c61829e02" %>

<asp:Content ID="PageHead" ContentPlaceHolderID="PlaceHolderAdditionalPageHead" runat="server">
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="PlaceHolderPageTitle" runat="server">
    Lappia - Project Listing
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="PlaceHolderMain" runat="server">

    <WebPartPages:WebPartZone runat="server" Title="MainContent" ID="WebPartZone1" PartChromeType="None">
        <ZoneTemplate>
            <ProjectListing:ProjectListing ID="ProjectListing" runat="server" ChromeType="None" />
        </ZoneTemplate>
    </WebPartPages:WebPartZone>

</asp:Content>
