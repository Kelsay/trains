using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Core;
using Umbraco.Core.Persistence;
using Umbraco.Core.Models;
using Umbraco.Web;
using Training.Models;
using Newtonsoft.Json;
using Umbraco.Web.Mvc;
using Umbraco.Web.WebApi;

namespace Training.Code
{
    public static class Timetable //: UmbracoApiController
    {

        // Expose Umbraco Helper in the Class
        private static UmbracoHelper Umbraco = new UmbracoHelper(UmbracoContext.Current);
        private static UmbracoDatabase Database = ApplicationContext.Current.DatabaseContext.Database;


        // Add a service to main timetable in DB
        public static void Add(int serviceId)
        {
            Delete(serviceId); // starts with deleting previous entries
            IPublishedContent page = Umbraco.TypedContent(serviceId);
            string timetable = page.GetString("timetable");
            IEnumerable<ServiceTimetableModel> nodes = JsonConvert.DeserializeObject<IEnumerable<ServiceTimetableModel>>(timetable);
            if (nodes.Any())
            {
                foreach (ServiceTimetableModel node in nodes)
                {
                    DatabaseTimetableModel model = new DatabaseTimetableModel
                    {
                        ServiceId = page.Id,
                        StationId = node.Station,
                        Time = node.Time
                    };
                    Database.Save(model);
                    //var db = ApplicationContext.Current.DatabaseContext.Database;
                    //db.Save(model);
                }
            }
        }

        // Delete service from table in DB
        public static void Delete(int serviceId)
        {
            
        }

        public static string Get(int pageId)
        {
            IPublishedContent page = Umbraco.TypedContent(pageId);
            return "";
        }

    }
}