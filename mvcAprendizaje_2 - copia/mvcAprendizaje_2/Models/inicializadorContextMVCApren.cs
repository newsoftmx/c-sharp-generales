using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcAprendizaje_2.Models
{
    public class inicializadorContextMVCApren : DropCreateDatabaseAlways<contextMVCAprendizaje>
    {
        //
        // GET: /inicializadorContextMVCApren/

        /*public ActionResult Index()
        {
            return View();
        }*/
        protected override void Seed(contextMVCAprendizaje context)
        {
            //base.Seed(context);
            context.Sessions.Add(
                new Session()
                {
                    Title = "Buena práctica de MVC con MVA",
                    Abstract = "Una buena práctica de MVC con MVA",
                    Speaker = context.Speakers.Add(
                        new Speaker()
                        {
                            Name = "Victor Becerra Cordoba",
                            EmailAddress = "direccion@newsoft.mx"
                        })
                });
            context.SaveChanges();
        }
    }
}
