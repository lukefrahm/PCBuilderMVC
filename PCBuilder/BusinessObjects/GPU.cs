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
    /// GPU object to hold necessary data on the GPU.
    /// </summary>
    public class GPU
    {
        public int GpuId { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public double ClockSpeed { get; set; }
        public string ProductLineName { get; set; }
        public int BenchmarkScore { get; set; }
        public string BestUse { get; set; }
        public int GpuRamSize { get; set; }
        public int? PciPinConnector1 { get; set; }
        public int? PciPinConnector2 { get; set; }
        public int? PciPinConnector3 { get; set; }
        public int PowerRequirement { get; set; }
        public char GpuLength { get; set; }
        public decimal Price { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="GPU"/> class.
        /// </summary>
        public GPU() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="GPU"/> class.
        /// </summary>
        /// <param name="gpuId">The GPU identifier.</param>
        /// <param name="brand">The brand.</param>
        /// <param name="model">The model.</param>
        /// <param name="clockSpeed">The clock speed.</param>
        /// <param name="productLineName">Name of the product line.</param>
        /// <param name="benchmarkScore">The benchmark score.</param>
        /// <param name="bestUse">The best use case.</param>
        /// <param name="gpuRamSize">Size of the GPU ram.</param>
        /// <param name="pciPinConnector1">The PCIe pin connector #1.</param>
        /// <param name="pciPinConnector2">The PCIe pin connector #2.</param>
        /// <param name="pciPinConnector3">The PCIe pin connector #3.</param>
        /// <param name="powerRequirement">The power requirement.</param>
        /// <param name="gpuLength">Length of the GPU.</param>
        /// <param name="price">The price.</param>
        public GPU( int gpuId,
                    string brand,
                    string model,
                    double clockSpeed,
                    string productLineName,
                    int benchmarkScore,
                    string bestUse,
                    int gpuRamSize,
                    int pciPinConnector1,
                    int pciPinConnector2,
                    int pciPinConnector3,
                    int powerRequirement,
                    char gpuLength,
                    decimal price)
        {
            GpuId = gpuId;
            Brand = brand;
            Model = model;
            ClockSpeed = clockSpeed;
            ProductLineName = productLineName;
            BenchmarkScore = benchmarkScore;
            BestUse = bestUse;
            GpuRamSize = gpuRamSize;
            PciPinConnector1 = pciPinConnector1;
            PciPinConnector2 = pciPinConnector2;
            PciPinConnector3 = pciPinConnector3;
            PowerRequirement = powerRequirement;
            GpuLength = gpuLength;
            Price = price;
        }
    }
}
