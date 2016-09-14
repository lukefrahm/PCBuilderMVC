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
    /// PSU controller class to handle PSU views interaction. 
    /// </summary>
    /// <seealso cref="System.Web.Mvc.Controller" />
    public class PSUController : Controller
    {
        private PCBuilderEntityModels db = new PCBuilderEntityModels();

        // GET: PSU
        public ActionResult Index()
        {
            return View(db.PSUs.ToList());
        }

        // GET: PSU/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PSU pSU = db.PSUs.Find(id);
            if (pSU == null)
            {
                return HttpNotFound();
            }
            return View(pSU);
        }

        // GET: PSU/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PSU/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PsuId,Brand,Model,Wattage,Efficiency,Price")] PSU pSU)
        {
            if (ModelState.IsValid)
            {
                db.PSUs.Add(pSU);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pSU);
        }

        // GET: PSU/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PSU pSU = db.PSUs.Find(id);
            if (pSU == null)
            {
                return HttpNotFound();
            }
            return View(pSU);
        }

        // POST: PSU/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PsuId,Brand,Model,Wattage,Efficiency,Price")] PSU pSU)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pSU).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pSU);
        }

        // GET: PSU/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PSU pSU = db.PSUs.Find(id);
            if (pSU == null)
            {
                return HttpNotFound();
            }
            return View(pSU);
        }

        // POST: PSU/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PSU pSU = db.PSUs.Find(id);
            db.PSUs.Remove(pSU);
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
