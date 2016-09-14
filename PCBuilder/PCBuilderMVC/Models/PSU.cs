namespace PCBuilderMVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    /// <summary>
    /// PSU view model class.
    /// </summary>
    [Table("PSU")]
    public partial class PSU
    {
        public int PsuId { get; set; }

        [Required]
        [StringLength(10)]
        public string Brand { get; set; }

        [Required]
        [StringLength(25)]
        public string Model { get; set; }

        public int Wattage { get; set; }

        [Required]
        [StringLength(10)]
        public string Efficiency { get; set; }

        public decimal Price { get; set; }
    }
}
