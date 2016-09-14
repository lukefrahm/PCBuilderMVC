using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    /// <summary>
    /// QuestionnaireResults object to hold necessary data on the questionnaire form after submission.
    /// </summary>
    public class QuestionnaireResults
    {
        public double SldPerformance { get; set; }
        public bool ChkUseBasic { get; set; }
        public bool ChkUseVideoEdit { get; set; }
        public bool ChkUseGaming { get; set; }
        public bool ChkUseDevelopment { get; set; }
        public bool ChkUseOfficeModerate { get; set; }
        public bool RadResolution720 { get; set; }
        public bool RadResolution1080 { get; set; }
        public bool RadResolution4k { get; set; }
        public double SldNumMonitors { get; set; }
        public double SldStorageSize { get; set; }
        public bool RadSSD { get; set; }
        public bool RadHDD { get; set; }
        public bool RadRAMRecommended { get; set; }
        public bool RadRAMSelectManual { get; set; }
        public double SldRamSize { get; set; }
        public double SldNumCores { get; set; }
        public bool RadCaseSizeFull { get; set; }
        public bool RadCaseSizeMid { get; set; }
        public bool RadCaseSizeMicro { get; set; }
        public bool RadCaseSizeMini { get; set; }
        public bool RadCaseSizeConsole { get; set; }
        public bool RadBRBurner { get; set; }
        public bool RadBRReader { get; set; }
        public bool RadDVDBurner { get; set; }
        public bool RadOpticalNone { get; set; }

        public double Pcie4 { get; set; }
        public double Pcie1 { get; set; }
        public double Pci { get; set; }
        public double Price { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="QuestionnaireResults"/> class.
        /// </summary>
        public QuestionnaireResults() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="QuestionnaireResults"/> class.
        /// </summary>
        /// <param name="sldPerformance">The slider for performance.</param>
        /// <param name="chkUseBasic">if set to <c>true</c> [Check use basic].</param>
        /// <param name="chkUseDevelopment">if set to <c>true</c> [Check use development].</param>
        /// <param name="chkUseGaming">if set to <c>true</c> [Check use gaming].</param>
        /// <param name="chkUseOfficeModerate">if set to <c>true</c> [Check use office moderate].</param>
        /// <param name="chkUseVideoEdit">if set to <c>true</c> [Check use video editing].</param>
        /// <param name="radResolution720">if set to <c>true</c> [Monitor resolution 720].</param>
        /// <param name="radResolution1080">if set to <c>true</c> [Monitor resolution 1080].</param>
        /// <param name="radResolution4k">if set to <c>true</c> [Monitor resolution 4k].</param>
        /// <param name="sldNumMonitors">The slider for number of monitors.</param>
        /// <param name="sldStorageSize">Size of the storage.</param>
        /// <param name="radSSD">if set to <c>true</c>, [use SSD].</param>
        /// <param name="radHDD">if set to <c>true</c>, [use HDD].</param>
        /// <param name="radRAMRecommended">if set to <c>true</c>, [Use recommended RAM size].</param>
        /// <param name="radRAMSelectManual">if set to <c>true</c>, [Use manual Ram size].</param>
        /// <param name="sldRamSize">Size of the ram.</param>
        /// <param name="sldNumCores">The number of cores.</param>
        /// <param name="radCaseSizeFull">if set to <c>true</c>, [full size case].</param>
        /// <param name="radCaseSizeMid">if set to <c>true</c>, [mid size case].</param>
        /// <param name="radCaseSizeMicro">if set to <c>true</c>, [micro-ATX case].</param>
        /// <param name="radCaseSizeMini">if set to <c>true</c>, [mini-ITX case].</param>
        /// <param name="radCaseSizeConsole">if set to <c>true</c>, [HTPC/Console case].</param>
        /// <param name="radBRBurner">if set to <c>true</c>, [BluRay burner].</param>
        /// <param name="radBRReader">if set to <c>true</c>, [BluRay reader].</param>
        /// <param name="radDVDBurner">if set to <c>true</c>, [DVD burner].</param>
        /// <param name="radOpticalNone">if set to <c>true</c>, [No optical drive].</param>
        public QuestionnaireResults(double sldPerformance,
                                    bool chkUseBasic,
                                    bool chkUseDevelopment,
                                    bool chkUseGaming,
                                    bool chkUseOfficeModerate,
                                    bool chkUseVideoEdit,
                                    bool radResolution720,
                                    bool radResolution1080,
                                    bool radResolution4k,
                                    double sldNumMonitors,
                                    double sldStorageSize,
                                    bool radSSD,
                                    bool radHDD,
                                    bool radRAMRecommended,
                                    bool radRAMSelectManual,
                                    double sldRamSize,
                                    double sldNumCores,
                                    bool radCaseSizeFull,
                                    bool radCaseSizeMid,
                                    bool radCaseSizeMicro,
                                    bool radCaseSizeMini,
                                    bool radCaseSizeConsole,
                                    bool radBRBurner,
                                    bool radBRReader,
                                    bool radDVDBurner,
                                    bool radOpticalNone)
        {
            SldPerformance = sldPerformance;
            ChkUseBasic = chkUseBasic;
            ChkUseVideoEdit = chkUseVideoEdit;
            ChkUseGaming = chkUseGaming;
            ChkUseDevelopment = chkUseDevelopment;
            ChkUseOfficeModerate = chkUseOfficeModerate;
            RadResolution720 = radResolution720;
            RadResolution1080 = radResolution1080;
            RadResolution4k = radResolution4k;
            SldNumMonitors = sldNumMonitors;
            SldStorageSize = sldStorageSize;
            RadSSD = radSSD;
            RadHDD = radHDD;
            RadRAMRecommended = radRAMRecommended;
            RadRAMSelectManual = radRAMSelectManual;
            SldRamSize = sldRamSize;
            SldNumCores = sldNumCores;
            RadCaseSizeFull = radCaseSizeFull;
            RadCaseSizeMid = radCaseSizeMid;
            RadCaseSizeMicro = radCaseSizeMicro;
            RadCaseSizeMini = radCaseSizeMini;
            RadCaseSizeConsole = radCaseSizeConsole;
            RadBRBurner = radBRBurner;
            RadBRReader = radBRReader;
            RadDVDBurner = radDVDBurner;
            RadOpticalNone = radOpticalNone;
        }
    }
}
