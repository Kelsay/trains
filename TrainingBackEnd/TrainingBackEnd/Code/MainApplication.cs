using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Umbraco.Core;
using Umbraco.Core.Persistence;
using Umbraco.Web;
using Training.App_Start;
using Training.Models;
using System.Web.Routing;

namespace Training.Code
{
    public class MainApplication : UmbracoApplication
    {

        new void Application_Start(object sender, EventArgs e)
        {
            base.Application_Start(sender, e);
            RouteTable.Routes.Ignore("{resource}.axd/{*pathInfo}"); // Ignore axd resource routes
            GlobalConfiguration.Configure(WebApiConfig.Register);
        } 

    }

    // Create needed tables in the database
    public class MainEvents : ApplicationEventHandler {
        protected override void ApplicationStarted(UmbracoApplicationBase umbracoApplication, ApplicationContext applicationContext)
        {
            var db = applicationContext.DatabaseContext.Database;
            if (!db.TableExist("Timetable"))
            {
                db.CreateTable<Timetable>(true);
            }
        }

    }
}