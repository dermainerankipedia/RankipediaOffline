﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace RankipediaOffline
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
              name: "Templates",
              url: "{feature}/Template/{name}",
              defaults: new { controller = "Template", action = "Render" }
          );



            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Profile", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
