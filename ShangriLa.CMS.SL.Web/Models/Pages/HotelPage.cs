using EPiServer;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.ServiceLocation;
using EPiServer.SpecializedProperties;
using EPiServer.Web;

using ShangriLa.CMS.SL.Web.Business.Extensions.EditorDescriptor;
using ShangriLa.CMS.SL.Web.Helpers;
using ShangriLa.CMS.SL.Web.Models.Blocks;

using System;
using System.ComponentModel.DataAnnotations;

namespace ShangriLa.CMS.SL.Web.Models.Pages
{
    [ContentType(GroupName = "Property Pages", DisplayName = "HotelPage", GUID = "19EA638C-376D-4216-9353-9E34D4C07B05", Description = "Hotel Page")]
    public class HotelPage : SitePageData
    {
        /*
        [CultureSpecific]
        [Display(
            Name = "Main body",
            Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual XhtmlString MainBody { get; set; }


        public virtual ContentReference DestinationLink { get; set; }

        // BOOT CAMP: Custom UIHint
        [UIHint("hotel-type-select")]
        [Display(
            Name = "Hotel Type",
            GroupName = SystemTabNames.Content,
            Order = 50)]
        public virtual string HotelType { get; set; }
        */

        [Display(
                  Name = "Hotel Block",
                  Description = "Hotel Block",
                  GroupName = Global.GroupNames.HotelSettings,
                  Order = 1)]
        [AllowedTypes(typeof(HotelBlock))]
        [UIHint(UIHint.Block)]
        [Required]
        public virtual ContentReference HotelBlock { get; set; }

        [Display(Name = "Hero Banner Block",
            GroupName = SystemTabNames.Content,
            Order = 5)]
        //[CultureSpecific]
        //[MaxItemCount(1)]
        //[AllowedTypes(typeof(MainCarouselBlock))]
        public virtual HeroBannerBlock HeroBanner { get; set; }

        [AllowedTypes(new[] { typeof(OverviewContentBlock), typeof(RoomContentBlock) })]
        [Display(
                  Name = "Section Content Area",
                  Description = "Hotel Content Blocks",
                  GroupName = SystemTabNames.Content,
                  Order = 110)]
        public virtual ContentArea SectionContentArea { get; set; }


        public override void SetDefaultValues(ContentType contentType)
        {
            base.SetDefaultValues(contentType);
            //Set up your defaults here  

            if (!ContentReference.IsNullOrEmpty(this.HotelBlock))
            {
                //HeroBanner.Title = this.HotelBlock. as HotelBlock();
                var contentRepository = ServiceLocator.Current.GetInstance<IContentRepository>();

                HotelBlock hotelBlock = contentRepository.Get<HotelBlock>(this.HotelBlock);
                HeroBanner.Title = hotelBlock.HotelShortName;
            }
                
        }
    }
}