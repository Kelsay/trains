using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Web;
using Umbraco.Web.Mvc;
using Training.Code;
using Training.Models;
using Umbraco.Web.WebApi;
using Newtonsoft.Json.Serialization;
using System.Web.Mvc;

namespace Training.Controllers
{
    public class StationsController : MasterController
    {

        // Gets all trains and returns json serialized from List<StationModel>
        public string GetAll()
        {
            List<StationModel> model = new List<StationModel>();
            IEnumerable<IPublishedContent> stations = GetAllOfType("Station");
            if (stations.Any())
            {
                foreach (IPublishedContent station in stations)
                {
                    model.Add(new StationModel
                    {
                        Id = station.Id.ToString(),
                        Name = station.Name,
                        Code = station.GetString("code")
                    });
                }
            }
            return JsonConvert.SerializeObject(model, JsonSettings);
        }

        public string GetById(string id)
        {
            try
            {
                IPublishedContent page = Umbraco.TypedContent(id);
                if (page.DocumentTypeAlias == "Station")
                {
                    StationFullModel station = new StationFullModel
                    {
                        Id = page.Id.ToString(),
                        Name = page.Name
                    };
                    return JsonConvert.SerializeObject(station, JsonSettings);
                }
                return "ID Not Found";
            }
            catch
            {
                return "Bad request";
            }
        }

        public void GetTimetable(int id)
        {
            IEnumerable<IPublishedContent> services = GetAllOfType("Service").Where(x => x.StopsOnStation(id));
            List<StationTimetableModel> timetable = new List<StationTimetableModel>();
        }


    }
}