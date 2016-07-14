using EPiServer.Core;
using ShangriLa.CMS.SL.Web.Models.Pages;

namespace ShangriLa.CMS.SL.Web.Models.ViewModels
{
    public interface IPageViewModel<out T> where T : SitePageData
    {
        T CurrentPage { get; }
        LayoutModel Layout { get; set; }
        IContent Section { get; set; }
    }
}