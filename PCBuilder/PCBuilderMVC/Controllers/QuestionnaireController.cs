using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PCBuilderMVC.Models;
using BusinessLogic;
using BusinessObjects;

namespace PCBuilderMVC.Controllers
{
    /// <summary>
    /// Questionnaire controller class to handle Questionnaire views interaction. 
    /// </summary>
    /// <seealso cref="System.Web.Mvc.Controller" />
    public class QuestionnaireController : Controller
    {
        private PCBuilderEntityModels db = new PCBuilderEntityModels();

        // GET: Questionnaire
        public ActionResult Index()
        {
            return RedirectToAction("Create");
        }

        // GET: Questionnaire/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Questionnaire/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "QuestionnaireID,SldPerformance,ChkUseBasic,ChkUseVideoEdit,ChkUseGaming,ChkUseDevelopment,ChkUseOfficeModerate,RadResolution720,RadResolution1080,RadResolution4k,SldNumMonitors,SldStorageSize,RadSSD,RadHDD,RadRAMRecommended,RadRAMSelectManual,SldRamSize,SldNumCores,RadCaseSizeFull,RadCaseSizeMid,RadCaseSizeMicro,RadCaseSizeMini,RadCaseSizeConsole,RadBRBurner,RadBRReader,RadDVDBurner,RadOpticalNone")] QuestionnaireViewModel questionnaireViewModel)
        {
            if (ModelState.IsValid)
            {
                BuildProcessor bp = new BuildProcessor();
                QuestionnaireResults qr = new QuestionnaireResults();
                #region Cast QuestionnaireViewModel to QuestionnaireResults
                qr.SldPerformance = questionnaireViewModel.SldPerformance;
                qr.ChkUseBasic = questionnaireViewModel.ChkUseBasic;
                qr.ChkUseVideoEdit = questionnaireViewModel.ChkUseVideoEdit;
                qr.ChkUseGaming = questionnaireViewModel.ChkUseGaming;
                qr.ChkUseDevelopment = questionnaireViewModel.ChkUseDevelopment;
                qr.ChkUseOfficeModerate = questionnaireViewModel.ChkUseOfficeModerate;
                qr.RadResolution720 = questionnaireViewModel.RadResolution720;
                qr.RadResolution1080 = questionnaireViewModel.RadResolution1080;
                qr.RadResolution4k = questionnaireViewModel.RadResolution4k;
                qr.SldNumMonitors = questionnaireViewModel.SldNumMonitors;
                qr.SldStorageSize = questionnaireViewModel.SldStorageSize;
                qr.RadSSD = questionnaireViewModel.RadSSD;
                qr.RadHDD = questionnaireViewModel.RadHDD;
                qr.RadRAMRecommended = questionnaireViewModel.RadRAMRecommended;
                qr.RadRAMSelectManual = questionnaireViewModel.RadRAMSelectManual;
                qr.SldRamSize = questionnaireViewModel.SldRamSize;
                qr.SldNumCores = questionnaireViewModel.SldNumCores;
                qr.RadCaseSizeFull = questionnaireViewModel.RadCaseSizeFull;
                qr.RadCaseSizeMid = questionnaireViewModel.RadCaseSizeMid;
                qr.RadCaseSizeMicro = questionnaireViewModel.RadCaseSizeMicro;
                qr.RadCaseSizeMini = questionnaireViewModel.RadCaseSizeMini;
                qr.RadCaseSizeConsole = questionnaireViewModel.RadCaseSizeConsole;
                qr.RadBRBurner = questionnaireViewModel.RadBRBurner;
                qr.RadBRReader = questionnaireViewModel.RadBRReader;
                qr.RadDVDBurner = questionnaireViewModel.RadDVDBurner;
                qr.RadOpticalNone = questionnaireViewModel.RadOpticalNone;
                #endregion
                FinalizedBuild fb = new FinalizedBuild();
                fb = bp.DataBuilder(qr);
                FinalizedBuildViewModel fbvm = new FinalizedBuildViewModel(questionnaireViewModel.QuestionnaireID, fb);
                fbvm.price = fb.cpu.Price + fb.gpu.Price + fb.motherboard.Price + fb.optical.Price + fb.psu.Price + fb.ram.Price + fb.storage.Price;
                if (fbvm.gpu.Brand == null)
                {
                    fbvm.gpu.Brand = "No GPU needed for this build";
                }
                if (fbvm.optical.Brand == null)
                {
                    fbvm.optical.Brand = "No optical drive needed for this build";
                }
                return View("../FinalizedBuild/Details", fbvm);
            }

            return View(questionnaireViewModel);
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
