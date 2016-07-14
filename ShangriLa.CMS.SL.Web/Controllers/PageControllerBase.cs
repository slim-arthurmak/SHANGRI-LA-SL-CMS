using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.Security;
using EPiServer;
using EPiServer.Core;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;

using ShangriLa.CMS.SL.Web.Models.Pages;

namespace ShangriLa.CMS.SL.Web.Controllers
{
    public abstract class PageControllerBase<T> : PageController<T> where T : SitePageData
    {
        // Providing a logout action for all EPiServer Page Controllers
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index");
        }

    }
}