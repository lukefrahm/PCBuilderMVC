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
    /// Finalized build controller class to handle FinalizedBuild views interaction. 
    /// </summary>
    /// <seealso cref="System.Web.Mvc.Controller" />
    public class FinalizedBuildController : Controller
    {
        private PCBuilderEntityModels db = new PCBuilderEntityModels();

        // GET: FinalizedBuild
        public ActionResult Index()
        {
            return View(db.FinalizedBuildViewModels.ToList());
        }

        // GET: FinalizedBuild/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FinalizedBuildViewModel f = db.FinalizedBuildViewModels.Find(id);
            if (f == null)
            {
                return HttpNotFound();
            }
            return View(f);
        }

        // GET: FinalizedBuild/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FinalizedBuild/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "FinalizedBuildID,message")] FinalizedBuildViewModel finalizedBuildViewModel)
        {
            if (ModelState.IsValid)
            {
                db.FinalizedBuildViewModels.Add(finalizedBuildViewModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(finalizedBuildViewModel);
        }

        // GET: FinalizedBuild/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FinalizedBuildViewModel finalizedBuildViewModel = db.FinalizedBuildViewModels.Find(id);
            if (finalizedBuildViewModel == null)
            {
                return HttpNotFound();
            }
            return View(finalizedBuildViewModel);
        }

        // POST: FinalizedBuild/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "FinalizedBuildID,message")] FinalizedBuildViewModel finalizedBuildViewModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(finalizedBuildViewModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(finalizedBuildViewModel);
        }

        // GET: FinalizedBuild/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FinalizedBuildViewModel finalizedBuildViewModel = db.FinalizedBuildViewModels.Find(id);
            if (finalizedBuildViewModel == null)
            {
                return HttpNotFound();
            }
            return View(finalizedBuildViewModel);
        }

        // POST: FinalizedBuild/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            FinalizedBuildViewModel finalizedBuildViewModel = db.FinalizedBuildViewModels.Find(id);
            db.FinalizedBuildViewModels.Remove(finalizedBuildViewModel);
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
