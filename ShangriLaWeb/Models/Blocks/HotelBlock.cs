using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace ShangriLaWeb.Models.Blocks
{
    [ContentType(DisplayName = "HotelBlock", GUID = "4707c0e7-87b0-4f3b-b18e-b57bfdea2815", Description = "")]
    public class HotelBlock : SiteBlockData
    {
        [Required(ErrorMessage = "Hotel Code is required.")]
        [Display(Name = "Hotel Code", Description = "* Required", Prompt = "Enter 3 character code", GroupName = SystemTabNames.Content, Order = 1)]
        public virtual string HotelCode { get; set; }

        [CultureSpecific]
        [Required(ErrorMessage = "Hotel Full Name is required.")]
        [Display(Name = "Hotel Full Name", Description = "* Required", GroupName = SystemTabNames.Content, Order = 2)]
        public virtual string HotelName { get; set; }

        [CultureSpecific]
        [Display(Name = "Hotel Short Name", Description = "", GroupName = SystemTabNames.Content, Order = 3)]
        public virtual string HotelShortName { get; set; }

        [CultureSpecific]
        [Display(Name = "Hotel Url Name", Description = "", GroupName = SystemTabNames.Content, Order = 1)]
        public virtual string HotelUrlName { get; set; }


        [Display(Name = "Latitude", Order = 4)]
        public virtual string Latitude { get; set; }

        [Display(Name = "Longitude", Order = 5)]
        public virtual string Longitude { get; set; }

    }
}