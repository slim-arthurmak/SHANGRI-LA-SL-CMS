using System.ComponentModel.DataAnnotations;
using EPiServer;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace ShangriLaWeb.Models.Blocks
{
    [ContentType(DisplayName = "HotelModuleBlock", GUID = "A0AC3CBA-F13F-40C5-A60A-B1787CA2D9DE", Description = "")]
    public class HotelModuleBlock : SiteBlockData
    {

        [CultureSpecific]
        [Display(
            Name = "Tagline",
            Description = "Tagline",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual string Tagline { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Short Description",
            Description = "Short Description",
            GroupName = SystemTabNames.Content,
            Order = 2)]
        public virtual string ShortDescription { get; set; }

        [Display(
            Name = "View All CTA",
            Description = "View All CTA",
            GroupName = SystemTabNames.Content,
            Order = 2)]
        public virtual ButtonBlock ViewAllCTA { get; set; }

    }
}