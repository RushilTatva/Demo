<%--<%@ Page Language="C#" Inherits="LappiaSPWeb.Root.PageLayouts.LappiaArticlePageLayout, $SharePoint.Project.AssemblyFullName$" MasterPageFile="../../_catalogs/masterpage/LappiaMasterPage.master" %>--%>

<%@ Page Language="C#" Inherits="LappiaSPWeb.Root.PageLayouts.LappiaArticlePageLayout, $SharePoint.Project.AssemblyFullName$" MasterPageFile="../../_catalogs/masterpage/LappiaMasterPage.master" %>

<%@ Register TagPrefix="SharePointWebControls" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register TagPrefix="WebPartPages" Namespace="Microsoft.SharePoint.WebPartPages" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register TagPrefix="PublishingWebControls" Namespace="Microsoft.SharePoint.Publishing.WebControls" Assembly="Microsoft.SharePoint.Publishing, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register TagPrefix="PublishingNavigation" Namespace="Microsoft.SharePoint.Publishing.Navigation" Assembly="Microsoft.SharePoint.Publishing, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>

<%@ Register TagPrefix="BreadcrumbWP" Namespace="LappiaSPWeb.Root.Webparts.Breadcrumb" Assembly="LappiaSPWeb.Root, Version=1.0.0.0, Culture=neutral, PublicKeyToken=969e4a4c61829e02" %>
<%@ Register TagPrefix="LeftNavigationMenuWP" Namespace="LappiaSPWeb.Root.Webparts.LeftNavigationMenu" Assembly="LappiaSPWeb.Root, Version=1.0.0.0, Culture=neutral, PublicKeyToken=969e4a4c61829e02" %>

<asp:Content ID="Content3" ContentPlaceHolderID="PlaceHolderMain" runat="server">
    <div id="inner_banner" runat="server" class="inbn1">
        <PublishingWebControls:EditModePanel runat="server" ID="EditModePanel1" PageDisplayMode="Edit">   
                   <PublishingWebControls:RichImageField ID="PublishingRollupImage" FieldName="PublishingRollupImage" runat="server"></PublishingWebControls:RichImageField>
        </PublishingWebControls:EditModePanel>
    </div>
    <section id="content" class="inner_area">
        <!-- inner start -->
        <div class="wthfix">
            <div class="bc_spac">
             <WebPartPages:WebPartZone runat="server" Title="breadCrumb" ID="breadCrumb" PartChromeType="None">
                    <ZoneTemplate>
                    </ZoneTemplate>
                </WebPartPages:WebPartZone>
            </div>
            <div class="leftside">
                <WebPartPages:WebPartZone runat="server" Title="LeftMenu" ID="LeftMenu" PartChromeType="None">
                    <ZoneTemplate>
                    </ZoneTemplate>
                </WebPartPages:WebPartZone>
            </div>
            <div class="middle">
                <PublishingWebControls:RichHtmlField id="PageContent" FieldName="PublishingPageContent" runat="server" PrefixStyleSheet="my-rte"/>
                <WebPartPages:WebPartZone runat="server" Title="ContentArea" ID="ContentArea" PartChromeType="None">
                    <ZoneTemplate>
                        
                    </ZoneTemplate>
                </WebPartPages:WebPartZone>
            </div>
            <div class="clear"></div>
        </div>
        <!-- inner end -->
    </section>
</asp:Content>
