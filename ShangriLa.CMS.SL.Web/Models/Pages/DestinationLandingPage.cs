using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace ShangriLa.CMS.SL.Web.Models.Pages
{
    [ContentType(DisplayName = "DestinationLandingPage", GUID = "88B84F51-8659-403E-8A22-733FCF9B9EAB", Description = "Destination Landing Page")]
    [AvailableContentTypes(Include = new[] { typeof(DestinationPage) })]
    public class DestinationLandingPage : SitePageData
    {
        
    }
}