using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EPiServer;
using EPiServer.Core;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;
using EPiServer.ServiceLocation;

using ShangriLa.CMS.SL.Web.Models.Pages;
using ShangriLa.CMS.SL.Web.Models.ViewModels;
using ShangriLa.CMS.SL.Web.Models.Blocks;


namespace ShangriLa.CMS.SL.Web.Controllers.Pages
{
    public class HotelPageController : PageControllerBase<HotelPage>
    {
        public ActionResult Index(HotelPage currentPage)
        {
            /* Implementation of action. You can create your own view model class that you pass to the view or
             * you can pass the page type for simpler templates */
            PropertyPageViewModel model = new PropertyPageViewModel(currentPage);

            return View(model);
        }
    }
}