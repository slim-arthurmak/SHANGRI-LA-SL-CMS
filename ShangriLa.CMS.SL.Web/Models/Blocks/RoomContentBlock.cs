using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace ShangriLa.CMS.SL.Web.Models.Blocks
{
    [ContentType(DisplayName = "RoomContentBlock", GUID = "7888b2ca-2732-49a7-8b6c-8c4e4085b254", Description = "")]
    [SiteImageUrl]
    public class RoomContentBlock : HotelHomepageContentBlockData
    {
        /*
        [CultureSpecific]
        [Display(
            Name = "Name",
            Description = "Name field's description",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual string Name { get; set; }
         */

        [CultureSpecific]
        [Display(
           Name = "Name",
           Description = "Name field's description",
           GroupName = SystemTabNames.Content,
           Order = 1)]
        public virtual string Name { get; set; }
    }
}