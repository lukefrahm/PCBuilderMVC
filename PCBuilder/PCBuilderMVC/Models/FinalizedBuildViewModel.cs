using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PCBuilderMVC.Models
{
    /// <summary>
    /// Finalized build view model class.
    /// </summary>
    public class FinalizedBuildViewModel
    {
        [Key]
        public int FinalizedBuildID { get; set; }
        public CPU cpu { get; set; }
        public GPU gpu { get; set; }
        public Motherboard motherboard { get; set; }
        public Optical optical { get; set; }
        public PSU psu { get; set; }
        public RAM ram { get; set; }
        public Storage storage { get; set; }
        public string message { get; set; }
        public decimal price { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="FinalizedBuildViewModel"/> class.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="fb">The fb.</param>
        /// <remarks>
        /// This constructor serves the purpose of casting FinalizedBuild to FinalizedBuildViewModel
        /// </remarks>
        public FinalizedBuildViewModel(int id, BusinessObjects.FinalizedBuild fb)
        {
            FinalizedBuildID = id;
            #region cpu = fb.cpu;
            CPU c = new CPU();
            c.Brand = fb.cpu.Brand;
            c.Model = fb.cpu.Model;
            c.Cores = fb.cpu.Cores;
            c.HyperThreaded = fb.cpu.HyperThreaded;
            c.ClockSpeed = fb.cpu.ClockSpeed;
            c.Unlocked = fb.cpu.Unlocked;
            c.Socket = fb.cpu.Socket;
            c.ProductLineName = fb.cpu.ProductLineName;
            c.BenchmarkScore = fb.cpu.BenchmarkScore;
            c.BestUse = fb.cpu.BestUse;
            c.PowerRequirement = fb.cpu.PowerRequirement;
            c.Price = fb.cpu.Price;
            this.cpu = c;
            #endregion
            #region gpu = fb.gpu;
            GPU g = new GPU();
            g.Brand = fb.gpu.Brand;
            g.Model = fb.gpu.Model;
            g.ClockSpeed = fb.gpu.ClockSpeed;
            g.ProductLineName = fb.gpu.ProductLineName;
            g.BenchmarkScore = fb.gpu.BenchmarkScore;
            g.BestUse = fb.gpu.BestUse;
            g.GpuRamSize = fb.gpu.GpuRamSize;
            g.PciPinConnector1 = fb.gpu.PciPinConnector1 ?? 0;
            g.PciPinConnector2 = fb.gpu.PciPinConnector2 ?? 0;
            g.PciPinConnector3 = fb.gpu.PciPinConnector3 ?? 0;
            g.PowerRequirement = fb.gpu.PowerRequirement;
            g.GpuLength = fb.gpu.GpuLength.ToString();
            g.Price = fb.gpu.Price;
            this.gpu = g;
            #endregion
            #region motherboard = fb.motherboard;
            Motherboard m = new Motherboard();
            m.Brand = fb.motherboard.Brand;
            m.Model = fb.motherboard.Model;
            m.Socket = fb.motherboard.Socket;
            m.Chipset = fb.motherboard.Chipset;
            m.MaxRam = fb.motherboard.MaxRam;
            m.RamType = fb.motherboard.RamType;
            m.FormFactor = fb.motherboard.FormFactor;
            m.SataPorts = fb.motherboard.SataPorts;
            m.M2Slots = fb.motherboard.M2Slots;
            m.PowerPhases = fb.motherboard.PowerPhases;
            m.FanHeaders = fb.motherboard.FanHeaders;
            m.Pcie8 = fb.motherboard.Pcie8;
            m.Pcie4 = fb.motherboard.Pcie4;
            m.Pcie1 = fb.motherboard.Pcie1;
            m.Pci = fb.motherboard.Pci;
            m.Price = fb.motherboard.Price;
            this.motherboard = m;
            #endregion
            #region optical = fb.optical;
            Optical o = new Optical();
            o.Brand = fb.optical.Brand;
            o.Model = fb.optical.Model;
            o.OpticalType = fb.optical.OpticalType;
            o.Price = fb.optical.Price;
            this.optical = o;
            #endregion
            #region psu = fb.psu;
            PSU p = new PSU();
            p.Brand = fb.psu.Brand;
            p.Model = fb.psu.Model;
            p.Wattage = fb.psu.Wattage;
            p.Efficiency = fb.psu.Efficiency;
            p.Price = fb.psu.Price;
            this.psu = p;
            #endregion
            #region ram = fb.ram;
            RAM r = new RAM();
            r.Brand = fb.ram.Brand;
            r.Model = fb.ram.Model;
            r.RamSize = fb.ram.RamSize;
            r.RamGeneration = fb.ram.RamGeneration;
            r.RamSpeed = fb.ram.RamSpeed;
            r.RamTimings = fb.ram.RamTimings;
            r.BestUse = fb.ram.BestUse;
            r.Price = fb.ram.Price;
            this.ram = r;
            #endregion
            #region storage = fb.storage;
            Storage s = new Storage();
            s.Brand = fb.storage.Brand;
            s.Model = fb.storage.Model;
            s.StorageSize = fb.storage.StorageSize;
            s.StorageType = fb.storage.StorageType;
            s.BenchmarkScore = fb.storage.BenchmarkScore;
            s.StorageSequentialRead = fb.storage.StorageSequentialRead;
            s.StorageSequentialWrite = fb.storage.StorageSequentialWrite;
            s.StorageRandomRead = fb.storage.StorageRandomRead;
            s.StorageRandomWrite = fb.storage.StorageRandomWrite;
            s.BestUse = fb.storage.BestUse;
            s.Price = fb.storage.Price;
            this.storage = s;
            #endregion
            message = fb.message;
        }

        public FinalizedBuildViewModel()
        {
            message = "";
        }
    }
}