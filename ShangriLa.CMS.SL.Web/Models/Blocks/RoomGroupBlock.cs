using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;
using System.ComponentModel.DataAnnotations;

namespace ShangriLa.CMS.SL.Web.Models.Blocks
{
    [ContentType(DisplayName = "RoomGroupBlock", GUID = "a999e56e-ff7f-4848-bd16-5ce40bcad79e", Description = "")]
    public class RoomGroupBlock : BlockData
    {
        [CultureSpecific]
        [Display(
            Name = "RoomGroupName",
            Description = "Room Group Name : Garden Wing, Al Waha",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual string RoomGroupName { get; set; }


        [CultureSpecific]
        [Display(
           Name = "Teaser",
           Description = "Teaser (Homepage)",
           GroupName = SystemTabNames.Content,
           Order = 2)]
        [UIHint(UIHint.Textarea)]
        public virtual string Teaser { get; set; }

        [CultureSpecific]
        [Display(
          Name = "Teaser2",
          Description = "Teaser2 (Expore)",
          GroupName = SystemTabNames.Content,
          Order = 2)]
        [UIHint(UIHint.Textarea)]
        public virtual string Teaser2 {
            get
            {
                var propertyValue = this["Teaser"] as string;

                // Return image description with fall back to the heading if no description has been specified
                return string.IsNullOrWhiteSpace(propertyValue) ? Teaser : propertyValue;
            }

            set { this["Teaser"] = value; }
        }

        [CultureSpecific]
        [Display(
            Name = "Short Description",
            Description = "Short Description",
            GroupName = SystemTabNames.Content,
            Order = 3)]
        [UIHint(UIHint.Textarea)]
        public virtual string ShortDescription { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Long Description",
            Description = "Long Description",
            GroupName = SystemTabNames.Content,
            Order = 4)]
        [UIHint(UIHint.Textarea)]
        public virtual string LongDescription { get; set; }

        [Display(Name = "Header Image",
                  Description = "3x2 ratio",
                  GroupName = SystemTabNames.Content,
                  Order = 5)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference HeaderImage { get; set; }

        [AllowedTypes(new[] { typeof(RoomGroupBlock)})]
        [Display(
                  Name = "Room Group Content Area",
                  Description = "Room Group Blocks",
                  GroupName = SystemTabNames.Content,
                  Order = 10)]
        public virtual ContentArea RoomGroupContentArea { get; set; }

    }
}