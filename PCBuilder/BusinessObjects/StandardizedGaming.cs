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
    public class StandardizedGaming
    {
        public CPU cpu = new CPU();
        public GPU gpu = new GPU();
        public Motherboard motherboard = new Motherboard();
        public Optical optical = new Optical();
        public PSU psu = new PSU();
        public RAM ram = new RAM();
        public Storage storage = new Storage();

        /// <summary>
        /// Initializes a new instance of the <see cref="StandardizedGaming"/> class.
        /// </summary>
        /// <remarks>
        /// Default values are entered into the object at time of instantiation.
        /// </remarks>
        public StandardizedGaming()
        {
            this.cpu.Brand = "Intel";
            this.cpu.Model = "i5-4670k";
            this.cpu.Price = 254.99M;

            this.gpu.Brand = "nVidia";
            this.gpu.Model = "GTX 970";
            this.gpu.Price = 329.99M;

            this.motherboard.Brand = "Gigabyte";
            this.motherboard.Model = "GA-Z97X-UD3H";
            this.motherboard.Price = 124.99M;

            this.optical.Brand = "No optical needed";
            this.optical.Model = "";
            this.optical.Price = 0;

            this.psu.Brand = "EVGA";
            this.psu.Model = "110-B2-0750-VR";
            this.psu.Price = 68.99M;

            this.ram.Brand = "G.Skill";
            this.ram.Model = "F3-1600C9D-16GAR";
            this.ram.Price = 59.99M;

            this.storage.Brand = "Mushkin";
            this.storage.Model = "MKNSSDCR480GB-7-A";
            this.storage.Price = 139.99M;
        }
    }
}
