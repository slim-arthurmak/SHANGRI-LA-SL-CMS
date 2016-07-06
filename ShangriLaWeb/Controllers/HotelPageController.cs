using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EPiServer;
using EPiServer.Core;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;
using EPiServer.ServiceLocation;

using ShangriLaWeb.Models.Pages;
using ShangriLaWeb.Models.ViewModels;
using ShangriLaWeb.Models.Blocks;


namespace ShangriLaWeb.Controllers
{
    public class HotelPageController : PageControllerBase<HotelPage>
    {
        public ActionResult Index(HotelPage currentPage)
        {
            /* Implementation of action. You can create your own view model class that you pass to the view or
             * you can pass the page type for simpler templates */
            DefaultPageViewModel<HotelPage> model = new DefaultPageViewModel<HotelPage>(currentPage);
            return View(model);
        }
    }
}