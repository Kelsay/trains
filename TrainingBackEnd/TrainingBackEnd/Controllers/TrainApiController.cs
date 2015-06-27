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

namespace Training.Controllers
{
    public class TrainApiController : UmbracoApiController
    {

        public string GetTrains()
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
                        Name = train.Name + train.GetString("images"),
                        Description = train.GetString("description"),
                        //Images = train.GetPropertyValue<IEnumerable<string>>("images")
                        Images = train.GetImagesAsList("images")
                    });
                }
            }

            return JsonConvert.SerializeObject(trains);
        }

    }
}