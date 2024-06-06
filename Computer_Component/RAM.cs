using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_Advance__WF.Computer_Component
{
    public class RAM : ComputerComponent
    {
        private int amount;

        public int getAmount_RAM() => amount;
        public void setAmount_RAM(int amount)
        {
            this.amount = amount;
        }

        public RAM(string name, int cost, int amount) : base(name, cost)
        {
            this.amount = amount;
        }

        public override string getAllData()
        {
            return $"Товар : {name}\nЦіна : {cost}\nЄмність (ГБ) : {amount}\n";
        }
    }
}
