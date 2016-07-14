using System.Linq;
using System.Web.Mvc;

namespace ShangriLa.CMS.SL.Web.Business.Rendering
{
    /// <summary>
    /// Extends the Razor view engine to include the folders ~/Views/Shared/Blocks/ and ~/Views/Shared/PagePartials/
    /// when looking for partial views.
    /// </summary>
    public class SiteViewEngine : RazorViewEngine
    {
        private static readonly string[] AdditionalPartialViewFormats = new[] 
            { 
                TemplateCoordinator.BlockFolder + "{0}.cshtml",
                TemplateCoordinator.PagePartialsFolder + "{0}.cshtml",
                "~/Views/Blocks/{1}/{0}.cshtml"
            };

        private static readonly string[] AdditionalViewFormats = new[]
        {
            "~/Views/Pages/{1}/{0}.cshtml",
            "~/Views/Media/{1}/{0}.cshtml"
        };

        public SiteViewEngine()
        {
            PartialViewLocationFormats = PartialViewLocationFormats.Union(AdditionalPartialViewFormats).ToArray();
            ViewLocationFormats = ViewLocationFormats.Union(AdditionalViewFormats).ToArray();
        }
    }
}
