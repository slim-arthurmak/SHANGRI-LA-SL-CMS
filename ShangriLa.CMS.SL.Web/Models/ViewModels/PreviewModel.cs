using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using EPiServer.Core;
using ShangriLa.CMS.SL.Web.Models.Pages;

namespace ShangriLa.CMS.SL.Web.Models.ViewModels
{
    public class PreviewModel : PageViewModel<SitePageData>
    {
        public PreviewModel(SitePageData currentPage, IContent previewContent)
           : base(currentPage)
        {
            PreviewContent = previewContent;
            Areas = new List<PreviewArea>();
        }

        public IContent PreviewContent { get; set; }
        public List<PreviewArea> Areas { get; set; }

        public class PreviewArea
        {
            public bool Supported { get; set; }
            public string AreaName { get; set; }
            public string AreaTag { get; set; }
            public ContentArea ContentArea { get; set; }
        }
    }
}