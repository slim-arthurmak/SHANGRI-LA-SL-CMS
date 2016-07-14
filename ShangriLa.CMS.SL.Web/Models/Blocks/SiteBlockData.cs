using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace ShangriLa.CMS.SL.Web.Models.Blocks
{
    [ContentType(DisplayName = "SiteBlockData", GUID = "9f90732b-87b1-4674-92d5-11f4a977b678", Description = "")]
    /// <summary>
    /// Base class for all block types on the site
    /// </summary>
    public abstract class SiteBlockData : EPiServer.Core.BlockData
    {
    }
}