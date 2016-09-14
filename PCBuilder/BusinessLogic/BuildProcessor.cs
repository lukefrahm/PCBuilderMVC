using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;
using DataAccess;

namespace BusinessLogic
{
    /// <summary>
    /// Clas tasked with processing of questionnaire data to build a system.
    /// </summary>
    public class BuildProcessor : IBuildProcessor
    {
        #region Instance Variables
        QuestionnaireResults userNeeds = new QuestionnaireResults();
        BuildProperties bp = new BuildProperties();
        FinalizedBuild fb = new FinalizedBuild();

        private const decimal baseDelta = 0M;
        decimal budget;
        string opticalType;

        List<CPU> allCPU;
        List<GPU> allGPU;
        List<Motherboard> allMotherboards;
        List<RAM> allRAM;
        List<Storage> allStorage;
        List<PSU> allPSU;
        List<Optical> opticalByType;

        List<CPU> preliminaryCPU = new List<CPU>();
        List<GPU> preliminaryGPU = new List<GPU>();
        List<Motherboard> preliminaryMotherboards = new List<Motherboard>();
        List<RAM> preliminaryRAM = new List<RAM>();
        List<Storage> preliminaryStorage = new List<Storage>();
        List<PSU> preliminaryPSU = new List<PSU>();

        CPU CPUChoice = new CPU();
        GPU GPUChoice = new GPU();
        Motherboard motherboardChoice = new Motherboard();
        RAM RAMChoice = new RAM(), RAMPreliminary = new RAM();
        Storage storageChoice = new Storage();
        PSU PSUChoice = new PSU();
        Optical opticalChoice = new Optical();
        #endregion

        /// <summary>
        /// Public base method that calls needed methods to complete build.
        /// </summary>
        /// <param name="qr">The questionnaire data.</param>
        /// <returns>FinalizedBuild with all build components.</returns>
        public FinalizedBuild DataBuilder(QuestionnaireResults qr)
        {
            userNeeds = qr;
            budget = (decimal)userNeeds.SldPerformance;
            CreateAllComponentLists();
            BuildProportioning();

            CPUChoicesByUserNeeds(baseDelta);
            FinalCPU();
            GPUChoicesByUserNeeds(baseDelta);
            FinalGPU();
            MotherboardChoicesByUserNeeds(baseDelta);
            FinalMotherboard();
            RAMChoicesByUserNeeds(baseDelta);
            FinalRAM();
            StorageChoicesByUserNeeds(baseDelta);
            FinalStorage();
            PSUChoicesByUserNeeds(baseDelta);
            FinalPSU();
            FinalOptical();

            CreateFinalizedBuild();

            FinalErrorCheck();

            return fb;
        }

        /// <summary>
        /// Validates the build before returning to ensure all components are correct.
        /// </summary>
        /// <remarks>
        /// This method calls the ContingencyBuilder and passes the results of the tests.
        /// </remarks>
        private void FinalErrorCheck()
        {
            if ((fb.cpu == null || fb.motherboard == null || fb.psu == null || fb.ram == null || fb.storage == null)
                    || (fb.gpu == null && (userNeeds.ChkUseGaming || userNeeds.ChkUseVideoEdit))
                    || (opticalType != "None" && (userNeeds.RadBRBurner || userNeeds.RadBRReader || userNeeds.RadDVDBurner) && opticalChoice == null)
               )
            {
                bool majorFault = false, needsGPU = false, needsOptical = false;
                if (fb.cpu == null || fb.motherboard == null || fb.psu == null || fb.ram == null || fb.storage == null)
                {
                    majorFault = true;
                }
                if (fb.gpu == null && (userNeeds.ChkUseGaming || userNeeds.ChkUseVideoEdit))
                {
                    needsGPU = true;
                }
                if (opticalType != "None" && (userNeeds.RadBRBurner || userNeeds.RadBRReader || userNeeds.RadDVDBurner))
                {
                    needsOptical = true;
                }

                ContingencyBuilder(majorFault, needsGPU, needsOptical);
            }
        }

