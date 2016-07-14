using EPiServer.Core;
using EPiServer.DataAnnotations;
using EPiServer.Framework.DataAnnotations;
using System.ComponentModel.DataAnnotations;

namespace ShangriLa.CMS.SL.Web.Models.Media
{
    [ContentType(GUID = "1ADD17B0-F498-4FF1-A126-8F219AF3A1E8")]
    [MediaDescriptor(ExtensionString = "jpg,jpeg,jpe,ico,gif,bmp,png")]
    public class ImageFile : ImageData, IFileProperties
    {
        /// <summary>
        /// Gets or sets the copyright.
        /// </summary>
        /// <value>
        /// The copyright.
        /// </value>
        public virtual string Copyright { get; set; }

        [Editable(false)]
        public virtual string FileSize { get; set; }
    }
}
