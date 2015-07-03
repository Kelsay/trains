using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Mvc;

namespace Training.Controllers
{
    public class MasterController : RenderMvcController
    {
        //Redirect to the Back Office
        public ActionResult Master()
        {
            return Redirect("/umbraco");
        }
    }
}