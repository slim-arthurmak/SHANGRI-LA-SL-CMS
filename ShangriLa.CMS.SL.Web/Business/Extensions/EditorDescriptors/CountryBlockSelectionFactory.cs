using EPiServer.Core;
using EPiServer.ServiceLocation;
using EPiServer.Shell.ObjectEditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using ShangriLa.CMS.SL.Web.Models.Blocks;

namespace ShangriLa.CMS.SL.Web.Business.Extensions.EditorDescriptors
{
    /// <summary>
    /// Provides a list of options corresponding to ContactPage pages on the site
    /// </summary>
    /// <seealso cref="CountryBlock"/>
    public class CountryBlockSelectionFactory : ISelectionFactory
    {
        private Injected<ContentLocator> ContentLocator { get; set; }

        public IEnumerable<ISelectItem> GetSelections(ExtendedMetadata metadata)
        {
            var countryBlocks = ContentLocator.Service.GetCountryBlocks();

            return new List<SelectItem>(countryBlocks.Select(c => new SelectItem { Value = ((IContent)c).ContentLink, Text = c.CountryName }));
        }
    }
}