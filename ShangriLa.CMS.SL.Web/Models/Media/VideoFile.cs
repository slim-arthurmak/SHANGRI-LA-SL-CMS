using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAnnotations;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web;

namespace ShangriLa.CMS.SL.Web.Models.Media
{
    [ContentType(GUID = "1717F487-E775-4BC3-ADCF-CA69130C03EE")]
    [MediaDescriptor(ExtensionString = "flv,mp4,webm")]
    public class VideoFile : VideoData, IFileProperties
    {
        /// <summary>
        /// Gets or sets the copyright.
        /// </summary>
        public virtual string Copyright { get; set; }

        /// <summary>
        /// Gets or sets the URL to the preview image.
        /// </summary>
        [UIHint(UIHint.Image)]
        public virtual ContentReference PreviewImage { get; set; }

        [Editable(false)]
        public virtual string FileSize { get; set; }
    }
}
