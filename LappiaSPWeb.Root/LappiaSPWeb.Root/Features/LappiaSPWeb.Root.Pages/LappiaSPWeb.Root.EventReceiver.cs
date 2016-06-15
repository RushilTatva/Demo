using System;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Taxonomy;
using System.Linq;
using Microsoft.SharePoint.Publishing.Navigation;

namespace LappiaSPWeb.Root.Features.LappiaSPWeb.Root.Pages
{
    /// <summary>
    /// This class handles events raised during feature activation, deactivation, installation, uninstallation, and upgrade.
    /// </summary>
    /// <remarks>
    /// The GUID attached to this class may be used during packaging and should not be modified.
    /// </remarks>

    [Guid("dd94c20f-1284-4ee7-9e8c-24a5cb45a19a")]
    public class LappiaSPWebRootEventReceiver : SPFeatureReceiver
    {
        // Uncomment the method below to handle the event raised after a feature has been activated.

        public override void FeatureActivated(SPFeatureReceiverProperties properties)
        {
            //try
            //{
            //    SPSecurity.RunWithElevatedPrivileges(delegate()
            //    {

            //        SPWeb web;
            //        if (properties.Feature.Parent is SPWeb)
            //        {
            //            web = (SPWeb)properties.Feature.Parent;
            //        }
            //        else
            //        {
            //            web = ((SPSite)properties.Feature.Parent).RootWeb;
            //        }

            //        web.AllowUnsafeUpdates = true;

            //        #region "Create Termstore Set For Friendly URL"

            //        TaxonomySession taxonomySession = new TaxonomySession(web.Site);
            //        taxonomySession.UpdateCache();
            //        TermStore termStore = taxonomySession.DefaultSiteCollectionTermStore;

            //        // Create a TermSet object in a default site collection term group.
            //        Group siteCollectionGroup = termStore.GetSiteCollectionGroup(web.Site, createIfMissing: true);
            //        TermSet ts = siteCollectionGroup.TermSets.Where(p => p.Name.ToLower() == "lappia education").FirstOrDefault();
            //        if (ts == null)//check term set is exist or not
            //        {
            //            //NavigationTermSet navigationTermSet = NavigationTermSet.GetAsResolvedByWeb(ts, web, StandardNavigationProviderNames.GlobalNavigationTaxonomyProvider);
            //            //navigationTermSet.IsNavigationTermSet = true;

            //            TermSet termSet = siteCollectionGroup.CreateTermSet("Lappia Education", Guid.NewGuid(), lcid: 1033);
            //            // TermSet termSet = siteCollectionGroup.TermSets[0];
            //            if (termSet.Name.Trim() == "Lappia Education")
            //            {
            //                SPList oList = web.Lists["Pages"];
            //                SPQuery query = new SPQuery();
            //                query.Query = "";
            //                SPListItemCollection objSectionFiles = oList.GetItems(query);
            //                if (objSectionFiles != null && objSectionFiles.Count > 0)
            //                {
            //                    NavigationTermSet navigationTermSet = NavigationTermSet.GetAsResolvedByWeb(termSet, web, StandardNavigationProviderNames.GlobalNavigationTaxonomyProvider);
            //                    navigationTermSet.IsNavigationTermSet = true;
            //                    foreach (SPListItem item in objSectionFiles)
            //                    {
            //                        NavigationTerm subterm = navigationTermSet.CreateTerm(item.Name.Replace("-", " ").Replace(".aspx", string.Empty), NavigationLinkType.FriendlyUrl, Guid.NewGuid());
            //                        if ((uint)System.Globalization.CultureInfo.CurrentUICulture.LCID == 1033)
            //                        {
            //                            subterm.TargetUrl.Value = "/sites/en-US/Pages/" + item.Name.Replace(".aspx", string.Empty) + ".aspx";
            //                        }
            //                        else if ((uint)System.Globalization.CultureInfo.CurrentUICulture.LCID == 1035)
            //                        {
            //                            subterm.TargetUrl.Value = "/sites/fi-fi/Pages/" + item.Name.Replace(".aspx", string.Empty) + ".aspx";
            //                        }
            //                    }
            //                }


            //                //"GlobalNavigationTaxonomyProvider"
            //                // Obtain navigation term set.
            //                //NavigationTermSet navigationTermSet = NavigationTermSet.GetAsResolvedByWeb(termSet, web, StandardNavigationProviderNames.GlobalNavigationTaxonomyProvider);
            //                //navigationTermSet.IsNavigationTermSet = true;

            //                //// Create Rate Request Term
            //                //NavigationTerm termRateRequest = navigationTermSet.CreateTerm("Rate Request", NavigationLinkType.FriendlyUrl, Guid.NewGuid());
            //                //termRateRequest.TargetUrl.Value = "/Pages/Rate-Request.aspx";

            //                //// Create Load Tracking Term
            //                //NavigationTerm termLoadTracking = navigationTermSet.CreateTerm("Tracking & Login", NavigationLinkType.FriendlyUrl, Guid.NewGuid());
            //                //termLoadTracking.TargetUrl.Value = "/Pages/Tracking-Login.aspx";

            //                //// Create Home Term
            //                //NavigationTerm termHome = navigationTermSet.CreateTerm("Home", NavigationLinkType.FriendlyUrl, Guid.NewGuid());
            //                //termHome.TargetUrl.Value = "/pages/HomeLandingPage.aspx";


            //                // Save all changes to the term store.
            //                termStore.CommitAll();

            //                WebNavigationSettings settings = new WebNavigationSettings(web);
            //                settings.GlobalNavigation.Source = StandardNavigationSource.TaxonomyProvider;
            //                settings.GlobalNavigation.TermStoreId = termStore.Id;
            //                settings.GlobalNavigation.TermSetId = termSet.Id;
            //                settings.AddNewPagesToNavigation = true;
            //                settings.CreateFriendlyUrlsForNewPages = true;
            //                settings.Update();
            //            }
            //        }
            //        #endregion

            //        web.AllowUnsafeUpdates = false;

            //    });
            //}
            //catch (Exception ex)
            //{
            //    //utility.WriteMessage(ex.ToString());
            //}
        }


        // Uncomment the method below to handle the event raised before a feature is deactivated.

        //public override void FeatureDeactivating(SPFeatureReceiverProperties properties)
        //{
        //}


        // Uncomment the method below to handle the event raised after a feature has been installed.

        //public override void FeatureInstalled(SPFeatureReceiverProperties properties)
        //{
        //}


        // Uncomment the method below to handle the event raised before a feature is uninstalled.

        //public override void FeatureUninstalling(SPFeatureReceiverProperties properties)
        //{
        //}

        // Uncomment the method below to handle the event raised when a feature is upgrading.

        //public override void FeatureUpgrading(SPFeatureReceiverProperties properties, string upgradeActionName, System.Collections.Generic.IDictionary<string, string> parameters)
        //{
        //}
    }
}
