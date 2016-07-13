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


        [Display(Name = "Address", Order = 6)]
        public virtual string Address { get; set; }

        [Display(Name = "City", Order = 5)]
        public virtual ContentReference City { get; set; }

        [Display(Name = "Telephone", GroupName = "HotelContact", Description = "", Order = 1)]
        public virtual string Phone { get; set; }

        [Display( Name = "Fax", GroupName = "HotelContact", Description = "", Order = 2)]
        public virtual string Fax { get; set; }

        [Display(Name = "Email", GroupName = "HotelContact", Description = "", Order = 3)]
        public virtual string Email { get; set; }

        [Display(Name = "Check-in Time", Order = 10)]
        public virtual string CheckInTime { get; set; }

        [Display(Name = "Check-out Time", Order = 11)]
        public virtual string CheckOutTime { get; set; }

        [Display(Name = "Payment Options", Order = 12)]
        public virtual ContentArea PaymentOptions { get; set; }

        [Display(Name = "Facebook", GroupName = "Social Media", Description = "", Order = 1)]
        public virtual string Facebook { get; set; }

        [Display(Name = "Twitter", GroupName = "Social Media", Description = "", Order = 2)]
        public virtual string Twitter { get; set; }

        [Display(Name = "Youtube ", GroupName = "Social Media", Description = "", Order = 3)]
        public virtual string Youtube { get; set; }

        [Display(Name = "GooglePlus  ", GroupName = "Social Media", Description = "", Order = 4)]
        public virtual string GooglePlus { get; set; }

        [Display(Name = "Youku", GroupName = "Social Media", Description = "", Order = 5)]
        public virtual string Youku { get; set; }

        [Display(Name = "Weibo", GroupName = "Social Media", Description = "", Order = 5)]
        public virtual string Weibo { get; set; }

    }
}