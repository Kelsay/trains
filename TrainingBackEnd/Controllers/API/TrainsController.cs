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
using System.Net.Http;
using System.Net;

namespace Training.Controllers
{
    public class TrainsController : BaseController
    {

        // Gets all trains and returns json serialized from List<TrainBaseModel>
        public HttpResponseMessage GetAll()
        {
            IPublishedContent root = Umbraco.TypedContentAtRoot().FirstOrDefault();
            IEnumerable<IPublishedContent> trains = root.Descendants("Train");
            List<TrainModel> model = new List<TrainModel>();

            if (trains.Any())
            {
                foreach (IPublishedContent train in trains)
                {
                    model.Add(new TrainModel()
                    {
                        Id = train.Id.ToString(),
                        Name = train.Name,
                        Thumbnail = train.GetImagesAsList("images").ElementAt(0)
                    });
                }
            }
            return Json(model);
        }

        public HttpResponseMessage GetById(string id)
        {
            try
            {
                IPublishedContent page = Umbraco.TypedContent(id);
                if (page.DocumentTypeAlias == "Train")
                {
                    TrainFullModel train = new TrainFullModel
                    {
                        Id = page.Id.ToString(),
                        Name = page.Name,
                        Manufacturer = page.GetString("manufacturer"),
                        Description = page.GetString("description"),
                        Images = page.GetImagesAsList("images")
                    };
                    return Json(train);
                }
                return new HttpResponseMessage(HttpStatusCode.BadRequest);
            }
            catch
            {
                return new HttpResponseMessage(HttpStatusCode.BadRequest);
            }
        }


    }
}