using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AppWebCentralTaxis.Models;

namespace AppWebCentralTaxis.Controllers
{
    public class TaxisController : Controller
    {
        private centralTaxiEntities db = new centralTaxiEntities();

        // GET: Taxis
        public ActionResult Index()
        {
            return View(db.Taxis.ToList());
        }

        // GET: Taxis/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Taxis taxis = db.Taxis.Find(id);
            if (taxis == null)
            {
                return HttpNotFound();
            }
            return View(taxis);
        }

        // GET: Taxis/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Taxis/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,nombreTaxista,matricula,numChasis,numVIN")] Taxis taxis)
        {
            if (ModelState.IsValid)
            {
                db.Taxis.Add(taxis);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(taxis);
        }

        // GET: Taxis/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Taxis taxis = db.Taxis.Find(id);
            if (taxis == null)
            {
                return HttpNotFound();
            }
            return View(taxis);
        }

        // POST: Taxis/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,nombreTaxista,matricula,numChasis,numVIN")] Taxis taxis)
        {
            if (ModelState.IsValid)
            {
                db.Entry(taxis).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(taxis);
        }

        // GET: Taxis/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Taxis taxis = db.Taxis.Find(id);
            if (taxis == null)
            {
                return HttpNotFound();
            }
            return View(taxis);
        }

        // POST: Taxis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Taxis taxis = db.Taxis.Find(id);
            db.Taxis.Remove(taxis);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
