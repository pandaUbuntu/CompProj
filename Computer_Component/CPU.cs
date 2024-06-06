using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_Advance__WF.Computer_Component
{
    public class CPU : ComputerComponent
    {
        private int frequency;

        public int getFrequency() => frequency;
        public void setFrequency(int frequency)
        {
            this.frequency = frequency;
        }

        public CPU(string name, int cost, int frequency) : base(name, cost)
        {
            this.frequency = frequency;
        }

        public override string getAllData()
        {
            return $"Товар : {name}\nЦіна : {cost}\nGghz : {frequency}\n";       
        }
    }
}
