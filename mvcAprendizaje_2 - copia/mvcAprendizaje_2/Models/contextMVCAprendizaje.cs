using System;
using System.Collections.Generic;
//esta linea se agrega
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcAprendizaje_2.Models
{
    //public class contextMVCAprendizaje : Controller
    public class contextMVCAprendizaje : DbContext
    {
        //
        // GET: /contextMVCAprendizaje/

       /* public ActionResult Index()
        {
            return View();
        }*/
        public DbSet<Session> Sessions { get; set; }
        public DbSet<Speaker> Speakers { get; set; }

    }
}
