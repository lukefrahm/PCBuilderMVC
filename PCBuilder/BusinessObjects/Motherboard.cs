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
    /// Motherboard object to hold necessary data on the motherboard.
    /// </summary>
    public class Motherboard
    {
        public int MotherboardId { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Socket { get; set; }
        public string Chipset { get; set; }
        public int MaxRam { get; set; }
        public int RamType { get; set; }
        public string FormFactor { get; set; }
        public int SataPorts { get; set; }
        public int M2Slots { get; set; }
        public int PowerPhases { get; set; }
        public int FanHeaders { get; set; }
        public int Pcie16 { get; set; }
        public int Pcie8 { get; set; }
        public int Pcie4 { get; set; }
        public int Pcie1 { get; set; }
        public int Pci { get; set; }
        public decimal Price { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Motherboard"/> class.
        /// </summary>
        public Motherboard() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="Motherboard"/> class.
        /// </summary>
        /// <param name="motherboardId">The motherboard identifier.</param>
        /// <param name="brand">The brand.</param>
        /// <param name="model">The model.</param>
        /// <param name="socket">The socket.</param>
        /// <param name="chipset">The chipset.</param>
        /// <param name="maxRam">The maximum ram.</param>
        /// <param name="ramType">Type of the ram.</param>
        /// <param name="formFactor">The form factor.</param>
        /// <param name="sataPorts">The number of SATA ports.</param>
        /// <param name="m2Slots">The number of M.2 slots.</param>
        /// <param name="powerPhases">The number of power phases.</param>
        /// <param name="fanHeaders">The number of fan headers.</param>
        /// <param name="pcie16">The number of PCIe x16 slots.</param>
        /// <param name="pcie8">The number of PCIe x8 slots.</param>
        /// <param name="pcie4">The number of PCIe x4 slots.</param>
        /// <param name="pcie1">The number of PCIe x1 slots.</param>
        /// <param name="pci">The number of PCI slots.</param>
        /// <param name="price">The price.</param>
        public Motherboard(int motherboardId,
                           string brand,
                           string model,
                           string socket,
                           string chipset,
                           int maxRam,
                           int ramType,
                           string formFactor,
                           int sataPorts,
                           int m2Slots,
                           int powerPhases,
                           int fanHeaders,
                           int pcie16,
                           int pcie8,
                           int pcie4,
                           int pcie1,
                           int pci,
                           decimal price)
        {
            MotherboardId = motherboardId;
            Brand = brand;
            Model = model;
            Socket = socket;
            Chipset = chipset;
            MaxRam = maxRam;
            RamType = ramType;
            FormFactor = formFactor;
            SataPorts = sataPorts;
            M2Slots = m2Slots;
            PowerPhases = powerPhases;
            FanHeaders = fanHeaders;
            Pcie16 = pcie16;
            Pcie8 = pcie8;
            Pcie4 = pcie4;
            Pcie1 = pcie1;
            Pci = pci;
            Price = price;
        }
    }
}