        /// <summary>
        /// Selects the final choice for the optical drive.
        /// </summary>
        private void FinalOptical()
        {
            if (!userNeeds.RadOpticalNone)
            {
                decimal price = decimal.MaxValue;
                foreach (var part in opticalByType)
                {
                    if (price > part.Price)
                    {
                        opticalChoice = part;
                    }
                }
            }
        }

        /// <summary>
        /// Takes fault results from FinalErrorCheck and processes for problems.
        /// </summary>
        /// <param name="majorFault">if set to <c>true</c>, [major fault]. Represents a significant problem with the build.</param>
        /// <param name="needsGPU">if set to <c>true</c> [needs gpu]. Represents the build does not have a processor capable of on-die graphics. A GPU must be selected.</param>
        /// <param name="needsOptical">if set to <c>true</c> [needs optical]. Represents a fault of not being able to pull an applicable optical drive.</param>
        private void ContingencyBuilder(bool majorFault, bool needsGPU, bool needsOptical)
        {
            if (majorFault)
            {
                fb.message += "The needs you selected did not match to a computer that will serve you the best. ";
                if (userNeeds.ChkUseBasic)
                {
                    var standardized = new StandardizedBasic();
                    fb.cpu = standardized.cpu;
                    fb.gpu = standardized.gpu;
                    fb.motherboard = standardized.motherboard;
                    fb.optical = standardized.optical;
                    fb.psu = standardized.psu;
                    fb.ram = standardized.ram;
                    fb.storage = standardized.storage;
                }
                else if (userNeeds.ChkUseOfficeModerate)
                {
                    var standardized = new StandardizedOffice();
                    fb.cpu = standardized.cpu;
                    fb.gpu = standardized.gpu;
                    fb.motherboard = standardized.motherboard;
                    fb.optical = standardized.optical;
                    fb.psu = standardized.psu;
                    fb.ram = standardized.ram;
                    fb.storage = standardized.storage;
                }
                else if (userNeeds.ChkUseDevelopment)
                {
                    var standardized = new StandardizedDevelopment();
                    fb.cpu = standardized.cpu;
                    fb.gpu = standardized.gpu;
                    fb.motherboard = standardized.motherboard;
                    fb.optical = standardized.optical;
                    fb.psu = standardized.psu;
                    fb.ram = standardized.ram;
                    fb.storage = standardized.storage;
                }
                else if (userNeeds.ChkUseGaming)
                {
                    var standardized = new StandardizedGaming();
                    fb.cpu = standardized.cpu;
                    fb.gpu = standardized.gpu;
                    fb.motherboard = standardized.motherboard;
                    fb.optical = standardized.optical;
                    fb.psu = standardized.psu;
                    fb.ram = standardized.ram;
                    fb.storage = standardized.storage;
                }
                else if (userNeeds.ChkUseVideoEdit)
                {
                    var standardized = new StandardizedVideoEditing();
                    fb.cpu = standardized.cpu;
                    fb.gpu = standardized.gpu;
                    fb.motherboard = standardized.motherboard;
                    fb.optical = standardized.optical;
                    fb.psu = standardized.psu;
                    fb.ram = standardized.ram;
                    fb.storage = standardized.storage;
                }
            }
            if (needsGPU)
            {
                fb.message += "No GPU fit your needs and budget. A GPU most suitable for your needs has been added, but may not tightly adhere to your budget. ";
                if (userNeeds.ChkUseGaming)
                {
                    fb.gpu = new StandardizedGaming().gpu;
                }
                if (userNeeds.ChkUseVideoEdit)
                {
                    fb.gpu = new StandardizedVideoEditing().gpu;
                }
            }
            if (needsOptical)
            {
                fb.message += "Error finding a suitable optical drive for your needs. ";
            }
        }

