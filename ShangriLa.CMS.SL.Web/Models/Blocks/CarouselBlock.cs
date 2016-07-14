using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using ShangriLa.CMS.SL.Web.Models.Blocks;
using ShangriLa.CMS.SL.Web.Models;

namespace EPiServer.Templates.Blog.Mvc.Models.Blocks
{
    /// </summary>
    [SiteContentType(
        GroupName = "Specialized",
        GUID = "532165C2-EBE6-43ef-B329-A24EA8C37E2A", DisplayName = "Slide Show Block", Description = "Slide Show with items of type item for slide show")]
    [SiteImageUrl]
    public class CarouselBlock : SiteBlockData
    {

        [Display(
            GroupName = SystemTabNames.Content,
            Order = 320)]
        [AllowedTypes(new[] { typeof(CarouselItemBlock)})]
        public virtual ContentArea MainContentArea { get; set; }

    }
}