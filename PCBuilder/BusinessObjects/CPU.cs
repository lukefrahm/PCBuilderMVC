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
    /// CPU object to hold necessary data on the CPU.
    /// </summary>
    public class CPU
    {
        public int CpuId { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Cores { get; set; }
        public bool HyperThreaded { get; set; }
        public double ClockSpeed { get; set; }
        public bool Unlocked { get; set; }
        public string Socket { get; set; }
        public string ProductLineName { get; set; }
        public int BenchmarkScore { get; set; }
        public string BestUse { get; set; }
        public int PowerRequirement { get; set; }
        public decimal Price { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CPU"/> class.
        /// </summary>
        public CPU () { }

        /// <summary>
        /// Initializes a new instance of the <see cref="CPU"/> class.
        /// </summary>
        /// <param name="cpuId">The cpu identifier.</param>
        /// <param name="brand">The brand.</param>
        /// <param name="model">The model.</param>
        /// <param name="cores">The core count.</param>
        /// <param name="hyperThreaded">if set to <c>true</c>, [hyper threaded].</param>
        /// <param name="clockSpeed">The clock speed.</param>
        /// <param name="unlocked">if set to <c>true</c>, [unlocked].</param>
        /// <param name="socket">The socket.</param>
        /// <param name="productLineName">Name of the product line.</param>
        /// <param name="benchmarkScore">The benchmark score.</param>
        /// <param name="bestUse">The best use case.</param>
        /// <param name="powerRequirement">The power requirement.</param>
        /// <param name="price">The price.</param>
        public CPU (int cpuId,
                    string brand,
                    string model,
                    int cores,
                    bool hyperThreaded,
                    double clockSpeed,
                    bool unlocked,
                    string socket,
                    string productLineName,
                    int benchmarkScore,
                    string bestUse,
                    int powerRequirement,
                    decimal price)
        {
            CpuId = cpuId;
            Brand = brand;
            Model = model;
            Cores = cores;
            HyperThreaded = hyperThreaded;
            ClockSpeed = clockSpeed;
            Unlocked = unlocked;
            Socket = socket;
            ProductLineName = productLineName;
            BenchmarkScore = benchmarkScore;
            BestUse = bestUse;
            PowerRequirement = powerRequirement;
            Price = price;
        }
    }
}
