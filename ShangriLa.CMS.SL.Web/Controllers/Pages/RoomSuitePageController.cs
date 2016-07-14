using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EPiServer;
using EPiServer.Core;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;

using ShangriLa.CMS.SL.Web.Models.Pages;
using ShangriLa.CMS.SL.Web.Models.ViewModels;

namespace ShangriLa.CMS.SL.Web.Controllers.Pages
{
    public class RoomSuitePageController : PageControllerBase<RoomSuitePage>
    {
        public ActionResult Index(RoomSuitePage currentPage)
        {
            /* Implementation of action. You can create your own view model class that you pass to the view or
             * you can pass the page type for simpler templates */
            DefaultPageViewModel<RoomSuitePage> model = new DefaultPageViewModel<RoomSuitePage>(currentPage);
            return View(model);
        }
    }
}