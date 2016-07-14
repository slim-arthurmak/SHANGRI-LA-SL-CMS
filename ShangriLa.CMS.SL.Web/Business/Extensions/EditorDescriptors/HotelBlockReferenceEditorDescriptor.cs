using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using EPiServer.Core;
using EPiServer.Shell.ObjectEditing.EditorDescriptors;

using ShangriLa.CMS.SL.Web.Models.Blocks;

namespace ShangriLa.CMS.SL.Web.Business.Extensions.EditorDescriptor
{
    [EditorDescriptorRegistration(TargetType = typeof(ContentReference), UIHint = "hotelblock")]
    public class HotelBlockReferenceEditorDescriptor : ContentReferenceEditorDescriptor<HotelBlock>
    {
        public override IEnumerable<ContentReference> Roots
        {
            get
            {
                return new ContentReference[] { new ContentReference(1015) };
            }
        }
    }
}