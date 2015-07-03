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

namespace Training.Controllers
{
    public class TrainsController : MasterController
    {

        // Gets all trains and returns json serialized from List<TrainBaseModel>
        public string GetAll()
        {
            IPublishedContent root = Umbraco.TypedContentAtRoot().FirstOrDefault();
            IEnumerable<IPublishedContent> trainNodes = root.Descendants("Train");
            List<TrainModel> trains = new List<TrainModel>();

            if (trainNodes.Any())
            {
                foreach (IPublishedContent train in trainNodes)
                {
                    trains.Add(new TrainModel()
                    {
                        Id = train.Id.ToString(),
                        Name = train.Name
                    });
                }
            }

            return JsonConvert.SerializeObject(trains, JsonSettings);
        }

        public string GetById(string id)
        {
            try
            {
                IPublishedContent page = Umbraco.TypedContent(id);
                if (page.DocumentTypeAlias == "Train")
                {
                    TrainFullModel train = new TrainFullModel
                    {
                        Id = page.Id.ToString(),
                        Name = page.GetString("name"),
                        Manufacturer = page.GetString("manufacturer"),
                        Description = page.GetString("description"),
                        Images = page.GetImagesAsList("images")
                    };
                    return JsonConvert.SerializeObject(train, JsonSettings);
                }
                return "";
            }
            catch
            {
                return "";
            }
        }


    }
}