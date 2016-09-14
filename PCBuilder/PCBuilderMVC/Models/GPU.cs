namespace PCBuilderMVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    /// <summary>
    /// GPU view model class.
    /// </summary>
    [Table("GPU")]
    public partial class GPU
    {
        public int GpuId { get; set; }

        [Required]
        [StringLength(10)]
        public string Brand { get; set; }

        [Required]
        [StringLength(25)]
        public string Model { get; set; }

        public double ClockSpeed { get; set; }

        [Required]
        [StringLength(25)]
        public string ProductLineName { get; set; }

        public int BenchmarkScore { get; set; }

        [Required]
        [StringLength(50)]
        public string BestUse { get; set; }

        public int GpuRamSize { get; set; }

        public int PciPinConnector1 { get; set; }

        public int PciPinConnector2 { get; set; }

        public int PciPinConnector3 { get; set; }

        public int PowerRequirement { get; set; }

        [Required]
        [StringLength(1)]
        public string GpuLength { get; set; }

        public decimal Price { get; set; }
    }
}
