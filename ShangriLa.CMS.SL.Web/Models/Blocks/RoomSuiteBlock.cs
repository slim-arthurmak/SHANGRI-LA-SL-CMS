using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace ShangriLa.CMS.SL.Web.Models.Blocks
{
    [ContentType(DisplayName = "RoomSuiteBlock", GUID = "275712a5-21d6-4ef4-884e-cdbeb2b04250", Description = "")]
    public class RoomSuiteBlock : SiteBlockData
    {
        /*
                [CultureSpecific]
                [Display(
                    Name = "Name",
                    Description = "Name field's description",
                    GroupName = SystemTabNames.Content,
                    Order = 1)]
                public virtual string Name { get; set; }
         */
    }
}