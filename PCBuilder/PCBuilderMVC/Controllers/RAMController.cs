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
    /// RAM controller class to handle RAM views interaction. 
    /// </summary>
    /// <seealso cref="System.Web.Mvc.Controller" />
    public class RAMController : Controller
    {
        private PCBuilderEntityModels db = new PCBuilderEntityModels();

        // GET: RAM
        public ActionResult Index()
        {
            return View(db.RAMs.ToList());
        }

        // GET: RAM/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RAM rAM = db.RAMs.Find(id);
            if (rAM == null)
            {
                return HttpNotFound();
            }
            return View(rAM);
        }

        // GET: RAM/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RAM/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "RamId,Brand,Model,RamSize,RamGeneration,RamSpeed,RamTimings,BestUse,Price")] RAM rAM)
        {
            if (ModelState.IsValid)
            {
                db.RAMs.Add(rAM);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(rAM);
        }

        // GET: RAM/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RAM rAM = db.RAMs.Find(id);
            if (rAM == null)
            {
                return HttpNotFound();
            }
            return View(rAM);
        }

        // POST: RAM/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "RamId,Brand,Model,RamSize,RamGeneration,RamSpeed,RamTimings,BestUse,Price")] RAM rAM)
        {
            if (ModelState.IsValid)
            {
                db.Entry(rAM).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(rAM);
        }

        // GET: RAM/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RAM rAM = db.RAMs.Find(id);
            if (rAM == null)
            {
                return HttpNotFound();
            }
            return View(rAM);
        }

        // POST: RAM/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            RAM rAM = db.RAMs.Find(id);
            db.RAMs.Remove(rAM);
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
