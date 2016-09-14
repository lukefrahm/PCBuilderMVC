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
    /// PSU object to hold necessary data on the PSU.
    /// </summary>
    public class PSU
    {
        public int PsuId { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Wattage { get; set; }
        public string Efficiency { get; set; }
        public decimal Price { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="PSU"/> class.
        /// </summary>
        public PSU() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="PSU"/> class.
        /// </summary>
        /// <param name="psuId">The psu identifier.</param>
        /// <param name="brand">The brand.</param>
        /// <param name="model">The model.</param>
        /// <param name="wattage">The wattage.</param>
        /// <param name="efficiency">The efficiency.</param>
        /// <param name="price">The price.</param>
        public PSU (int psuId,
                    string brand,
                    string model,
                    int wattage,
                    string efficiency,
                    decimal price)
        {
            PsuId = psuId;
            Brand = brand;
            Model = model;
            Wattage = wattage;
            Efficiency = efficiency;
            Price = price;
        }
    }
}
