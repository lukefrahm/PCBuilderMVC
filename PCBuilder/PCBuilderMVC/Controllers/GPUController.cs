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
    /// GPU controller class to handle GPU views interaction. 
    /// </summary>
    /// <seealso cref="System.Web.Mvc.Controller" />
    public class GPUController : Controller
    {
        private PCBuilderEntityModels db = new PCBuilderEntityModels();

        // GET: GPU
        public ActionResult Index()
        {
            return View(db.GPUs.ToList());
        }

        // GET: GPU/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GPU gPU = db.GPUs.Find(id);
            if (gPU == null)
            {
                return HttpNotFound();
            }
            return View(gPU);
        }

        // GET: GPU/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GPU/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "GpuId,Brand,Model,ClockSpeed,ProductLineName,BenchmarkScore,BestUse,GpuRamSize,PciPinConnector1,PciPinConnector2,PciPinConnector3,PowerRequirement,GpuLength,Price")] GPU gPU)
        {
            if (ModelState.IsValid)
            {
                db.GPUs.Add(gPU);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(gPU);
        }

        // GET: GPU/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GPU gPU = db.GPUs.Find(id);
            if (gPU == null)
            {
                return HttpNotFound();
            }
            return View(gPU);
        }

        // POST: GPU/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "GpuId,Brand,Model,ClockSpeed,ProductLineName,BenchmarkScore,BestUse,GpuRamSize,PciPinConnector1,PciPinConnector2,PciPinConnector3,PowerRequirement,GpuLength,Price")] GPU gPU)
        {
            if (ModelState.IsValid)
            {
                db.Entry(gPU).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(gPU);
        }

        // GET: GPU/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GPU gPU = db.GPUs.Find(id);
            if (gPU == null)
            {
                return HttpNotFound();
            }
            return View(gPU);
        }

        // POST: GPU/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            GPU gPU = db.GPUs.Find(id);
            db.GPUs.Remove(gPU);
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
