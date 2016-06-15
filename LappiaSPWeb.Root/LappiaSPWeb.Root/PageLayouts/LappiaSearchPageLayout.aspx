﻿<%@ Page Language="C#" Inherits="LappiaSPWeb.Root.PageLayouts.LappiaSearchPageLayout, $SharePoint.Project.AssemblyFullName$" MasterPageFile="../../_catalogs/masterpage/LappiaMasterPage.master" %>

<%@ Register TagPrefix="SharePointWebControls" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register TagPrefix="WebPartPages" Namespace="Microsoft.SharePoint.WebPartPages" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register TagPrefix="PublishingWebControls" Namespace="Microsoft.SharePoint.Publishing.WebControls" Assembly="Microsoft.SharePoint.Publishing, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register TagPrefix="PublishingNavigation" Namespace="Microsoft.SharePoint.Publishing.Navigation" Assembly="Microsoft.SharePoint.Publishing, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
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
                <WebPartPages:WebPartZone runat="server" Title="SearchArea" ID="SearchArea" PartChromeType="None">
                    <ZoneTemplate>
                    </ZoneTemplate>
                </WebPartPages:WebPartZone>
            <div class="department-content">
                <WebPartPages:WebPartZone runat="server" Title="ContentArea" ID="ContentArea" PartChromeType="None">
                    <ZoneTemplate>
                    </ZoneTemplate>
                </WebPartPages:WebPartZone>
            </div>
            <div class="clear"></div>
        </div>
        <!-- inner end -->
    </section>

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
                        <h5>
                            <asp:Literal ID="Literal1" runat="server" Text="<%$ Resources:LappiaRootFooter, SubjectAreas %>"></asp:Literal></h5>
                        <ul>
                            <li><a href="#">
                                <asp:Literal ID="Literal2" runat="server" Text="<%$ Resources:LappiaRootFooter, WellBeing %>"></asp:Literal></a></li>
                            <li><a href="#">
                                <asp:Literal ID="Literal3" runat="server" Text="<%$ Resources:LappiaRootFooter, Culture %>"></asp:Literal></a></li>
                            <li><a href="#">
                                <asp:Literal ID="Literal4" runat="server" Text="<%$ Resources:LappiaRootFooter, WellBeing %>"></asp:Literal></a></li>
                            <li><a href="#">
                                <asp:Literal ID="Literal5" runat="server" Text="<%$ Resources:LappiaRootFooter, ServiceSector %>"></asp:Literal></a></li>
                            <li><a href="#">
                                <asp:Literal ID="Literal6" runat="server" Text="<%$ Resources:LappiaRootFooter, TechnicalField %>"></asp:Literal></a></li>
                        </ul>
                    </div>
                    <div class="col-sm-3 col-md-3">
                        <h5>
                            <asp:Literal ID="Literal7" runat="server" Text="<%$ Resources:LappiaRootFooter, Studies %>"></asp:Literal></h5>
                        <ul>
                            <li><a href="#">
                                <asp:Literal ID="Literal8" runat="server" Text="<%$ Resources:LappiaRootFooter, YouthEducation %>"></asp:Literal></a></li>
                            <li><a href="#">
                                <asp:Literal ID="Literal9" runat="server" Text="<%$ Resources:LappiaRootFooter, AdultEducation %>"></asp:Literal></a></li>
                            <li><a href="#">
                                <asp:Literal ID="Literal10" runat="server" Text="<%$ Resources:LappiaRootFooter, Apprenticeship %>"></asp:Literal></a></li>
                        </ul>
                    </div>
                    <div class="col-sm-3 col-md-3">
                        <h5>
                            <asp:Literal ID="Literal11" runat="server" Text="<%$ Resources:LappiaRootFooter, Contact %>"></asp:Literal></h5>
                        <ul>
                            <li><a href="#">
                                <asp:Literal ID="Literal12" runat="server" Text="<%$ Resources:LappiaRootFooter, Locations %>"></asp:Literal></a></li>
                            <li><a href="#">
                                <asp:Literal ID="Literal13" runat="server" Text="<%$ Resources:LappiaRootFooter, Staff %>"></asp:Literal></a></li>
                            <li><a href="#">
                                <asp:Literal ID="Literal14" runat="server" Text="<%$ Resources:LappiaRootFooter, AdultEducation %>"></asp:Literal></a></li>
                            <li><a href="#">
                                <asp:Literal ID="Literal15" runat="server" Text="<%$ Resources:LappiaRootFooter, ProjectServices %>"></asp:Literal></a></li>
                            <li><a href="#">
                                <asp:Literal ID="Literal16" runat="server" Text="<%$ Resources:LappiaRootFooter, ApprenticeshipOffice %>"></asp:Literal></a></li>
                            <li><a href="#">
                                <asp:Literal ID="Literal17" runat="server" Text="<%$ Resources:LappiaRootFooter, ClientWorks %>"></asp:Literal></a></li>
                            <li><a href="#">
                                <asp:Literal ID="Literal18" runat="server" Text="<%$ Resources:LappiaRootFooter, RestaurantsAndCafes %>"></asp:Literal></a></li>
                            <li><a href="#">
                                <asp:Literal ID="Literal19" runat="server" Text="<%$ Resources:LappiaRootFooter, BillingAddress %>"></asp:Literal></a></li>
                            <li><a href="#">
                                <asp:Literal ID="Literal20" runat="server" Text="<%$ Resources:LappiaRootFooter, FederationofMunicipalities %>"></asp:Literal></a></li>
                        </ul>
                    </div>
                    <div class="col-sm-3 col-md-3">
                        <h5>
                            <asp:Literal ID="Literal21" runat="server" Text="<%$ Resources:LappiaRootFooter, Education %>"></asp:Literal></h5>
                        <ul>
                            <li><a href="#">
                                <asp:Literal ID="Literal22" runat="server" Text="<%$ Resources:LappiaRootFooter, Demonstration %>"></asp:Literal></a></li>
                            <li><a href="#">
                                <asp:Literal ID="Literal23" runat="server" Text="<%$ Resources:LappiaRootFooter, Organization %>"></asp:Literal></a></li>
                            <li><a href="#">
                                <asp:Literal ID="Literal24" runat="server" Text="<%$ Resources:LappiaRootFooter, Functions %>"></asp:Literal></a></li>
                            <li><a href="#">
                                <asp:Literal ID="Literal25" runat="server" Text="<%$ Resources:LappiaRootFooter, StrategyVvaluesKeyFigures %>"></asp:Literal></a></li>
                            <li><a href="#">
                                <asp:Literal ID="Literal26" runat="server" Text="<%$ Resources:LappiaRootFooter, GroupServices %>"></asp:Literal></a></li>
                            <li><a href="#">
                                <asp:Literal ID="Literal27" runat="server" Text="<%$ Resources:LappiaRootFooter, Decision %>"></asp:Literal></a></li>
                        </ul>
                    </div>
                </div>
            </div>
            <div class="addresslink">
                <a href="#">
                    <asp:Literal ID="Literal28" runat="server" Text="<%$ Resources:LappiaRootFooter, SiteMap %>"></asp:Literal></a> | <a href="#">
                        <asp:Literal ID="Literal29" runat="server" Text="<%$ Resources:LappiaRootFooter, AboutThisSite %>"></asp:Literal></a> | <a href="#">
                            <asp:Literal ID="Literal30" runat="server" Text="<%$ Resources:LappiaRootFooter, Feedback %>"></asp:Literal></a> | <a href="linkto:ammattiopisto@lappia.fi">ammattiopisto@lappia.fi</a> |
                <asp:Literal ID="Literal31" runat="server" Text="<%$ Resources:LappiaRootFooter, Address %>"></asp:Literal>
            </div>
    </footer>
</asp:Content>
