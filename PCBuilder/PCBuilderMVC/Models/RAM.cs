namespace PCBuilderMVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    /// <summary>
    /// RAM view model class.
    /// </summary>
    [Table("RAM")]
    public partial class RAM
    {
        public int RamId { get; set; }

        [Required]
        [StringLength(10)]
        public string Brand { get; set; }

        [Required]
        [StringLength(25)]
        public string Model { get; set; }

        public int RamSize { get; set; }

        public int RamGeneration { get; set; }

        public int RamSpeed { get; set; }

        [Required]
        [StringLength(15)]
        public string RamTimings { get; set; }

        [Required]
        [StringLength(50)]
        public string BestUse { get; set; }

        public decimal Price { get; set; }
    }
}
