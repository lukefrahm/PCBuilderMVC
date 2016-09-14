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
    public class StandardizedVideoEditing
    {
        public CPU cpu = new CPU();
        public GPU gpu = new GPU();
        public Motherboard motherboard = new Motherboard();
        public Optical optical = new Optical();
        public PSU psu = new PSU();
        public RAM ram = new RAM();
        public Storage storage = new Storage();

        /// <summary>
        /// Initializes a new instance of the <see cref="StandardizedVideoEditing"/> class.
        /// </summary>
        /// <remarks>
        /// Default values are entered into the object at time of instantiation.
        /// </remarks>
        public StandardizedVideoEditing()
        {
            this.cpu.Brand = "Intel";
            this.cpu.Model = "i5-5820k";
            this.cpu.Price = 389.99M;

            this.gpu.Brand = "nVidia";
            this.gpu.Model = "GTX 970";
            this.gpu.Price = 329.99M;

            this.motherboard.Brand = "Gigabyte";
            this.motherboard.Model = "GA-X99-SLI";
            this.motherboard.Price = 199.99M;

            this.optical.Brand = "LG";
            this.optical.Model = "WH14NS40";
            this.optical.Price = 52.99M;

            this.psu.Brand = "EVGA";
            this.psu.Model = "110-B2-0750-VR";
            this.psu.Price = 68.99M;

            this.ram.Brand = "Corsair";
            this.ram.Model = "CMK32GX4M4A2666C15";
            this.ram.Price = 219.99M;

            this.storage.Brand = "Samsung";
            this.storage.Model = "MZ-75E2T0B";
            this.storage.Price = 699.99M;
        }
    }
}
