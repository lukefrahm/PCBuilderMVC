namespace PCBuilderMVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    /// <summary>
    /// Storage view model class.
    /// </summary>
    [Table("Storage")]
    public partial class Storage
    {
        public int StorageId { get; set; }

        [Required]
        [StringLength(10)]
        public string Brand { get; set; }

        [Required]
        [StringLength(25)]
        public string Model { get; set; }

        public int StorageSize { get; set; }

        [Required]
        [StringLength(5)]
        public string StorageType { get; set; }

        public int BenchmarkScore { get; set; }

        public int StorageSequentialRead { get; set; }

        public int StorageSequentialWrite { get; set; }

        public int StorageRandomRead { get; set; }

        public int StorageRandomWrite { get; set; }

        [Required]
        [StringLength(50)]
        public string BestUse { get; set; }

        public decimal Price { get; set; }
    }
}
