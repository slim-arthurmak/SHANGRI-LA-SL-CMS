using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace ShangriLa.CMS.SL.Web.Models.Pages
{
    [ContentType(GroupName = "Global Landing Pages", DisplayName = "DestinationPage", GUID = "BFFFF5F7-6029-452B-8E66-87747EE8EABC", Description = "Destination Page")]
    public class DestinationPage : SitePageData
    {
        
    }
}