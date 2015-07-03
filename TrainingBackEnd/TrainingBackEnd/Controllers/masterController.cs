using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Web;
using Umbraco.Web.Mvc;
using Umbraco.Web.WebApi;

namespace Training.Controllers
{
    public class MasterController : UmbracoApiController
    {

        public JsonSerializerSettings JsonSettings = new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() };

        // Get all documents of the type 

        public IEnumerable<IPublishedContent> GetAllOfType(string docType)
        {
            IPublishedContent root = Umbraco.TypedContentAtRoot().FirstOrDefault();
            IEnumerable<IPublishedContent> nodes = root.Descendants(docType);
            return nodes;
        }


    }
}