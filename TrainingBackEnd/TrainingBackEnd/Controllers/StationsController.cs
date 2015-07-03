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
using System.Net.Http;
using System.Net;

namespace Training.Controllers
{
    public class StationsController : MasterApiController
    {

        // Gets all trains and returns json serialized from List<StationModel>
        //public IEnumerable<StationModel> GetAll()
        public HttpResponseMessage GetAll()
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
            //return model;
            return Json(model);
        }

        public HttpResponseMessage GetById(int id)
        {
            try
            {
                IPublishedContent page = Umbraco.TypedContent(id);
                if (page.DocumentTypeAlias == "Station")
                {
                    StationFullModel station = new StationFullModel
                    {
                        Id = page.Id.ToString(),
                        Name = page.Name,
                        Timetable = TimetableHelper.Get(id)
                    };
                    //return JsonConvert.SerializeObject(station, Formatting.Indented, JsonSettings);
                    return Json(station);
                }
                return new HttpResponseMessage(HttpStatusCode.NotFound);
            }
            catch
            {
                return new HttpResponseMessage(HttpStatusCode.BadRequest);
            }
        }

        public void GetTimetable(int stationId)
        {
            var timetable = TimetableHelper.Get(stationId);
        }


    }
}