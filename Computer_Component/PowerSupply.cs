using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_Advance__WF.Computer_Component
{
    public class PowerSupply : ComputerComponent
    {
        private int power;

        public int getPower_PS() => power;
        public void setPower_PS(int power)
        {
            this.power = power;
        }

        public override string getAllData()
        {
            return $"Товар : {name}\nЦіна : {cost}\nПотужність (Ват): {power}";
        }

        public PowerSupply(string name,int cost,int power) : base(name,cost) 
        { 
            this.power = power;
        }
    }
}
