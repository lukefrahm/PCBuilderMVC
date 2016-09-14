using BusinessObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PCBuilderMVC.Models
{
    /// <summary>
    /// Questionnaire view model class.
    /// </summary>
    public class QuestionnaireViewModel
    {
        [Key]
        public int QuestionnaireID { get; set; }
        [Range(300,3000)]
        [Display(Name="Budget")]
        public double SldPerformance { get; set; }
        [Display(Name = "Basic Use")]
        public bool ChkUseBasic { get; set; }
        [Display(Name = "Rendering/Video Editing")]
        public bool ChkUseVideoEdit { get; set; }
        [Display(Name = "Gaming")]
        public bool ChkUseGaming { get; set; }
        [Display(Name = "Software Development")]
        public bool ChkUseDevelopment { get; set; }
        [Display(Name = "Office Use")]
        public bool ChkUseOfficeModerate { get; set; }
        [Display(Name = "Monitor: 720p")]
        public bool RadResolution720 { get; set; }
        [Display(Name = "Monitor: 1080p")]
        public bool RadResolution1080 { get; set; }
        [Display(Name = "Monitor: 4k")]
        public bool RadResolution4k { get; set; }
        [Display(Name = "Number of Monitors")]
        [Range(1,6)]
        public double SldNumMonitors { get; set; }
        [Display(Name = "Storage Size")]
        [Range(0,6144)]
        public double SldStorageSize { get; set; }
        [Display(Name = "Use Solid State Drive")]
        public bool RadSSD { get; set; }
        [Display(Name = "Use Hard Drive")]
        public bool RadHDD { get; set; }
        [Display(Name = "Use Recommended RAM Size")]
        public bool RadRAMRecommended { get; set; }
        [Display(Name = "Force Manual RAM Size")]
        public bool RadRAMSelectManual { get; set; }
        [Display(Name = "Desired RAM Capacity")]
        [Range(2,32)]
        public double SldRamSize { get; set; }
        [Display(Name = "Number of CPU Cores")]
        [Range(2,8)]
        public double SldNumCores { get; set; }
        [Display(Name = "Full-Tower Case")]
        public bool RadCaseSizeFull { get; set; }
        [Display(Name = "Mid-Tower Case")]
        public bool RadCaseSizeMid { get; set; }
        [Display(Name = "Micro ATX Case")]
        public bool RadCaseSizeMicro { get; set; }
        [Display(Name = "Mini ITX Case")]
        public bool RadCaseSizeMini { get; set; }
        [Display(Name = "HTPC/Console Case")]
        public bool RadCaseSizeConsole { get; set; }
        [Display(Name = "BluRay Burner")]
        public bool RadBRBurner { get; set; }
        [Display(Name = "BluRay Reader")]
        public bool RadBRReader { get; set; }
        [Display(Name = "DVD Burner")]
        public bool RadDVDBurner { get; set; }
        [Display(Name = "No Optical")]
        public bool RadOpticalNone { get; set; }
    }
}