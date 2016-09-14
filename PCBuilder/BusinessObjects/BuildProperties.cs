using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    /// <summary>
    /// BuildProperties object to hold necessary data on the budget of the build.
    /// </summary>
    public class BuildProperties
    {
        public decimal CPUBudget { get; set; }
        public decimal GPUBudget { get; set; }
        public decimal MotherboardBudget { get; set; }
        public decimal OpticalBudget { get; set; }
        public decimal PSUBudget { get; set; }
        public decimal RAMBudget { get; set; }
        public decimal StorageBudget { get; set; }
    }
}
