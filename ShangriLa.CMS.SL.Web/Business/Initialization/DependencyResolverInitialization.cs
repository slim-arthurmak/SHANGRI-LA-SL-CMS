using System.Web.Mvc;
using EPiServer.Framework;
using EPiServer.Framework.Initialization;
using EPiServer.ServiceLocation;
using ShangriLa.CMS.SL.Web.Business.Rendering;
using ShangriLa.CMS.SL.Web.Helpers;
using EPiServer.Web.Mvc;
using EPiServer.Web.Mvc.Html;
using StructureMap;
using ShangriLa.CMS.SL.Web.Business.Data;

namespace ShangriLa.CMS.SL.Web.Business.Initialization
{
    [InitializableModule]
    [ModuleDependency(typeof(EPiServer.Web.InitializationModule))]
    public class DependencyResolverInitialization : IConfigurableModule
    {
        public void ConfigureContainer(ServiceConfigurationContext context)
        {
            context.Container.Configure(ConfigureContainer);

            DependencyResolver.SetResolver(new StructureMapDependencyResolver(context.Container));
        }

        private static void ConfigureContainer(ConfigurationExpression container)
        {
            //Swap out the default ContentRenderer for our custom
            container.For<IContentRenderer>().Use<ErrorHandlingContentRenderer>();
            //container.For<ContentAreaRenderer>().Use<SLContentAreaRenderer>();

            //Implementations for custom interfaces can be registered here.
            container.For<IFileDataImporter>().Use<FileDataImporter>();
        }

        public void Initialize(InitializationEngine context)
        {
        }

        public void Uninitialize(InitializationEngine context)
        {
        }

        public void Preload(string[] parameters)
        {
        }
    }
}
