using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvcAprendizaje3BD.Models;

namespace mvcAprendizaje3BD.Controllers
{
    public class clientesController : Controller
    {
        //aqui tengo la instancia llamada db, es una dbcontext
        private clientesDBContext db = new clientesDBContext();

        //
        // GET: /clientes/
        //pagina por default
        public ActionResult Index()
        {
            //regresa una vista de todas las clientes
            return View(db.clientes.ToList());
            //marcara error despues de aplicar los required
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
        public ActionResult Create(clientes clientes)
        {
            if (ModelState.IsValid)
            {
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