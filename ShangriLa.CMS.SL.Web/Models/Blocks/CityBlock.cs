using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

using EPiServer.Shell.ObjectEditing;
using ShangriLa.CMS.SL.Web.Business.Extensions.EditorDescriptors;

namespace ShangriLa.CMS.SL.Web.Models.Blocks
{
    [ContentType(DisplayName = "CityBlock", GUID = "e5bec282-abd7-4778-8123-0483da960217", Description = "")]
    public class CityBlock : SiteBlockData
    {
        [CultureSpecific]
        [Display(
                   Name = "City Name",
                   Description = "",
                   GroupName = SystemTabNames.Content,
                   Order = 1)]
        public virtual string CityName { get; set; }

        [Display(
                   Name = "City Code",
                   Description = "",
                   GroupName = SystemTabNames.Content,
                   Order = 2)]
        public virtual string CityCode { get; set; }

        [Display(
                   Name = "State / Province",
                   Description = "",
                   GroupName = SystemTabNames.Content,
                   Order = 3)]
        public virtual string StateProvince { get; set; }

        [Display(
                   Name = "Country",
                   Description = "",
                   GroupName = SystemTabNames.Content,
                   Order = 4)]
        [SelectOne(SelectionFactoryType = typeof(CountryBlockSelectionFactory))]
        public virtual ContentReference Country { get; set; }
    }
}