using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PCBuilderMVC.Models;

namespace PCBuilderMVC.Controllers
{
    /// <summary>
    /// Optical drive controller class to handle Optical views interaction. 
    /// </summary>
    /// <seealso cref="System.Web.Mvc.Controller" />
    public class OpticalController : Controller
    {
        private PCBuilderEntityModels db = new PCBuilderEntityModels();

        // GET: Optical
        public ActionResult Index()
        {
            return View(db.Opticals.ToList());
        }

        // GET: Optical/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Optical optical = db.Opticals.Find(id);
            if (optical == null)
            {
                return HttpNotFound();
            }
            return View(optical);
        }

        // GET: Optical/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Optical/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "OpticalId,Brand,Model,OpticalType,Price")] Optical optical)
        {
            if (ModelState.IsValid)
            {
                db.Opticals.Add(optical);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(optical);
        }

        // GET: Optical/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Optical optical = db.Opticals.Find(id);
            if (optical == null)
            {
                return HttpNotFound();
            }
            return View(optical);
        }

        // POST: Optical/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "OpticalId,Brand,Model,OpticalType,Price")] Optical optical)
        {
            if (ModelState.IsValid)
            {
                db.Entry(optical).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(optical);
        }

        // GET: Optical/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Optical optical = db.Opticals.Find(id);
            if (optical == null)
            {
                return HttpNotFound();
            }
            return View(optical);
        }

        // POST: Optical/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Optical optical = db.Opticals.Find(id);
            db.Opticals.Remove(optical);
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
