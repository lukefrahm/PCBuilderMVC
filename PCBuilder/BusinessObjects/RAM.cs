/*
 * OBJECT FINALIZED
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    /// <summary>
    /// RAM object to hold necessary data on the RAM
    /// </summary>
    public class RAM
    {
        public int RamId { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int RamSize { get; set; }
        public int RamGeneration { get; set; }
        public int RamSpeed { get; set; }
        public string RamTimings { get; set; }
        public string BestUse { get; set; }
        public decimal Price { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="RAM"/> class.
        /// </summary>
        public RAM() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="RAM"/> class.
        /// </summary>
        /// <param name="ramId">The ram identifier.</param>
        /// <param name="brand">The brand.</param>
        /// <param name="model">The model.</param>
        /// <param name="ramSize">Size of the ram.</param>
        /// <param name="ramGeneration">The ram generation.</param>
        /// <param name="ramSpeed">The ram speed.</param>
        /// <param name="ramTimings">The ram timings.</param>
        /// <param name="price">The price.</param>
        public RAM (int ramId,
                    string brand,
                    string model,
                    int ramSize,
                    int ramGeneration,
                    int ramSpeed,
                    string ramTimings,
                    decimal price)
        {
            RamId = ramId;
            Brand = brand;
            Model = model;
            RamSize = ramSize;
            RamGeneration = ramGeneration;
            RamSpeed = ramSpeed;
            RamTimings = ramTimings;
            Price = price;
        }
    }
}
