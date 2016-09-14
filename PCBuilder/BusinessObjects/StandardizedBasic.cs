using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    /// <summary>
    /// Build object to hold necessary data on a Video Editing build.
    /// </summary>
    /// <remarks>
    /// This is used as a contingency build if user requests are far too outlandish to create an acceptable build.
    /// </remarks>
    public class StandardizedBasic
    {
        public CPU cpu = new CPU();
        public GPU gpu = new GPU();
        public Motherboard motherboard = new Motherboard();
        public Optical optical = new Optical();
        public PSU psu = new PSU();
        public RAM ram = new RAM();
        public Storage storage = new Storage();

        /// <summary>
        /// Initializes a new instance of the <see cref="StandardizedBasic"/> class.
        /// </summary>
        /// <remarks>
        /// Default values are entered into the object at time of instantiation.
        /// </remarks>
        public StandardizedBasic()
        {
            this.cpu.Brand = "Intel";
            this.cpu.Model = "g1820";
            this.cpu.Price = 69.99M;

            this.gpu.Brand = "No GPU needed";
            this.gpu.Model = "";
            this.gpu.Price = 0;

            this.motherboard.Brand = "MSI";
            this.motherboard.Model = "H81M-P33";
            this.motherboard.Price = 45.99M;

            this.optical.Brand = "No optical needed";
            this.optical.Model = "";
            this.optical.Price = 0;

            this.psu.Brand = "Lepa";
            this.psu.Model = "MX-F1N350-SB";
            this.psu.Price = 29.99M;

            this.ram.Brand = "G.Skill";
            this.ram.Model = "F3-12800CL9D-8GBXL";
            this.ram.Price = 42.99M;

            this.storage.Brand = "Seagate";
            this.storage.Model = "ST3250312AS";
            this.storage.Price = 19.99M;
        }
    }
}
