using System.ComponentModel.DataAnnotations;
using EPiServer;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace ShangriLaWeb.Models.Blocks
{
    [ContentType(DisplayName = "RoomModuleBlock", GUID = "572C5B69-D311-4D77-8532-E2A12941BD8A", Description = "RoomModuleBlock")]
    public class RoomModuleBlock : SiteBlockData
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