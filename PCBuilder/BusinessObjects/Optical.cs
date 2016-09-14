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
    /// Optical object to hold necessary data on the optical drive
    /// </summary>
    public class Optical
    {
        public int OpticalId { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string OpticalType { get; set; }
        public decimal Price { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Optical"/> class.
        /// </summary>
        public Optical() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="Optical"/> class.
        /// </summary>
        /// <param name="opticalId">The optical identifier.</param>
        /// <param name="brand">The brand.</param>
        /// <param name="model">The model.</param>
        /// <param name="opticalType">Type of the optical drive.</param>
        /// <param name="price">The price.</param>
        public Optical (int opticalId,
                        string brand,
                        string model,
                        string opticalType,
                        decimal price)
        {
            OpticalId = opticalId;
            Brand = brand;
            Model = model;
            OpticalType = opticalType;
            Price = price;
        }
    }
}