        /// <summary>
        /// Creates the finalized build from all final choice methods.
        /// </summary>
        private void CreateFinalizedBuild()
        {
            fb.cpu = CPUChoice;
            fb.gpu = GPUChoice;
            fb.motherboard = motherboardChoice;
            fb.optical = opticalChoice;
            fb.psu = PSUChoice;
            fb.ram = RAMChoice;
            fb.storage = storageChoice;
        }

        /// <summary>
        /// Chooses potential CPUs by user needs.
        /// </summary>
        /// <param name="delta">The price delta. Used for recursion to increasingly expand the price delta.</param>
        private void CPUChoicesByUserNeeds(decimal delta)
        {
            foreach (var part in allCPU)
            {
                if (part.Price > (bp.CPUBudget * (1 - delta)) && part.Price < (bp.CPUBudget * (1 + delta)) && part.Cores >= userNeeds.SldNumCores)
                {
                    preliminaryCPU.Add(part);
                }
            }

            if (preliminaryCPU.Count < 3)
            {
                CPUChoicesByUserNeeds(delta + .05M);
            }
        }

        /// <summary>
        /// Selects the final choice for the CPU.
        /// </summary>
        private void FinalCPU()
        {
            decimal performancePriceRatio = 0;
            foreach (var part in preliminaryCPU)
            {
                if (performancePriceRatio < (part.BenchmarkScore / part.Price))
                {
                    CPUChoice = part;
                    performancePriceRatio = part.Price;
                }
            }
        }

        /// <summary>
        /// Chooses potential GPUs by user needs.
        /// </summary>
        /// <param name="delta">The price delta. Used for recursion to increasingly expand the price delta.</param>
        private void GPUChoicesByUserNeeds(decimal delta)
        {
            foreach (var part in allGPU)
            {
                if (part.Price > (bp.GPUBudget * (1 - delta)) && part.Price < (bp.GPUBudget * (1 + delta)))
                {
                    preliminaryGPU.Add(part);
                }
            }

            if (preliminaryGPU.Count < 3)
            {
                if (delta <= 1 && (userNeeds.ChkUseGaming || userNeeds.ChkUseVideoEdit))
                {
                    GPUChoicesByUserNeeds(delta + .05M);
                }
            }
        }

        /// <summary>
        /// Selects the final choice for the GPU.
        /// </summary>
        private void FinalGPU()
        {
            decimal performancePriceRatio = 0;
            foreach (var part in preliminaryGPU)
            {
                if (performancePriceRatio < (part.BenchmarkScore / part.Price))
                {
                    GPUChoice = part;
                }
            }
            if (CPUChoice.Socket == "AM3+" && GPUChoice.Model == null)
            {
                GPUChoice = DataAccess.GPUAccessor.RetrieveGPUByName("HD 5450");
            }
        }

        /// <summary>
        /// Chooses potential motherboards by user needs.
        /// </summary>
        /// <remarks>
        /// This must be called after the FinalCPU method. Not doing so will cause incompatibilities between the CPU and motherboard.
        /// </remarks>
        /// <param name="delta">The price delta. Used for recursion to increasingly expand the price delta.</param>
        private void MotherboardChoicesByUserNeeds(decimal delta)
        {
            foreach (var part in allMotherboards)
            {
                if (part.Socket == CPUChoice.Socket)
                {
                    if (part.Price > (bp.MotherboardBudget * (1 - delta)) && part.Price < (bp.MotherboardBudget * (1 + delta)))
                    {
                        preliminaryMotherboards.Add(part);
                    }
                }
            }

            if (preliminaryMotherboards.Count < 3)
            {
                if (delta <= 1)
                {
                    MotherboardChoicesByUserNeeds(delta + .05M);
                }
            }
        }

