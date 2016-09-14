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
    /// Motherboard controller class to handle Motherboard views interaction. 
    /// </summary>
    /// <seealso cref="System.Web.Mvc.Controller" />
    public class MotherboardController : Controller
    {
        private PCBuilderEntityModels db = new PCBuilderEntityModels();

        // GET: Motherboard
        public ActionResult Index()
        {
            return View(db.Motherboards.ToList());
        }

        // GET: Motherboard/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Motherboard motherboard = db.Motherboards.Find(id);
            if (motherboard == null)
            {
                return HttpNotFound();
            }
            return View(motherboard);
        }

        // GET: Motherboard/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Motherboard/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MotherboardId,Brand,Model,Socket,Chipset,MaxRam,RamType,FormFactor,SataPorts,M2Slots,PowerPhases,FanHeaders,Pcie16,Pcie8,Pcie4,Pcie1,Pci,Price")] Motherboard motherboard)
        {
            if (ModelState.IsValid)
            {
                db.Motherboards.Add(motherboard);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(motherboard);
        }

        // GET: Motherboard/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Motherboard motherboard = db.Motherboards.Find(id);
            if (motherboard == null)
            {
                return HttpNotFound();
            }
            return View(motherboard);
        }

        // POST: Motherboard/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MotherboardId,Brand,Model,Socket,Chipset,MaxRam,RamType,FormFactor,SataPorts,M2Slots,PowerPhases,FanHeaders,Pcie16,Pcie8,Pcie4,Pcie1,Pci,Price")] Motherboard motherboard)
        {
            if (ModelState.IsValid)
            {
                db.Entry(motherboard).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(motherboard);
        }

        // GET: Motherboard/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Motherboard motherboard = db.Motherboards.Find(id);
            if (motherboard == null)
            {
                return HttpNotFound();
            }
            return View(motherboard);
        }

        // POST: Motherboard/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Motherboard motherboard = db.Motherboards.Find(id);
            db.Motherboards.Remove(motherboard);
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
