using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvcEjemploDB.Models;

namespace mvcEjemploDB.Controllers
{
    public class clientesController : Controller
    {
        private ejemplosEntities1 db = new ejemplosEntities1();

        //
        // GET: /clientes/

        public ActionResult Index()
        {
            return View(db.clientes.ToList());
        }

        //
        // GET: /clientes/Details/5

        public ActionResult Details(int id = 0)
        {
            clientes clientes = db.clientes.Find(id);
            if (clientes == null)
            {
                return HttpNotFound();
            }
            return View(clientes);
        }

        //
        // GET: /clientes/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /clientes/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        //public ActionResult Create(clientes clientes)
        public ActionResult Create(clientes clientes)
        {
            if (ModelState.IsValid)
            {
                //var db = new ControllerContext(); 
                db.clientes.Add(clientes);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(clientes);
        }

        //
        // GET: /clientes/Edit/5

        public ActionResult Edit(int id = 0)
        {
            clientes clientes = db.clientes.Find(id);
            if (clientes == null)
            {
                return HttpNotFound();
            }
            return View(clientes);
        }

        //
        // POST: /clientes/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(clientes clientes)
        {
            if (ModelState.IsValid)
            {
                db.Entry(clientes).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(clientes);
        }

        //
        // GET: /clientes/Delete/5

        public ActionResult Delete(int id = 0)
        {
            clientes clientes = db.clientes.Find(id);
            if (clientes == null)
            {
                return HttpNotFound();
            }
            return View(clientes);
        }

        //
        // POST: /clientes/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            clientes clientes = db.clientes.Find(id);
            db.clientes.Remove(clientes);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}