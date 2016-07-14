using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;


namespace ShangriLa.CMS.SL.Web.Models.Blocks
{
    [ContentType(DisplayName = "HotelHomepageContentBlockData", GUID = "906e138f-31d9-4649-947a-5f340e97a7b7", Description = "")]
    [SiteImageUrl]
    public class HotelHomepageContentBlockData : BlockData
    {
        [CultureSpecific]
        [Display(
            Name = "Title",
            Description = "Title",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual string Title { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Short Description",
            Description = "Short Description",
            GroupName = SystemTabNames.Content,
            Order = 2)]
        [UIHint(UIHint.Textarea)]
        public virtual string ShortDescription { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Long Description",
            Description = "Long Description",
            GroupName = SystemTabNames.Content,
            Order = 3)]
        [UIHint(UIHint.Textarea)]
        public virtual string LongDescription { get; set; }

        [Display(
            Name = "Block CTA",
            Description = "Block CTA",
            GroupName = SystemTabNames.Content,
            Order = 4)]
        public virtual ButtonBlock BlockCTA { get; set; }
    }
}