using System.Collections.Generic;
using System.Linq;
using EPiServer.Core;
using EPiServer.DataAccess;
using ShangriLa.CMS.SL.Web.Models.Folders;
using EPiServer.Framework;
using EPiServer.Framework.Initialization;
using EPiServer.Security;
using EPiServer.ServiceLocation;
using EPiServer;

//https://talk.alfnilsson.se/2015/12/07/creating-a-content-folder-that-only-allows-specific-content-types/

namespace ShangriLa.CMS.SL.Web.Business.Initialization
{
    [InitializableModule]
    [ModuleDependency(typeof(EPiServer.Web.InitializationModule))]
    public class RestrictedContentFolderInitializationModule : IInitializableModule
    {
        public void Initialize(InitializationEngine context)
        {
            IContentRepository contentRepository = ServiceLocator.Current.GetInstance<IContentRepository>();

            ContentReference siteAssetFolder = ContentReference.SiteBlockFolder;
            IEnumerable<ContentFolder> children = contentRepository.GetChildren<ContentFolder>(siteAssetFolder).ToList();

            CreateSpecificFolder<CityBlockContentFolder>(children, "Cites", siteAssetFolder, contentRepository);
            CreateSpecificFolder<CountryBlockContentFolder>(children, "Countries", siteAssetFolder, contentRepository);
            //CreateSpecificFolder<ImageContentFolder>(children, "Image folder", siteAssetFolder, contentRepository);
        }

        public void Uninitialize(InitializationEngine context)
        {
            //Add uninitialization logic
        }

        private void CreateSpecificFolder<T>(IEnumerable<ContentFolder> children, string teaserFolderName, ContentReference siteAssetFolder, IContentRepository contentRepository) where T : IContent
        {
            if (children.Any(child => child.Name == teaserFolderName))
            {
                return;
            }

            var teaserFolder = contentRepository.GetDefault<T>(siteAssetFolder);
            teaserFolder.Name = teaserFolderName;
            contentRepository.Save(teaserFolder, SaveAction.Publish, AccessLevel.NoAccess);
        }
    }
}
