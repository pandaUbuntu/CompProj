using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Computer_Advance__WF.Computer;
using Computer_Advance__WF.Computer_Component;

namespace Computer_Advance__WF
{
    public interface Interface1
    {
        void BuilderName();
        void BuilderCPU();
        void BuilderGPU();
        void BuilderRAM();
        void BuilderSSD();
        void BuilderMotherboard();
        void BuilderPowerSupply();
        Computer.Computer GetComputer();
    }
}
