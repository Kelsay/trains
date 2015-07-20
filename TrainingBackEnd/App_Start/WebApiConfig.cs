using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Routing;
using System.Web.Http.Cors;

namespace Training.App_Start
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Enable CORS
            EnableCorsAttribute cors = new EnableCorsAttribute("http://training.com", "*", "*");
            config.EnableCors(cors);

            // Route config
            // List all - eg. api.com/trains
            config.Routes.MapHttpRoute(
                name: "GetAll", 
                routeTemplate: "{controller}",
                defaults: new { action = "GetAll", id = RouteParameter.Optional }
            ); 

            // List specific eg. trains/1234
            config.Routes.MapHttpRoute(
                name: "GetById",
                routeTemplate: "{controller}/{id}",
                defaults: new { action = "GetById", id = RouteParameter.Optional }
            );

            /*config.Routes.MapHttpRoute(
                    "Default",
                    "{controller}/{action}/{id}", 
                    new { controller = "Home", action = "Index", id = RouteParameter.Optional }
                ); */


            var appXmlType = config.Formatters.XmlFormatter.SupportedMediaTypes.FirstOrDefault(t => t.MediaType == "application/xml");
            config.Formatters.XmlFormatter.SupportedMediaTypes.Remove(appXmlType);
        }
    }
}