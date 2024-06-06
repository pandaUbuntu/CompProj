

namespace Computer_Advance__WF.Computer_Component
{
    public class SSD : ComputerComponent
    {
        private int amount;

        public int getAmount_SSD() => amount;
        public void setAmount_SSD(int amount)
        {
            this.amount = amount;
        }

        public SSD(string name, int cost, int amount) : base(name, cost)
        {
            this.amount = amount;
        }

        public override string getAllData()
        {
            return $"Товар : {name}\nЦіна : {cost}\nЄмність (ГБ) : {amount}\n";
        }
    }
}
