using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;



namespace ShangriLa.EPiServer.Shared.Models.Blocks
{
    [ContentType(DisplayName = "CommonBlock Shared", GUID = "FA6DB103-1289-458A-9D66-55BA77E843B6", Description = "")]
    public class CommonSharedBlock : BlockData
    {
                [CultureSpecific]
                [Display(
                    Name = "CommonSharedText",
                    Description = "CommonSharedText",
                    GroupName = SystemTabNames.Content,
                    Order = 1)]
                public virtual string CommonSharedText { get; set; }
         
    }
}