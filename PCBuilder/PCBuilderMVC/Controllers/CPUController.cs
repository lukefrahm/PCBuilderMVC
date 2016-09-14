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
    /// CPU controller class to handle CPU views interaction. 
    /// </summary>
    /// <seealso cref="System.Web.Mvc.Controller" />
    public class CPUController : Controller
    {
        private PCBuilderEntityModels db = new PCBuilderEntityModels();

        // GET: CPU
        public ActionResult Index()
        {
            return View(db.CPUs.ToList());
        }

        // GET: CPU/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CPU cPU = db.CPUs.Find(id);
            if (cPU == null)
            {
                return HttpNotFound();
            }
            return View(cPU);
        }

        // GET: CPU/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CPU/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CpuId,Brand,Model,Cores,HyperThreaded,ClockSpeed,Unlocked,Socket,ProductLineName,BenchmarkScore,BestUse,PowerRequirement,Price")] CPU cPU)
        {
            if (ModelState.IsValid)
            {
                db.CPUs.Add(cPU);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cPU);
        }

        // GET: CPU/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CPU cPU = db.CPUs.Find(id);
            if (cPU == null)
            {
                return HttpNotFound();
            }
            return View(cPU);
        }

        // POST: CPU/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CpuId,Brand,Model,Cores,HyperThreaded,ClockSpeed,Unlocked,Socket,ProductLineName,BenchmarkScore,BestUse,PowerRequirement,Price")] CPU cPU)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cPU).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cPU);
        }

        // GET: CPU/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CPU cPU = db.CPUs.Find(id);
            if (cPU == null)
            {
                return HttpNotFound();
            }
            return View(cPU);
        }

        // POST: CPU/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CPU cPU = db.CPUs.Find(id);
            db.CPUs.Remove(cPU);
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
