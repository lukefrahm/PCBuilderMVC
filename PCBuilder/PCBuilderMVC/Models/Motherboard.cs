namespace PCBuilderMVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    /// <summary>
    /// Motherboard view model class.
    /// </summary>
    [Table("Motherboard")]
    public partial class Motherboard
    {
        public int MotherboardId { get; set; }

        [Required]
        [StringLength(10)]
        public string Brand { get; set; }

        [Required]
        [StringLength(25)]
        public string Model { get; set; }

        [Required]
        [StringLength(25)]
        public string Socket { get; set; }

        [Required]
        [StringLength(25)]
        public string Chipset { get; set; }

        public int MaxRam { get; set; }

        public int RamType { get; set; }

        [Required]
        [StringLength(10)]
        public string FormFactor { get; set; }

        public int SataPorts { get; set; }

        public int M2Slots { get; set; }

        public int PowerPhases { get; set; }

        public int FanHeaders { get; set; }

        public int Pcie8 { get; set; }

        public int Pcie4 { get; set; }

        public int Pcie1 { get; set; }

        public int Pci { get; set; }

        public decimal Price { get; set; }
    }
}
