using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcAprendizaje1.Controllers
{
    //hereda de la clase controler
    public class HomeController : Controller
    {
        // es llamado home
        // GET: /Home/

        //este es el metodo index que devuelve la vista
        /*public ActionResult Index()
        {
            //return View();
        }*/
        /*public string Index()
        {
            //return View();
            return "Felicidades, va muy bien";
        }*/
        /*ahora hacemos un metodo que recibe un parametro
        public string Index( string dato)
        {
            //return View();
            return "Felicidades, va muy bien" + dato;
        }*/
        /*public string Index(string id)
        {
            //return View();
            return "Felicidades, va muy bien" + id;
        }*/
        //***********************
        //ahora crearemos la vista
        public ActionResult index()
        {
            return View();
        }
        public ActionResult contacto()
        {
            return View();
        }
        public ActionResult conocenos()
        {
            //para pasar datos uso viebag, un diccionario de datos dinámico
            ViewBag.dato = "La información";
            //ahora usamos un diccionario de datos, no dinamico
            ViewData["Mi dato"]="Los mejores alumnos";
            return View();
        }
    }
}
