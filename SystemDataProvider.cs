using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treći_i_četvrti_zadatak
{
    class SystemDataProvider : SimpleSystemDataProvider
    {
        private float previousCPULoad;
        private float previousRAMAvailable;
        public SystemDataProvider() : base()
        {
            this.previousCPULoad = this.CPULoad;
            this.previousRAMAvailable = this.AvailableRAM;
        }
        public float GetCPULoad()
        {
            float currentLoad = this.CPULoad;

            //Treći zadatak
            //if (currentLoad != this.previousCPULoad)
            //{
            //    this.Notify();
            //}

            //Četvrti zadatak
            if (currentLoad < this.previousCPULoad*0.9 || currentLoad > this.previousCPULoad * 1.1)
            {
                this.Notify();
            }
            this.previousCPULoad = currentLoad;
            return currentLoad;
        }
        public float GetAvailableRAM()
        {
            float currentAvailableRAM = this.AvailableRAM;

            //Treći zadatak
            //if (currentAvailableRAM != this.previousRAMAvailable)
            //{
            //    this.Notify();
            //}

            //Četvrti zadatak
            if (currentAvailableRAM < this.previousRAMAvailable * 0.9 || currentAvailableRAM > this.previousRAMAvailable * 1.1)
            {
                this.Notify();
            }
            this.previousRAMAvailable = currentAvailableRAM;
            return currentAvailableRAM;
        }
    }
}
