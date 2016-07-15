using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace ShangriLa.CMS.SL.Web.Models.Pages
{
    [ContentType(GroupName = "Property Pages", DisplayName = "RoomSuiteListingPage", GUID = "c0b9598d-4534-4d54-98ff-0a59390cceec", Description = "")]
    [AvailableContentTypes(Include = new[] { typeof(RoomSuitePage) })]
    public class RoomSuiteListingPage : SitePageData
    {
        /*
                [CultureSpecific]
                [Display(
                    Name = "Main body",
                    Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
                    GroupName = SystemTabNames.Content,
                    Order = 1)]
                public virtual XhtmlString MainBody { get; set; }
         */
    }
}