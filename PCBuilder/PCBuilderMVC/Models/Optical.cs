namespace PCBuilderMVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    /// <summary>
    /// Optical view model class.
    /// </summary>
    [Table("Optical")]
    public partial class Optical
    {
        public int OpticalId { get; set; }

        [Required]
        [StringLength(10)]
        public string Brand { get; set; }

        [Required]
        [StringLength(25)]
        public string Model { get; set; }

        [Required]
        [StringLength(15)]
        public string OpticalType { get; set; }

        public decimal Price { get; set; }
    }
}
