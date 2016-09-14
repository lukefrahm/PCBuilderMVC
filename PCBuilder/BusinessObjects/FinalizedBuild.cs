using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    /// <summary>
    /// FinalizedBuild object to hold necessary data on the final build after processing
    /// </summary>
    public class FinalizedBuild
    {
        public CPU cpu { get; set; }
        public GPU gpu { get; set; }
        public Motherboard motherboard { get; set; }
        public Optical optical { get; set; }
        public PSU psu { get; set; }
        public RAM ram { get; set; }
        public Storage storage { get; set; }
        public string message { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="FinalizedBuild"/> class.
        /// </summary>
        /// <remarks>
        /// Message is defaulted to an empty string.
        /// </remarks>
        public FinalizedBuild()
        {
            message = "";
        }
    }
}
