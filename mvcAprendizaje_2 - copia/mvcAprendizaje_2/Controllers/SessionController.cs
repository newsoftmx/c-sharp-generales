using mvcAprendizaje_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcAprendizaje_2.Controllers
{
    //[Authorize (Roles="Administrators")]
    public class SessionController : Controller
    {
        //
        // GET: /Session/

        public ActionResult Index()
        {
            //cargamos nuestra lista de sesiones
            contextMVCAprendizaje context = new contextMVCAprendizaje();
            List<Session> sessions = context.Sessions.ToList();
            //el nombre de la vista puede ser el que sea, o se puede dejar en blanco 
            //para opcion predeterminada y esta es la marcada en el actionresult
            return View("Index",sessions);
        }
        //GET:Session/create
        [HttpGet()]
        public ActionResult Create()
        {
               //primero daremos un formulario a llenar
            //segundo tomaremos lo que nos dieron y haremos algo 
            //internamente con esa información
            //en asp .net 4.5 comparten mas enlaces los datos
            //cualquier control que reconoce modelos, puede usar 
            //una accion controlador, ademas puede definir un modelo
            //y especificar el campo requerido, ahora solo verifican si es 
            //valido o no y entonces se crea la lógica

            return View();
        }
        //Post:Session/Create
        //agrego la sig linea para que sea enviado por post
        [HttpPost()]
        public ActionResult Create(Session session)
        {
            if(!ModelState.IsValid){
                return View(session);
            }
            try {
                contextMVCAprendizaje context = new contextMVCAprendizaje();
                context.Sessions.Add(session);
                context.SaveChanges();
            } catch (Exception ex) {
                ModelState.AddModelError("Error en funcionamiento", ex.Message);
                return View(session);
            }
            TempData["Mensaje"] = "Creado correctamente " + session.Title;
            return RedirectToAction("Index");
        }

    }
}
