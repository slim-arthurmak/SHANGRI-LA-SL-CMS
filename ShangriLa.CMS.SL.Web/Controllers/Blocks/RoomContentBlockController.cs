using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EPiServer;
using EPiServer.Core;
using EPiServer.Web;
using EPiServer.Web.Mvc;

using ShangriLa.CMS.SL.Web.Models.Blocks;
using ShangriLa.CMS.SL.Web.Business;

namespace ShangriLa.CMS.SL.Web.Controllers.Blocks
{
    public class RoomContentBlockController : BlockController<RoomContentBlock>
    {
        private ContentLocator contentLocator;
        private IContentLoader contentLoader;
        public RoomContentBlockController(ContentLocator contentLocator, IContentLoader contentLoader)
        {
            this.contentLocator = contentLocator;
            this.contentLoader = contentLoader;
        }

        public override ActionResult Index(RoomContentBlock currentBlock)
        {
            return PartialView(currentBlock);
        }
    }
}
