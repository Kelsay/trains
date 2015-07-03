using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Routing;

namespace Training.App_Start
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {

            config.Routes.MapHttpRoute(
                name: "GetAll",
                routeTemplate: "{controller}",
                defaults: new { action = "GetAll", id = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
                name: "GetById",
                routeTemplate: "{controller}/{id}",
                defaults: new { action = "GetById" }
            ); 

            config.Routes.MapHttpRoute(
                name: "Defaut",
                routeTemplate: "{controller}/{action}/{id}",
                defaults: new { action = "GetAll", id = RouteParameter.Optional }
            ); 

            var appXmlType = config.Formatters.XmlFormatter.SupportedMediaTypes.FirstOrDefault(t => t.MediaType == "application/xml");
            config.Formatters.XmlFormatter.SupportedMediaTypes.Remove(appXmlType);
        }
    }
}