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
using Umbraco.Core.Services;

namespace Training.Code
{
    public static class TimetableHelper
    {

        // Expose Umbraco Helper in the Class
        //private static UmbracoHelper Umbraco = new UmbracoHelper(UmbracoContext.Current);
        private static ContentService ContentService = new ContentService();
        private static UmbracoDatabase Database = ApplicationContext.Current.DatabaseContext.Database;


        // Add a service to main timetable in DB
        public static void Add(int serviceId)
        {

            // Start with clearing previous entries
            Delete(serviceId); 

            // Get the value of DataGrid Timetable
            IContent service = ContentService.GetById(serviceId);
            string timetable = service.GetValue<string>("timetable"); 
            
            // If there is value, deserialize it to object
            if (!string.IsNullOrWhiteSpace(timetable))
            {
                IEnumerable<ServiceTimetableModel> nodes = JsonConvert.DeserializeObject<IEnumerable<ServiceTimetableModel>>(timetable);
                if (nodes.Any())
                {
                    IContent destination = ContentService.GetById(nodes.Last().Station);

                    foreach (ServiceTimetableModel node in nodes)
                    {
                        Timetable model = new Timetable
                        {
                            ServiceId = service.Id,
                            StationId = node.Station,
                            Time = node.Time,
                            Destination = destination.Name
                        };
                        Database.Save(model);
                    }
                }
            }
        }

        // Delete service from table in DB
        public static void Delete(int serviceId)
        {

        }

        public static IEnumerable<Timetable> Get(int stationId)
        {
            var query = new Sql().Select("*").From("Timetable").Where<Timetable>(x => x.StationId.Equals(stationId));
            IEnumerable<Timetable> fetched = Database.Fetch<Timetable>(query).OrderBy(x => x.Time);
            return fetched;
        }

    }
}