        /// <summary>
        /// Selects the final choice for the motherboard.
        /// </summary>
        private void FinalMotherboard()
        {
            decimal price = decimal.MaxValue;
            int pf = 0;
            foreach (var part in preliminaryMotherboards)
            {
                if (userNeeds.ChkUseBasic == true || userNeeds.ChkUseOfficeModerate == true || userNeeds.ChkUseDevelopment == true)
                {
                    if (part.Price < price)
                    {
                        motherboardChoice = part;
                        price = part.Price;
                    }
                }
                else
                {
                    if (part.Pcie16 >= 1 || part.Pcie8 >= 1)
                    {
                        if (part.PowerPhases >= pf)
                        {
                            motherboardChoice = part;
                        }
                    }
                }
            }

            if (motherboardChoice.Brand == null)
            {
                price = decimal.MaxValue;
                foreach (var part in preliminaryMotherboards)
                {
                    if (part.Price < price)
                    {
                        motherboardChoice = part;
                        price = part.Price;
                    }
                }
            }
        }

        /// <summary>
        /// Chooses portential RAM modules by user needs.
        /// </summary>
        /// <remarks>
        /// This must be called after the FinalMotherboard method. Not doing so will cause incompatibilities bwtween the motherboard and RAM.
        /// </remarks>
        /// <param name="delta">The price delta. Used for recursion to increasingly expand the price delta.</param>
        private void RAMChoicesByUserNeeds(decimal delta)
        {
            if (userNeeds.RadRAMRecommended)
            {
                foreach (var part in allRAM)
                {
                    if (part.RamGeneration == motherboardChoice.RamType)
                    {
                        if (part.Price > (bp.RAMBudget * (1 - delta)) && part.Price < (bp.RAMBudget * (1 + delta)))
                        {
                            preliminaryRAM.Add(part);
                        }
                    }
                }
                if (preliminaryRAM.Count < 3)
                {
                    RAMChoicesByUserNeeds(delta + .05M);
                }
            }
            else
            {
                foreach (var part in allRAM)
                {
                    if (part.RamGeneration == motherboardChoice.RamType)
                    {
                        if (part.Price > (bp.RAMBudget * (1 - delta)) && part.Price < (bp.RAMBudget * (1 + delta)) && part.RamSize >= userNeeds.SldRamSize)
                        {
                            preliminaryRAM.Add(part);
                        }
                    }
                }
                if (preliminaryRAM.Count < 3 && delta <= 1)
                {
                    RAMChoicesByUserNeeds(delta + .05M);
                }
                else
                {
                    if (preliminaryRAM.Count == 0)
                    {
                        decimal price = decimal.MaxValue;
                        foreach (var part in allRAM)
                        {
                            if (part.RamSize >= userNeeds.SldRamSize)
                            {
                                preliminaryRAM.Add(part);
                                fb.message += "No RAM found matching entered needs; compatible RAM of the size requested is selected, but may not adhere to set budget.";
                            }
                        }
                        foreach (var part in preliminaryRAM)
                        {
                            if (part.Price < price)
                            {
                                RAMPreliminary = part;
                                price = part.Price;
                            }
                        }
                        preliminaryRAM.Clear();
                        preliminaryRAM.Add(RAMPreliminary);
                    }
                }
            }
        }

        /// <summary>
        /// Selects the final choice for the RAM
        /// </summary>
        private void FinalRAM()
        {
            decimal price = decimal.MaxValue;
            foreach (var part in preliminaryRAM)
            {
                if (part.RamSize >= userNeeds.SldRamSize)
                {
                    if (part.Price < price)
                    {
                        RAMChoice = part;
                        price = part.Price;
                    }
                }
            }

            if (RAMChoice.Brand == null)
            {
                price = decimal.MaxValue;
                foreach (var part in preliminaryRAM)
                {
                    if (part.Price < price)
                    {
                        RAMChoice = part;
                        price = part.Price;
                    }
                }
            }
        }

