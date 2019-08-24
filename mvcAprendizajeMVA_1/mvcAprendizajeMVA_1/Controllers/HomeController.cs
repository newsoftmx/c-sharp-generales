using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcAprendizajeMVA_1.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            //despues de crear mi primer vista prueba ahora modifico mi actionresult de index
            //para qu me muestre algun codigo, para ello uso viewbag, es un contenedor, es objeto dinamico
            //se crea la propiedad y se lanza en la vista,
            ViewBag.Message = " Compre pizza ahora";
            //in viewbag puede tener cualquier nombre
            ViewBag.pizza = "shalala shalalala";
            return View();
        }
        public ActionResult prueba1()
        {
            return View();
        }

    }
}
