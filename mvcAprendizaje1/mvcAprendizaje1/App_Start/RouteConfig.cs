using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

//este archivo es para configurar las rutas
namespace mvcAprendizaje1
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(//aqui se colocan los mapeos de ruta
                name: "Default",
                //la url, es eun controlador, una accion y un parameto id
                url: "{controller}/{action}/{id}",
                //se configura el controlador por default como home
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
                //lock anerior es igual a colocar www.nuestraweb.com/index.aspx
                /*aquí se rompe el formato de trabajo de los web forms, aqui ya 
                las peticiones las resuelve un controlador*/
            );
        }
    }
}