using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace ShangriLa.CMS.SL.Web.Models.Pages
{
    /// <remarks>
    /// A content type should always have a GUID defined!
    /// The GUID has been commented out in this file for training purposes, so that it is possible to copy a content type 
    /// from the solution files into the AlloyTraining project without getting a conflict, should the content type already exist there.
    /// </remarks>
    [ContentType(DisplayName = "StandardPage", GUID = "8C34A6BD-45A0-4D0F-BD2F-AF6C5AC6DE25", Description = "Shangri-La Standard Page")] //, GUID = "4960c063-16fc-4e45-ba0b-7e3fdcf88006"
    public class StandardPage : SitePageData
    {
        [CultureSpecific]
        [Display(
            Name = "Main body",
            Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
            GroupName = SystemTabNames.Content,
            Order = 310)]
        public virtual XhtmlString MainBody { get; set; }
    }
}