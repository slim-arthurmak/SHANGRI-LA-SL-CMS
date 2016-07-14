using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

using ShangriLa.CMS.SL.Web.Models.Pages;

namespace ShangriLa.CMS.SL.Web.Models.Blocks
{
    [ContentType(DisplayName = "CommonBlock", GUID = "FA5BB2F6-2FDC-48D9-978B-73BCFBDC07B7", Description = "")]
    public class CommonBlock : BlockData
    {
        
                [CultureSpecific]
                [Display(
                    Name = "Name",
                    Description = "Name field's description",
                    GroupName = SystemTabNames.Content,
                    Order = 1)]
                public virtual string Name { get; set; }
         
    }
}