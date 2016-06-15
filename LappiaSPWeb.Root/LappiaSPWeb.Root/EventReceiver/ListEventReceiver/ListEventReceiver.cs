using System;
using System.Security.Permissions;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Utilities;
using Microsoft.SharePoint.Workflow;
using Microsoft.SharePoint.Taxonomy;
using Microsoft.SharePoint.Publishing.Navigation;
using System.Linq;

namespace LappiaSPWeb.Root.EventReceiver.ListEventReceiver
{
    /// <summary>
    /// List Item Events
    /// </summary>
    public class ListEventReceiver : SPItemEventReceiver
    {
        /// <summary>
        /// An item is being added.
        /// </summary>
        public override void ItemAdding(SPItemEventProperties properties)
        {
            base.ItemAdding(properties);
        }

        /// <summary>
        /// An item is being updated.
        /// </summary>
        public override void ItemUpdating(SPItemEventProperties properties)
        {
            base.ItemUpdating(properties);
        }

        /// <summary>
        /// An item is being deleted.
        /// </summary>
        public override void ItemDeleting(SPItemEventProperties properties)
        {
            base.ItemDeleting(properties);
        }

        public override void ItemAdded(SPItemEventProperties properties)
        {
            base.ItemAdded(properties);
            try
            {
                SPSecurity.RunWithElevatedPrivileges(delegate()
                {
                    SPWeb myWeb = properties.Web;

                    if (properties.ListTitle == "SectionDetails")
                    {
                        #region "Create Termstore Set For Friendly URL"

                        TaxonomySession taxonomySession = new TaxonomySession(myWeb.Site);
                        taxonomySession.UpdateCache();
                        TermStore termStore = taxonomySession.DefaultSiteCollectionTermStore;
                        Group siteCollectionGroup = termStore.GetSiteCollectionGroup(myWeb.Site, createIfMissing: true);
                        TermSet ts = siteCollectionGroup.TermSets.Where(p => p.Name.ToLower() == "lappia education").FirstOrDefault();
                        if (ts != null)//check term set is exist or not
                        {
                            NavigationTermSet navigationTermSet = NavigationTermSet.GetAsResolvedByWeb(ts, myWeb, StandardNavigationProviderNames.GlobalNavigationTaxonomyProvider);
                            navigationTermSet.IsNavigationTermSet = true;

                            NavigationTerm subterm = navigationTermSet.CreateTerm(Convert.ToString(properties.ListItem["Title"].ToString()) + ".aspx", NavigationLinkType.FriendlyUrl, Guid.NewGuid());
                            if ((uint)System.Globalization.CultureInfo.CurrentUICulture.LCID == 1033)
                            {
                                subterm.TargetUrl.Value = SPContext.Current.Web.Url + "/Pages/" + Convert.ToString(properties.ListItem["Title"].ToString()) + ".aspx";
                            }
                            else if ((uint)System.Globalization.CultureInfo.CurrentUICulture.LCID == 1035)
                            {
                                subterm.TargetUrl.Value = SPContext.Current.Web.Url + "/Pages/" + Convert.ToString(properties.ListItem["Title"].ToString()) + ".aspx";
                            }
                        }
                        termStore.CommitAll();
                        #endregion
                    }

                });
            }
            catch (Exception ex)
            {
            }
        }

    }
}