using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcAprendizaje2.Controllers
{
    public class empleadosController : Controller
    {
        //
        // GET: /empleados/

        //ahora hacemos uso del filtro authorize
        //[Authorize(Users=""]
        //[Authorize(Roles="")]
        //con la sig linea no se puede acceder a menos de que se loguen
        [Authorize]
        public ActionResult Index()
        {
            return View();
            //se puede hacer otr actionresult como este
            //return Content("Empleados como contenido");
            //o este otro
            //return RedirectPermanent("http://www.delasalle.edu.mx");
            //return RedirectToAction("Index", "Home");
            //return RedirectToAction("About", "Home");
            //para redireccionar a la ruta se usa la ruta de appstart
            //return RedirectToRoute("About", "Home");
            //return File(Server.MapPath("/content/site.css"), "text/css");
            //return Json(new { nombre = "Juan", apePaterno = "" }, JsonRequestBehavior.AllowGet);
        }

    }
}
