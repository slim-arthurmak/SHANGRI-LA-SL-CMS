using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;

namespace ShangriLa.CMS.SL.Web.Models.Blocks
{
    [ContentType(DisplayName = "HeroBannerBlock", GUID = "b1beba54-eb9c-4c59-bd33-74038ece1961", Description = "")]
    public class HeroBannerBlock : BlockData
    {
        [Display(
                    Name = "Hero Image (Desktop)",
                    Description = "* Required. Must be 1600px width, 750px height",
                    GroupName = SystemTabNames.Content,
                    Order = 1)]
        [UIHint(UIHint.Image)]
        //[RequiredImageSize(Width = 1300, Height = 500, ErrorMessage = "Carousel image must be of resolution 1300x500")]
        //[Required(ErrorMessage = "Hero Image (Desktop) is required")]
        public virtual ContentReference DesktopImage { get; set; }

        [Display(
                    Name = "Hero Image (Tablet)",
                    Description = "* Required. Must be 1140px width, 335px height",
                    GroupName = SystemTabNames.Content,
                    Order = 2)]
        [UIHint(UIHint.Image)]
        //[RequiredImageSize(Width = 1300, Height = 500, ErrorMessage = "Carousel image must be of resolution 1300x500")]
        //[Required(ErrorMessage = "Hero Image (Tablet) is required")]
        public virtual ContentReference TabletImage { get; set; }

        [Display(
                    Name = "Hero Image (Mobile)",
                    Description = "* Required. Must be 958px width, 449px height",
                    GroupName = SystemTabNames.Content,
                    Order = 3)]
        [UIHint(UIHint.Image)]
        //[RequiredImageSize(Width = 1300, Height = 500, ErrorMessage = "Carousel image must be of resolution 1300x500")]
        //[Required(ErrorMessage = "Hero Image (Mobile) is required")]
        public virtual ContentReference MobileImage { get; set; }

        //[Required(ErrorMessage = "Alternate text is required.")]
        [Display(Order = 4, Name = "Alternate Text", Description = "* Required")]
        public virtual string AlternateText { get; set; }

        //[Required(ErrorMessage = "Alternate text is required.")]
        [Display(Order = 5, Name = "Title", Description = "Title")]
        public virtual string Title { get; set; }

        //[Required(ErrorMessage = "Alternate text is required.")]
        [Display(Order = 6, Name = "Introduction", Description = "Introduction")]
        [UIHint(UIHint.Textarea)]
        public virtual string ShortDescription { get; set; }

        //Sets the default property values
        public override void SetDefaultValues(ContentType contentType)
        {
            base.SetDefaultValues(contentType);
            //Set up your defaults here  
        }
    }
}