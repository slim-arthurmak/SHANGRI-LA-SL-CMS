using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;
using System.ComponentModel.DataAnnotations;

namespace ShangriLa.CMS.SL.Web.Models.Blocks
{
    [ContentType(DisplayName = "OverviewContentBlock", GUID = "A0AC3CBA-F13F-40C5-A60A-B1787CA2D9DE", Description = "")]
    [SiteImageUrl]
    public class OverviewContentBlock : HotelHomepageContentBlockData
    {
        /*
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
        */

        [Display(  Name = "Content Image",
                   Description = "3x2 ratio",
                   GroupName = SystemTabNames.Content,
                   Order = 3)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference ContentImage { get; set; }
    }
}