using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_Advance__WF.Computer_Component
{
    public class GPU : ComputerComponent
    {
        private int amount;

        public int getAmount_GPU() => amount;
        public void setAmount_GPU(int amount)
        {
            this.amount = amount;
        }

        public GPU(string name, int cost, int amount) : base(name, cost)
        {
            this.amount = amount;
        }

        public override string getAllData()
        {
            return $"Товар : {name}\nЦіна : {cost}\nЄмність (ГБ) : {amount}\n";
        }
    }
}
