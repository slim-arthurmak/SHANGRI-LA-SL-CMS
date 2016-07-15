using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

using ShangriLa.CMS.SL.Web.Models.Blocks;

namespace ShangriLa.CMS.SL.Web.Models.Folders
{
    [ContentType(DisplayName = "CountryBlockContentFolder", GUID = "d8b58a6d-4233-4329-a0d6-43a3aa112208", Description = "")]
    [AvailableContentTypes(Availability.Specific, Include = new[] { typeof(CountryBlock) })]
    public class CountryBlockContentFolder : ContentFolder
    {
    }
}