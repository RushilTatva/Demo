<%@ Page Language="C#" MasterPageFile="../../_catalogs/masterpage/LappiaMasterPage.master" Inherits="Microsoft.SharePoint.Publishing.PublishingLayoutPage,Microsoft.SharePoint.Publishing,Version=15.0.0.0,Culture=neutral,PublicKeyToken=71e9bce111e9429c" meta:webpartpageexpansion="full" meta:progid="SharePoint.WebPartPage.Document" %>

<%@ Register TagPrefix="SharePointWebControls" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register TagPrefix="WebPartPages" Namespace="Microsoft.SharePoint.WebPartPages" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register TagPrefix="PublishingWebControls" Namespace="Microsoft.SharePoint.Publishing.WebControls" Assembly="Microsoft.SharePoint.Publishing, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register TagPrefix="PublishingNavigation" Namespace="Microsoft.SharePoint.Publishing.Navigation" Assembly="Microsoft.SharePoint.Publishing, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>

<%--<asp:Content ID="PageHead" ContentPlaceHolderID="PlaceHolderAdditionalPageHead" runat="server">
</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="PlaceHolderPageTitle" runat="server">
</asp:Content>
<asp:Content ID="PageTitleInTitleArea" ContentPlaceHolderID="PlaceHolderPageTitleInTitleArea" runat="server">
</asp:Content>--%>
<asp:Content ID="Main" ContentPlaceHolderID="PlaceHolderMain" runat="server">
    <!-- banner start -->
    <div id="banner">
        <div class="flexslider">
            <ul class="slides">
                <li class="ban img1">
                    <h1>Onko sinulla juuri se oikea?</h1>
                    <h2>Siis ammatti.</h2>
                </li>
                <li class="ban img2">
                    <h1>Onko sinulla juuri se oikea?</h1>
                    <h2>Siis ammatti.</h2>
                </li>
            </ul>
        </div>
    </div>
    <!-- banner end -->

    <!-- content start -->
    <section id="content">
    
    <!-- section 1 start -->
    <section class="sec-1">
      <div class="wthfix sec1block">
        <div class="row">
          <div class="col-sm-4">
            <div class="sec1-box"><a href="#"><img src="<% $SPUrl:~sitecollection/Style Library/images/img1.png %>" class="float" alt=""><span class="greentext">NUORET</span></a></div>
          </div>
          <div class="col-sm-4">
            <div class="sec1-box"><a href="#"><img src="<% $SPUrl:~sitecollection/Style Library/images/img2.png %>" alt=""><span class="yellowtext">AIKUISET</span></a></div>
          </div>
          <div class="col-sm-4">
            <div class="sec1-box"><a href="#"><img src="<% $SPUrl:~sitecollection/Style Library/images/img3.png %>" alt=""><span class="purpletext">OPPISOPIMUS</span></a></div>
          </div>
        </div>
      </div>
    </section>
    <!-- section 1 start -->
        <section class="sec-1">
            <div class="wthfix sec1block">
                <div class="row">
                    <div class="col-sm-4">
                        <div class="sec1-box">
                            <WebPartPages:WebPartZone runat="server" Title="MainContent" ID="WebPartZone1" PartChromeType="None">
                                <ZoneTemplate>
                                </ZoneTemplate>
                            </WebPartPages:WebPartZone>
                        </div>
                    </div>
                    <div class="col-sm-4">
                        <div class="sec1-box">
                            <WebPartPages:WebPartZone runat="server" Title="MainContent" ID="WebPartZone2" PartChromeType="None">
                                <ZoneTemplate>
                                </ZoneTemplate>
                            </WebPartPages:WebPartZone>
                        </div>
                    </div>
                    <div class="col-sm-4">
                        <div class="sec1-box">
                            <WebPartPages:WebPartZone runat="server" Title="MainContent" ID="WebPartZone3" PartChromeType="None">
                                <ZoneTemplate>
                                </ZoneTemplate>
                            </WebPartPages:WebPartZone>
                        </div>
                    </div>
                </div>
            </div>
        </section>
        <!-- section 1 end -->

        <!-- section 2 start -->
        <section class="sec-2">
            <div class="wthfix sec2">
                <div class="row">
                    <div class="col-sm-6">
                        <WebPartPages:WebPartZone runat="server" Title="MainContent" ID="WebPartZone4" PartChromeType="None">
                            <ZoneTemplate>
                            </ZoneTemplate>
                        </WebPartPages:WebPartZone>
                    </div>
                    <div class="col-sm-6">
                        <WebPartPages:WebPartZone runat="server" Title="MainContent" ID="WebPartZone5" PartChromeType="None">
                            <ZoneTemplate>
                            </ZoneTemplate>
                        </WebPartPages:WebPartZone>
                    </div>
                </div>
            </div>
        </section>
        <!-- section 2 end -->

        <!-- section 3 start -->
        <section class="sec-3">
            <div class="wthfix sec3">
                <div class="row">
                    <div class="col-sm-6">
                        <WebPartPages:WebPartZone runat="server" Title="MainContent" ID="WebPartZone6" PartChromeType="None">
                            <ZoneTemplate>
                            </ZoneTemplate>
                        </WebPartPages:WebPartZone>
                    </div>
                    <div class="col-sm-6">
                        <WebPartPages:WebPartZone runat="server" Title="MainContent" ID="WebPartZone7" PartChromeType="None">
                            <ZoneTemplate>
                            </ZoneTemplate>
                        </WebPartPages:WebPartZone>
                    </div>
                </div>
            </div>
        </section>
        <!-- section 3 end -->

        <!-- section 4 start -->
        <section class="sec-4">
            <div class="wthfix">
                <div class="row">
                    <div class="col-sm-4">
                        <WebPartPages:WebPartZone runat="server" Title="MainContent" ID="WebPartZone8" PartChromeType="None">
                            <ZoneTemplate>
                            </ZoneTemplate>
                        </WebPartPages:WebPartZone>
                    </div>
                    <div class="col-sm-4 secondpad">
                        <WebPartPages:WebPartZone runat="server" Title="MainContent" ID="WebPartZone9" PartChromeType="None">
                            <ZoneTemplate>
                            </ZoneTemplate>
                        </WebPartPages:WebPartZone>
                    </div>
                    <div class="col-sm-4">
                        <WebPartPages:WebPartZone runat="server" Title="MainContent" ID="WebPartZone10" PartChromeType="None">
                            <ZoneTemplate>
                            </ZoneTemplate>
                        </WebPartPages:WebPartZone>
                    </div>
                </div>
            </div>
        </section>
        <!-- section 4 end -->
    
  </section>
    <!-- content end -->
</asp:Content>
