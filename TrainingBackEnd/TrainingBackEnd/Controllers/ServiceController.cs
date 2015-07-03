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
    public class ServicesController : UmbracoApiController
    {

        public string GetAll()
        {
            var db = ApplicationContext.DatabaseContext.Database;
 
            return "";
        }

    }
}