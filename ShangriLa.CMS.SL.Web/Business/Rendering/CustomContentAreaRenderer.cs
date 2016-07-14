using EPiServer;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.ServiceLocation;
using EPiServer.Web;
using EPiServer.Web.Mvc;
using EPiServer.Web.Mvc.Html;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Linq;

namespace ShangriLa.CMS.SL.Web.Business.Rendering
{
    /// <summary>
    /// Extends the default <see cref="ContentAreaRenderer"/> to apply custom CSS classes to each <see cref="ContentFragment"/>.
    /// </summary>
    [ServiceConfiguration(typeof(CustomContentAreaRenderer), Lifecycle = ServiceInstanceScope.Unique)]
    public class CustomContentAreaRenderer : ContentAreaRenderer
    {
        private readonly ContentFragmentAttributeAssembler _attributeAssembler;
        private readonly IContentRenderer _contentRenderer;
        private readonly IContentRepository _contentRepository;
        private readonly TemplateResolver _templateResolver;

        public CustomContentAreaRenderer(IContentRenderer contentRenderer, TemplateResolver templateResolver, ContentFragmentAttributeAssembler attributeAssembler)
            : base(contentRenderer, templateResolver, attributeAssembler)
        {
            _contentRenderer = contentRenderer;
            _templateResolver = templateResolver;
            _attributeAssembler = attributeAssembler;
        }

        public CustomContentAreaRenderer(IContentRenderer contentRenderer, TemplateResolver templateResolver, ContentFragmentAttributeAssembler attributeAssembler, IContentRepository contentRepository)
            : base(contentRenderer, templateResolver, attributeAssembler, contentRepository)
        {
            _contentRenderer = contentRenderer;
            _templateResolver = templateResolver;
            _attributeAssembler = attributeAssembler;
            _contentRepository = contentRepository;
        }

        protected override void RenderContentAreaItem(HtmlHelper htmlHelper, ContentAreaItem contentAreaItem, string templateTag, string htmlTag, string cssClass)
        {
            var dictionary = new Dictionary<string, object>();
            dictionary["childrencustomtagname"] = htmlTag;
            dictionary["childrencssclass"] = cssClass;
            dictionary["tag"] = templateTag;

            dictionary = contentAreaItem.RenderSettings.Concat(
                (
                from r in dictionary
                where !contentAreaItem.RenderSettings.ContainsKey(r.Key)
                select r
                )
            ).ToDictionary(r => r.Key, r => r.Value);

            htmlHelper.ViewBag.RenderSettings = dictionary;
            IContent content = contentAreaItem.GetContent(this._contentRepository);
            if (content != null)
            {
                using (new ContentAreaContext(htmlHelper.ViewContext.RequestContext, content.ContentLink))
                {
                    TemplateModel templateModel = this.ResolveTemplate(htmlHelper, content, templateTag);
                    if ((templateModel != null) || this.IsInEditMode(htmlHelper))
                    {
                        if (this.IsInEditMode(htmlHelper))
                        {
                            TagBuilder tagBuilder = new TagBuilder(htmlTag);
                            this.AddNonEmptyCssClass(tagBuilder, cssClass);
                            tagBuilder.MergeAttributes<string, string>(
                                this._attributeAssembler.GetAttributes(
                                    contentAreaItem, this.IsInEditMode(htmlHelper), (bool)(templateModel != null)));
                            this.BeforeRenderContentAreaItemStartTag(tagBuilder, contentAreaItem);
                            htmlHelper.ViewContext.Writer.Write(tagBuilder.ToString(TagRenderMode.StartTag));
                            htmlHelper.RenderContentData(content, true, templateModel, this._contentRenderer);
                            htmlHelper.ViewContext.Writer.Write(tagBuilder.ToString(TagRenderMode.EndTag));
                        }
                        else
                        {
                            htmlHelper.RenderContentData(content, true, templateModel, this._contentRenderer);
                        }
                    }
                }
            }
        }

        protected override bool ShouldRenderWrappingElement(HtmlHelper htmlHelper)
        {
            return false;
        }

    }
}
