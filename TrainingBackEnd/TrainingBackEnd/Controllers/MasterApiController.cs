using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Mvc;
using Umbraco.Core.Models;
using Umbraco.Web;
using Umbraco.Web.Mvc;
using Umbraco.Web.WebApi;

namespace Training.Controllers
{
    public class MasterApiController : UmbracoApiController
    {

        public JsonSerializerSettings JsonSettings = new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() };

        // Get all documents of the type 

        public IEnumerable<IPublishedContent> GetAllOfType(string docType)
        {
            IPublishedContent root = Umbraco.TypedContentAtRoot().FirstOrDefault();
            IEnumerable<IPublishedContent> nodes = root.Descendants(docType);
            return nodes;
        }

        // Returns response Json
        // Keys are converted to Javascript standard camelCase
        public HttpResponseMessage Json(Object model)
        {
            string result = JsonConvert.SerializeObject(model, JsonSettings);
            var response = new HttpResponseMessage(HttpStatusCode.OK)
                {
                    Content = new StringContent(result, Encoding.UTF8, "application/json")
                };
            return response;
        }

    }
}