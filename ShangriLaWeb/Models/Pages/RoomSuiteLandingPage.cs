using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace ShangriLaWeb.Models.Pages
{
    [ContentType(DisplayName = "RoomSuiteLandingPage", GUID = "dc147606-779c-4c1b-af56-4f00eb131588", Description = "")]
    [AvailableContentTypes(Include = new[] { typeof(RoomSuitePage), typeof(RoomSuiteListingPage) })]
    public class RoomSuiteLandingPage : PageData
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