using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace ShangriLa.CMS.SL.Web.Models.Blocks
{
    [ContentType(DisplayName = "HotelModuleBlock", GUID = "ED7954A0-6ADA-49DB-ABBA-B51B04D76EE5", Description = "")]
    public class HotelHightlightsBlock : SiteBlockData
    {

        [CultureSpecific]
        [Required(AllowEmptyStrings = false)]
        [Display(
            Name = "Title",
            Description = "Title",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual string Title { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Subtitle",
            Description = "Subtitle",
            GroupName = SystemTabNames.Content,
            Order = 2)]
        public virtual string Subtitle { get; set; }

    }
}