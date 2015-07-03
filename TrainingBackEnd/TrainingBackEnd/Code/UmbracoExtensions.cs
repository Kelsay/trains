using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Core;
using Umbraco.Core.Models;
using Umbraco.Web;
//using Umbraco.Web.Mvc;

namespace Training.Code
{
    public static class UmbracoExtensions
    {

        static UmbracoHelper Umbraco = new UmbracoHelper(UmbracoContext.Current);

        // A set of convenience methods for getting values from Umbraco fields

        // Get field value as string or empty string if property does not exist
        public static string GetString(this IPublishedContent page, string key) 
        {
            return page.GetPropertyValue<string>(key, string.Empty);
        }


        // Get field value as a HtmlString
        public static HtmlString GetHtmlString(this IPublishedContent page, string key)
        {
            return page.GetPropertyValue<HtmlString>(key, new HtmlString(""));
        }


        public static IEnumerable<string> GetImagesAsList(this IPublishedContent page, string fieldName)
        {
            string fieldValue = page.GetString(fieldName);
            List<string> urls = new List<string>();
            if (!string.IsNullOrWhiteSpace(fieldValue))
            {
                List<string> ids = fieldValue.Split(',').ToList<string>();
                if (ids.Any())
                {
                    foreach (string id in ids)
                    {
                        urls.Add(GetImageSrc(id));
                    }
                }
            }
            return urls;
        }



        // Get Image Source
        public static string GetImageSrc(this IPublishedContent page, string key)
        {
            string id = page.GetString(key);
            if (!string.IsNullOrEmpty(key) && !string.IsNullOrEmpty(id))
            {
                return GetImageSrc(id);
            }
            return "";
        }

        public static string GetImageSrc(string id)
        {
            if (!string.IsNullOrWhiteSpace(id))
            {
                IPublishedContent media = Umbraco.TypedMedia(int.Parse(id));
                if (media != null)
                {
                    return media.Url;
                }
            }
            return "";
        }

    }
}