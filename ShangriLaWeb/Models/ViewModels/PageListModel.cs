using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using EPiServer.Core;

using ShangriLaWeb.Models.Pages;
using ShangriLaWeb.Models.Blocks;

namespace ShangriLaWeb.Models.ViewModels
{
    public class PageListModel
    {
        public PageListModel(PageListBlock block)
        {
            Heading = block.Heading;
            ShowIntroduction = block.IncludeIntroduction;
            ShowPublishDate = block.IncludePublishDate;
        }
        public string Heading { get; set; }
        public IEnumerable<PageData> Pages { get; set; }
        public bool ShowIntroduction { get; set; }
        public bool ShowPublishDate { get; set; }
    }
}