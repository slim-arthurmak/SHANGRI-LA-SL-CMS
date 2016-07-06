using EPiServer.Core;
using ShangriLaWeb.Models.Pages;

namespace ShangriLaWeb.Models.ViewModels
{
    public interface IPageViewModel<out T> where T : SitePageData
    {
        T CurrentPage { get; }
        LayoutModel Layout { get; set; }
        IContent Section { get; set; }
    }
}