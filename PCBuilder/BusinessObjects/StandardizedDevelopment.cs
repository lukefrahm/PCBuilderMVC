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
    public class StandardizedDevelopment
    {
        public CPU cpu = new CPU();
        public GPU gpu = new GPU();
        public Motherboard motherboard = new Motherboard();
        public Optical optical = new Optical();
        public PSU psu = new PSU();
        public RAM ram = new RAM();
        public Storage storage = new Storage();

        /// <summary>
        /// Initializes a new instance of the <see cref="StandardizedDevelopment"/> class.
        /// </summary>
        /// <remarks>
        /// Default values are entered into the object at time of instantiation.
        /// </remarks>
        public StandardizedDevelopment()
        {
            this.cpu.Brand = "AMD";
            this.cpu.Model = "Athlon 860K";
            this.cpu.Price = 70.99M;

            this.gpu.Brand = "AMD";
            this.gpu.Model = "HD 6970";
            this.gpu.Price = 89.99M;

            this.motherboard.Brand = "MSI";
            this.motherboard.Model = "A78M-E35";
            this.motherboard.Price = 59.99M;

            this.optical.Brand = "Asus";
            this.optical.Model = "DRW-24B1ST";
            this.optical.Price = 19.99M;

            this.psu.Brand = "Corsair";
            this.psu.Model = "CX500";
            this.psu.Price = 52.39M;

            this.ram.Brand = "G.Skill";
            this.ram.Model = "F3-1600C9D-16GAR";
            this.ram.Price = 59.99M;

            this.storage.Brand = "OCZ";
            this.storage.Model = "TRN100-25SAT3-240G";
            this.storage.Price = 69.49M;
        }
    }
}
