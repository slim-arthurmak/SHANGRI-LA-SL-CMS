﻿using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

using System.ComponentModel;
using EPiServer.Filters;



namespace ShangriLa.CMS.SL.Web.Models.Blocks
{
    [ContentType(DisplayName = "PageListBlock", GUID = "d649dff2-a8d1-4b52-9722-aa42939536d2", Description = "")]
    public class PageListBlock : SiteBlockData
    {
        [Display(
            GroupName = SystemTabNames.Content,
            Order = 1)]
        [CultureSpecific]
        public virtual string Heading { get; set; }

        [Display(
            GroupName = SystemTabNames.Content,
            Order = 2)]
        [DefaultValue(false)]
        public virtual bool IncludePublishDate { get; set; }

        /// <summary>
        /// Gets or sets whether a page introduction/description should be included in the list
        /// </summary>
        [Display(
            GroupName = SystemTabNames.Content,
            Order = 3)]
        [DefaultValue(true)]
        public virtual bool IncludeIntroduction { get; set; }

        [Display(
            GroupName = SystemTabNames.Content,
            Order = 4)]
        [DefaultValue(3)]
        [Required]
        public virtual int Count { get; set; }

        [Display(
            GroupName = SystemTabNames.Content,
            Order = 4)]
        [DefaultValue(FilterSortOrder.PublishedDescending)]
        [UIHint("SortOrder")]
        [BackingType(typeof(PropertyNumber))]
        public virtual FilterSortOrder SortOrder { get; set; }

        [Display(
            GroupName = SystemTabNames.Content,
            Order = 5)]
        [Required]
        public virtual PageReference Root { get; set; }

        [Display(
            GroupName = SystemTabNames.Content,
            Order = 6)]
        public virtual PageType PageTypeFilter { get; set; }

        [Display(
            GroupName = SystemTabNames.Content,
            Order = 7)]
        public virtual CategoryList CategoryFilter { get; set; }

        [Display(
            GroupName = SystemTabNames.Content,
            Order = 8)]
        public virtual bool Recursive { get; set; }

        #region IInitializableContent

        /// <summary>
        /// Sets the default property values on the content data.
        /// </summary>
        /// <param name="contentType">Type of the content.</param>
        public override void SetDefaultValues(ContentType contentType)
        {
            base.SetDefaultValues(contentType);

            Count = 3;
            IncludeIntroduction = true;
            IncludePublishDate = false;
            SortOrder = FilterSortOrder.PublishedDescending;
        }

        #endregion
    }
}