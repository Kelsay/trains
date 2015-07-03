﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Umbraco.Core;
using Umbraco.Core.Persistence;
using Umbraco.Web;
using Training.App_Start;
using Training.Models;

namespace Training.Code
{
    public class MainApplication : UmbracoApplication
    {
        protected override void OnApplicationStarted(object sender, EventArgs e)
        {
            base.OnApplicationStarted(sender, e);
            GlobalConfiguration.Configuration.Routes.IgnoreRoute("Resources", "{resource}.axd/{*pathInfo}");
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