using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EPiServer;
using EPiServer.Core;
using EPiServer.Web;
using EPiServer.Web.Mvc;

using ShangriLaWeb.Models.Blocks;

namespace ShangriLaWeb.Controllers
{
    public class HotelModuleBlockController : BlockController<HotelModuleBlock>
    {
        public override ActionResult Index(HotelModuleBlock currentBlock)
        {
            return PartialView(currentBlock);
        }
    }
}
