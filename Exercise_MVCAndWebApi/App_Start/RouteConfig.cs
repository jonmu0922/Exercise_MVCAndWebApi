using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Exercise_MVCAndWebApi
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );


            // 自訂Router
            routes.MapRoute(
                name: "ViewPost",
                url: "Post/{id}",
                defaults: new { controller = "Post", action = "ViewPost" },
                constraints: new { id = @"\d+" }
            );
        }
    }
}
