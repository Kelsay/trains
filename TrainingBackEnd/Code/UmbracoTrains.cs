using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Core;
using Umbraco.Core.Models;
using Umbraco.Web;
using Umbraco.Web.Mvc;
using Training.Models;
using Newtonsoft.Json;

namespace Training.Code
{
    public static class UmbracoTrainExtensions
    {

        public static IEnumerable<IPublishedContent> GetTrains(IPublishedContent page)
        {
            var Umbraco = new Umbraco.Web.UmbracoHelper(UmbracoContext.Current);
            IPublishedContent root = Umbraco.TypedContentAtRoot().FirstOrDefault();
            return root.Descendants("Train");
        }

        public static bool StopsOnStation(this IPublishedContent page, int stationId)
        {
            string timetableJson = page.GetString("timetable");
            return true;
        }

        public static string GetFirstStation(this IPublishedContent page, string serviceId)
        {
            return "";
        }

    }
}