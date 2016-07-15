using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using EPiServer.DataAnnotations;
using EPiServer.Web;

using ShangriLa.CMS.SL.Web.Models.Blocks;

namespace ShangriLa.CMS.SL.Web.Models.Pages
{
    [ContentType(
        DisplayName = "StartPage", 
        GUID = "8C31185E-E32F-44E9-B95D-47FC9A02799A",
        Description = "Shangri-La Start Page")]
    [SiteImageUrl]
    [AvailableContentTypes(
        Availability.Specific,
        Include = new[] { typeof(HotelLandingPage), typeof(DestinationPage) })]
    /*
    [AvailableContentTypes(
        Availability.Specific,
        Include = new[] { typeof(ContainerPage), typeof(ProductPage), typeof(StandardPage), typeof(SearchPage), typeof(LandingPage), typeof(ContentFolder), typeof(FindPage) }, // Pages we can create under the start page...
        ExcludeOn = new[] { typeof(ProductPage), typeof(StandardPage), typeof(SearchPage), typeof(LandingPage) })] // ...and underneath those we can't create additional start pages
    */
    public class StartPage : SitePageData
    {
        [Display(
            GroupName = SystemTabNames.Content,
            Order = 320)]
        [CultureSpecific]
        public virtual ContentArea MainContentArea { get; set; }

        [Display(GroupName = Global.GroupNames.SiteSettings, Order = 300)]
        public virtual LinkItemCollection ProductPageLinks { get; set; }

        [Display(GroupName = Global.GroupNames.SiteSettings, Order = 350)]
        public virtual LinkItemCollection CompanyInformationPageLinks { get; set; }

        [Display(GroupName = Global.GroupNames.SiteSettings, Order = 400)]
        public virtual LinkItemCollection NewsPageLinks { get; set; }

        [Display(GroupName = Global.GroupNames.SiteSettings, Order = 450)]
        public virtual LinkItemCollection CustomerZonePageLinks { get; set; }

        [Display(GroupName = Global.GroupNames.SiteSettings)]
        public virtual PageReference GlobalNewsPageLink { get; set; }

        [Display(GroupName = Global.GroupNames.SiteSettings)]
        public virtual PageReference ContactsPageLink { get; set; }

        [Display(GroupName = Global.GroupNames.SiteSettings)]
        public virtual PageReference SearchPageLink { get; set; }

        [Display(GroupName = Global.GroupNames.SiteSettings)]
        public virtual PageReference NewsPageLink { get; set; }

        [Display(GroupName = Global.GroupNames.SiteSettings)]
        public virtual PageReference BlogPageLink { get; set; }

        [Display(GroupName = Global.GroupNames.SiteSettings, Name = "Employees Root Page", Order = 600)]
        public virtual ContentReference EmployeeContainerPageLink { get; set; }

        [Display(GroupName = Global.GroupNames.SiteSettings, Name = "Location Root Page", Order = 610)]
        public virtual PageReference EmployeeLocationPageLink { get; set; }

        [Display(GroupName = Global.GroupNames.SiteSettings, Name = "Expertise Root Page", Order = 620)]
        public virtual ContentReference EmployeeExpertiseLink { get; set; }

        [Display(GroupName = Global.GroupNames.SiteSettings)]
        public virtual SiteLogotypeBlock SiteLogotype { get; set; }

        [Display(GroupName = Global.GroupNames.SiteSettings)]
        [UIHint(UIHint.BlockFolder)]
        public virtual ContentReference CountryBlockFolderReference { get; set; }

        [Display(GroupName = Global.GroupNames.SiteSettings)]
        [UIHint(UIHint.BlockFolder)]
        [AllowedTypes(typeof(ContentFolder))]
        public virtual ContentReference CityBlockFolderReference { get; set; }



    }
}