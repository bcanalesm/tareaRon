using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Restaurante
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Maestro", action = "Maestro", id = UrlParameter.Optional }
           
            );  
            
            routes.MapRoute(
                name: "Mesa",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Mesa", action = "Mesa", id = UrlParameter.Optional }
                );
            
            
        }
    }
}