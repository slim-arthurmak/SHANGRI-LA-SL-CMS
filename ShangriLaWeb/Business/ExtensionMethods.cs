using EPiServer;
using EPiServer.Core;
using EPiServer.Search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace AlloyTraining.Business
{
    public static class ExtensionMethods
    {
        /// Truncate strings after n words
        /// </summary>
        /// <param name="input"></param>
        /// <param name="noWords"></param>
        /// <returns></returns>
        public static string TruncateAtWord(this string input, int noWords)
        {
            string output = string.Empty;
            string[] inputArr = input.Split(new[] { ' ' });   if (inputArr.Length <= noWords)
                return input;   if (noWords > 0)
            {
                for (int i = 0; i < noWords; i++)
                {
                    output += inputArr[i] + " ";
                }
                output += "...";
                return output;
            }
            return input;
        }   
        public static Uri GetExternalUrl(this IndexResponseItem item)
        {
            try
            {
                UrlBuilder url = new UrlBuilder(item.Uri);
                EPiServer.Global.UrlRewriteProvider.ConvertToExternal(url, item, System.Text.Encoding.UTF8);
                return url.Uri;
            }
            catch (Exception ex)
            {
                return default(Uri);
            }
        }

        public static string ExternalURLFromReference(this PageReference p)
        {
            PageData page = DataFactory.Instance.Get<PageData>(p);

            UrlBuilder pageURLBuilder = new UrlBuilder(page.LinkURL);

            Global.UrlRewriteProvider.ConvertToExternal(pageURLBuilder, page.PageLink, UTF8Encoding.UTF8);

            string pageURL = pageURLBuilder.ToString();

            UriBuilder uriBuilder = new UriBuilder(EPiServer.Web.SiteDefinition.Current.SiteUrl);

            uriBuilder.Path = pageURL;

            return uriBuilder.Uri.AbsoluteUri;
        }
    }
}