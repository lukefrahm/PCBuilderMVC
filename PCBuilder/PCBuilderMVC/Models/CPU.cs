namespace PCBuilderMVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    /// <summary>
    /// CPU view model class.
    /// </summary>
    [Table("CPU")]
    public partial class CPU
    {
        public int CpuId { get; set; }

        [Required]
        [StringLength(10)]
        public string Brand { get; set; }

        [Required]
        [StringLength(25)]
        public string Model { get; set; }

        public int Cores { get; set; }

        public bool HyperThreaded { get; set; }

        public double ClockSpeed { get; set; }

        public bool Unlocked { get; set; }

        [Required]
        [StringLength(25)]
        public string Socket { get; set; }

        [Required]
        [StringLength(25)]
        public string ProductLineName { get; set; }

        public int BenchmarkScore { get; set; }

        [Required]
        [StringLength(50)]
        public string BestUse { get; set; }

        public int PowerRequirement { get; set; }

        public decimal Price { get; set; }
    }
}