        /// <summary>
        /// Chooses potential storage candidates by user needs.
        /// </summary>
        /// <remarks>
        /// The method differentiates between HDD and SSD based on the user's needs.
        /// </remarks>
        /// <param name="delta">The price delta. Used for recursion to increasingly expand the price delta.</param>
        private void StorageChoicesByUserNeeds(decimal delta)
        {
            if (userNeeds.RadHDD)
            {
                foreach (var part in allStorage)
                {
                    if (part.Price > (bp.StorageBudget * (1 - delta)) && part.Price < (bp.StorageBudget * (1 + delta)) && part.StorageType == "HDD" && part.StorageSize >= userNeeds.SldStorageSize)
                    {
                        preliminaryStorage.Add(part);
                    }
                }

            }
            else
            {
                foreach (var part in allStorage)
                {
                    if (part.Price > (bp.StorageBudget * (1 - delta)) && part.Price < (bp.StorageBudget * (1 + delta)) && part.StorageType == "SSD" && part.StorageSize >= userNeeds.SldStorageSize)
                    {
                        preliminaryStorage.Add(part);
                    }
                }
            }

            if (preliminaryStorage.Count < 3 && delta <= 1)
            {
                StorageChoicesByUserNeeds(delta + .05M);
            }
            else
            {
                if (preliminaryStorage.Count == 0)
                {
                    fb.message += "No storage device met the supplied criteria. A drive matching the size you requested has been added, but may not be the same technology. ";
                    foreach (var part in allStorage)
                    {
                        if (part.StorageSize >= userNeeds.SldStorageSize)
                        {
                            preliminaryStorage.Add(part);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Selects the final choice for the storage.
        /// </summary>
        /// <remarks>
        /// This method takes into account the use case for the user. If the user needs high performance, an SSD is selected.
        /// </remarks>
        private void FinalStorage()
        {
            decimal performancePriceRatio = 0;
            if (userNeeds.ChkUseGaming || userNeeds.ChkUseVideoEdit)
            {
                foreach (var part in preliminaryStorage)
                {
                    if (part.StorageType == "SSD")
                    {
                        if ((part.BenchmarkScore / part.Price) > performancePriceRatio)
                        {
                            performancePriceRatio = part.BenchmarkScore / part.Price;
                            storageChoice = part;
                        }
                    }
                }
                if (storageChoice.Brand == null)
                {
                    performancePriceRatio = 0;
                    foreach (var part in preliminaryStorage)
                    {
                        if ((part.BenchmarkScore / part.Price) > performancePriceRatio)
                        {
                            performancePriceRatio = part.BenchmarkScore / part.Price;
                            storageChoice = part;
                        }
                    }
                }
            }
            else
            {
                foreach (var part in preliminaryStorage)
                {
                    if ((part.BenchmarkScore / part.Price) > performancePriceRatio)
                    {
                        performancePriceRatio = part.BenchmarkScore / part.Price;
                        storageChoice = part;
                    }
                }
            }
        }

        /// <summary>
        /// Chooses potential PSUsby user needs.
        /// </summary>
        /// <remarks>
        /// This method must be done last in the build process. Not doing so can result in an inadequate power supply being selected.
        /// </remarks>
        /// <param name="delta">The price delta. Used for recursion to increasingly expand the price delta.</param>
        private void PSUChoicesByUserNeeds(decimal delta)
        {
            int gpuPower = 0;
            if (GPUChoice != null)
            {
                gpuPower = GPUChoice.PowerRequirement;
            }
            double powerUsage = (CPUChoice.PowerRequirement + gpuPower) * 1.5;
            foreach (var part in allPSU)
            {
                if (part.Wattage >= powerUsage)
                {
                    preliminaryPSU.Add(part);
                }
            }

            if (preliminaryPSU.Count < 3)
            {
                PSUChoicesByUserNeeds(delta + .05M);
            }
        }

        /// <summary>
        /// Selects the final choice for the PSU.
        /// </summary>
        private void FinalPSU()
        {
            decimal performancePriceRatio = 0;
            foreach (var part in preliminaryPSU)
            {
                if ((part.Wattage / part.Price) > performancePriceRatio)
                {
                    performancePriceRatio = part.Wattage / part.Price;
                    PSUChoice = part;
                }
            }
        }

        /// <summary>
        /// Creates budget proportions based on standardized build needs. Different use cases require different budget allocations for different parts.
        /// </summary>
        private void BuildProportioning()
        {
            if (userNeeds.ChkUseVideoEdit)
            {
                bp.CPUBudget = .275M * budget;
                bp.GPUBudget = .235M * budget;
                bp.MotherboardBudget = .215M * budget;
                bp.OpticalBudget = .015M * budget;
                bp.PSUBudget = .05M * budget;
                bp.RAMBudget = .12M * budget;
                bp.StorageBudget = .09M * budget;
            }
            else if (userNeeds.ChkUseGaming == true)
            {
                bp.CPUBudget = .32M * budget;
                bp.GPUBudget = .25M * budget;
                bp.MotherboardBudget = .18M * budget;
                bp.OpticalBudget = .025M * budget;
                bp.PSUBudget = .0725M * budget;
                bp.RAMBudget = .0625M * budget;
                bp.StorageBudget = .09M * budget;
            }
            else if (userNeeds.ChkUseDevelopment == true)
            {
                bp.CPUBudget = .20M * budget;
                bp.GPUBudget = .24M * budget;
                bp.MotherboardBudget = .14M * budget;
                bp.OpticalBudget = .05M * budget;
                bp.PSUBudget = .10M * budget;
                bp.RAMBudget = .12M * budget;
                bp.StorageBudget = .15M * budget;
            }
            else if (userNeeds.ChkUseOfficeModerate == true)
            {
                if (budget < 350M)
                {
                    bp.CPUBudget = .25M * budget;
                    bp.GPUBudget = 0.00M * budget;
                    bp.MotherboardBudget = .20M * budget;
                    bp.OpticalBudget = .07M * budget;
                    bp.PSUBudget = .14M * budget;
                    bp.RAMBudget = .14M * budget;
                    bp.StorageBudget = .20M * budget;
                }
                else
                {
                    bp.CPUBudget = .20M * budget;
                    bp.GPUBudget = .25M * budget;
                    bp.MotherboardBudget = .15M * budget;
                    bp.OpticalBudget = .05M * budget;
                    bp.PSUBudget = .10M * budget;
                    bp.RAMBudget = .10M * budget;
                    bp.StorageBudget = .15M * budget;
                }
            }
            else if (userNeeds.ChkUseBasic == true)
            {
                bp.CPUBudget = .25M * budget;
                bp.GPUBudget = 0.00M * budget;
                bp.MotherboardBudget = .20M * budget;
                bp.OpticalBudget = .07M * budget;
                bp.PSUBudget = .14M * budget;
                bp.RAMBudget = .14M * budget;
                bp.StorageBudget = .20M * budget;
            }

        }

        /// <summary>
        /// Creates all component lists for each component.
        /// </summary>
        /// <remarks>
        /// Special attention is needed for the optical type, so the stored procedure can pull the applicable types of ddrives only.</remarks>
        private void CreateAllComponentLists()
        {
            #region opticalType selection
            if (userNeeds.RadOpticalNone == true)
            {
                opticalType = "None";
            }
            else if (userNeeds.RadBRBurner == true)
            {
                opticalType = "BluRay Burner";
            }
            else if (userNeeds.RadBRReader == true)
            {
                opticalType = "BluRay Reader";
            }
            else
            {
                opticalType = "DVD Burner";
            }
            if (opticalType != "None")
            {
                opticalByType = OpticalAccessor.RetrieveOpticalsByType(opticalType);
            }
            #endregion
            allCPU = CPUAccessor.RetrieveAllCPU();
            allGPU = GPUAccessor.RetrieveAllGPU();
            allMotherboards = MotherboardAccessor.RetrieveAllMotherboards();
            allPSU = PSUAccessor.RetrieveAllPSU();
            allRAM = RAMAccessor.RetrieveAllRAM();
            allStorage = StorageAccessor.RetrieveAllStorage();
        }
    }
}
