using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using EPiServer.Core;

using ShangriLaWeb.Models.Pages;
using ShangriLaWeb.Business;



namespace ShangriLaWeb.Models.ViewModels
{
    public class DefaultPageViewModel<T> : IPageViewModel<T> where T : SitePageData
    {
        public DefaultPageViewModel(T currentPage)
        {
            CurrentPage = currentPage;
            Section = ContentExtensions.GetSection(currentPage.ContentLink);
        }

        public T CurrentPage { get; private set; }
        public LayoutModel Layout { get; set; }
        public IContent Section { get; set; }
    }
}