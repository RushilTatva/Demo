<%@ Page Language="C#" Inherits="Microsoft.SharePoint.Publishing.PublishingLayoutPage,Microsoft.SharePoint.Publishing,Version=15.0.0.0,Culture=neutral,PublicKeyToken=71e9bce111e9429c" MasterPageFile="../../_catalogs/masterpage/LappiaMasterPage.master" %>

<%@ Register TagPrefix="SharePointWebControls" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register TagPrefix="WebPartPages" Namespace="Microsoft.SharePoint.WebPartPages" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register TagPrefix="PublishingWebControls" Namespace="Microsoft.SharePoint.Publishing.WebControls" Assembly="Microsoft.SharePoint.Publishing, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register TagPrefix="PublishingNavigation" Namespace="Microsoft.SharePoint.Publishing.Navigation" Assembly="Microsoft.SharePoint.Publishing, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>

<%--<asp:content id="Content1" contentplaceholderid="PlaceHolderAdditionalPageHead" runat="server">
</asp:content>
<asp:content id="Content2" contentplaceholderid="PlaceHolderPageTitle" runat="server">
</asp:content>--%>
<asp:Content ID="Content3" ContentPlaceHolderID="PlaceHolderMain" runat="server">

    <!-- banner start -->
    <div id="banner">
        <div class="flexslider">
            <WebPartPages:WebPartZone runat="server" Title="Flexslider" ID="FlexsliderWPZone" PartChromeType="None">
                <ZoneTemplate>
                </ZoneTemplate>
            </WebPartPages:WebPartZone>
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
                        <div class="sec1-box">
                            <WebPartPages:WebPartZone runat="server" Title="YoungPeopleLink" ID="YoungPeopleLinkrWPZone" PartChromeType="None">
                                <ZoneTemplate>
                                </ZoneTemplate>
                            </WebPartPages:WebPartZone>
                        </div>
                    </div>
                    <div class="col-sm-4">
                        <div class="sec1-box">
                            <WebPartPages:WebPartZone runat="server" Title="AdultLink" ID="AdultLinkWPZone" PartChromeType="None">
                                <ZoneTemplate>
                                </ZoneTemplate>
                            </WebPartPages:WebPartZone>
                        </div>
                    </div>
                    <div class="col-sm-4">
                        <div class="sec1-box">
                            <WebPartPages:WebPartZone runat="server" Title="OldPeopleLink" ID="OldPeopleLinkWPZone" PartChromeType="None">
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
                        <WebPartPages:WebPartZone runat="server" Title="EventsLink" ID="EventsLinkWPZone" PartChromeType="None">
                            <ZoneTemplate>
                            </ZoneTemplate>
                        </WebPartPages:WebPartZone>
                    </div>
                    <div class="col-sm-6">
                        <WebPartPages:WebPartZone runat="server" Title="CustomWorksLink" ID="CustomWorksLinkWPZone" PartChromeType="None">
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
                        <WebPartPages:WebPartZone runat="server" Title="LatestNews" ID="LatestNewsWPZone" PartChromeType="None">
                            <ZoneTemplate>
                            </ZoneTemplate>
                        </WebPartPages:WebPartZone>
                   
            </div>
                </div>
        </section>
        <!-- section 3 end -->

        <!-- section 4 start -->
        <section class="sec-4">
            <div class="wthfix">
                <div class="row">
                    <div class="col-sm-4">
                        <WebPartPages:WebPartZone runat="server" Title="ProjectListingLink" ID="ProjectListingLinkWPZone" PartChromeType="None">
                            <ZoneTemplate>
                            </ZoneTemplate>
                        </WebPartPages:WebPartZone>
                    </div>
                    <div class="col-sm-4 secondpad">
                        <WebPartPages:WebPartZone runat="server" Title="NewsList" ID="NewsListWPZone" PartChromeType="None">
                            <ZoneTemplate>
                            </ZoneTemplate>
                        </WebPartPages:WebPartZone>
                    </div>
                    <div class="col-sm-4">
                        <WebPartPages:WebPartZone runat="server" Title="MediaList" ID="MediaListWPZone" PartChromeType="None">
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

    <!-- footer start -->
    <footer id="footer">
  
    <div class="sociallink">
      <div class="social">
        <div class="col5"><a href="https://www.facebook.com/AOLappia" target="_blank" title="facebook" class="sl facebook"></a></div>
        <div class="col5"><a href="https://twitter.com/aolappia" target="_blank" title="twitter" class="sl twitter"></a></div>
        <div class="col5"><a href="https://instagram.com/aolappia/" target="_blank" title="instagram" class="sl instagram"></a></div>
        <div class="col5"><a href="https://www.youtube.com/user/AOLappia" target="_blank" title="youtube" class="sl youtube"></a></div>
        <div class="col5"><a href="http://ask.fm/aolappia" target="_blank" title="ask" class="sl ask"></a></div>
      </div>
    </div>

        <div class="wthfix footbottom">
      <div class="footerlink">
        <div class="row">
          <div class="col-sm-3 col-md-3">
            <h5><asp:Literal ID="Literal1" runat="server" Text="<%$ Resources:LappiaRootFooter, SubjectAreas %>"></asp:Literal></h5>
            <ul>
            	<li><a href="#"><asp:Literal ID="Literal2" runat="server" Text="<%$ Resources:LappiaRootFooter, WellBeing %>"></asp:Literal></a></li>
                <li><a href="#"><asp:Literal ID="Literal3" runat="server" Text="<%$ Resources:LappiaRootFooter, Culture %>"></asp:Literal></a></li>
                <li><a href="#"><asp:Literal ID="Literal4" runat="server" Text="<%$ Resources:LappiaRootFooter, WellBeing %>"></asp:Literal></a></li>
                <li><a href="#"><asp:Literal ID="Literal5" runat="server" Text="<%$ Resources:LappiaRootFooter, ServiceSector %>"></asp:Literal></a></li>
                <li><a href="#"><asp:Literal ID="Literal6" runat="server" Text="<%$ Resources:LappiaRootFooter, TechnicalField %>"></asp:Literal></a></li>
            </ul>
          </div>
          <div class="col-sm-3 col-md-3">
            <h5><asp:Literal ID="Literal7" runat="server" Text="<%$ Resources:LappiaRootFooter, Studies %>"></asp:Literal></h5>
            <ul>
            	<li><a href="#"><asp:Literal ID="Literal8" runat="server" Text="<%$ Resources:LappiaRootFooter, YouthEducation %>"></asp:Literal></a></li>
                <li><a href="#"><asp:Literal ID="Literal9" runat="server" Text="<%$ Resources:LappiaRootFooter, AdultEducation %>"></asp:Literal></a></li>
                <li><a href="#"><asp:Literal ID="Literal10" runat="server" Text="<%$ Resources:LappiaRootFooter, Apprenticeship %>"></asp:Literal></a></li>
            </ul>
          </div>
          <div class="col-sm-3 col-md-3">
            <h5><asp:Literal ID="Literal11" runat="server" Text="<%$ Resources:LappiaRootFooter, Contact %>"></asp:Literal></h5>
            <ul>
            	<li><a href="#"><asp:Literal ID="Literal12" runat="server" Text="<%$ Resources:LappiaRootFooter, Locations %>"></asp:Literal></a></li>
            	<li><a href="#"><asp:Literal ID="Literal13" runat="server" Text="<%$ Resources:LappiaRootFooter, Staff %>"></asp:Literal></a></li>
            	<li><a href="#"><asp:Literal ID="Literal14" runat="server" Text="<%$ Resources:LappiaRootFooter, AdultEducation %>"></asp:Literal></a></li>
            	<li><a href="#"><asp:Literal ID="Literal15" runat="server" Text="<%$ Resources:LappiaRootFooter, ProjectServices %>"></asp:Literal></a></li>
            	<li><a href="#"><asp:Literal ID="Literal16" runat="server" Text="<%$ Resources:LappiaRootFooter, ApprenticeshipOffice %>"></asp:Literal></a></li>
            	<li><a href="#"><asp:Literal ID="Literal17" runat="server" Text="<%$ Resources:LappiaRootFooter, ClientWorks %>"></asp:Literal></a></li>
            	<li><a href="#"><asp:Literal ID="Literal18" runat="server" Text="<%$ Resources:LappiaRootFooter, RestaurantsAndCafes %>"></asp:Literal></a></li>
            	<li><a href="#"><asp:Literal ID="Literal19" runat="server" Text="<%$ Resources:LappiaRootFooter, BillingAddress %>"></asp:Literal></a></li>
            	<li><a href="#"><asp:Literal ID="Literal20" runat="server" Text="<%$ Resources:LappiaRootFooter, FederationofMunicipalities %>"></asp:Literal></a></li>
            </ul>
          </div>
          <div class="col-sm-3 col-md-3">
            <h5><asp:Literal ID="Literal21" runat="server" Text="<%$ Resources:LappiaRootFooter, Education %>"></asp:Literal></h5>
            <ul>
            	<li><a href="#"><asp:Literal ID="Literal22" runat="server" Text="<%$ Resources:LappiaRootFooter, Demonstration %>"></asp:Literal></a></li>
            	<li><a href="#"><asp:Literal ID="Literal23" runat="server" Text="<%$ Resources:LappiaRootFooter, Organization %>"></asp:Literal></a></li>
            	<li><a href="#"><asp:Literal ID="Literal24" runat="server" Text="<%$ Resources:LappiaRootFooter, Functions %>"></asp:Literal></a></li>
            	<li><a href="#"><asp:Literal ID="Literal25" runat="server" Text="<%$ Resources:LappiaRootFooter, StrategyVvaluesKeyFigures %>"></asp:Literal></a></li>
            	<li><a href="#"><asp:Literal ID="Literal26" runat="server" Text="<%$ Resources:LappiaRootFooter, GroupServices %>"></asp:Literal></a></li>
            	<li><a href="#"><asp:Literal ID="Literal27" runat="server" Text="<%$ Resources:LappiaRootFooter, Decision %>"></asp:Literal></a></li>
            </ul>
          </div>
        </div>
      </div>
      <div class="addresslink"><a href="#"><asp:Literal ID="Literal28" runat="server" Text="<%$ Resources:LappiaRootFooter, SiteMap %>"></asp:Literal></a> | <a href="#"><asp:Literal ID="Literal29" runat="server" Text="<%$ Resources:LappiaRootFooter, AboutThisSite %>"></asp:Literal></a> | <a href="#"><asp:Literal ID="Literal30" runat="server" Text="<%$ Resources:LappiaRootFooter, Feedback %>"></asp:Literal></a> | <a href="linkto:ammattiopisto@lappia.fi">ammattiopisto@lappia.fi</a> | <asp:Literal ID="Literal31" runat="server" Text="<%$ Resources:LappiaRootFooter, Address %>"></asp:Literal></div>
    
    <!-- footer end -->
</asp:Content>
