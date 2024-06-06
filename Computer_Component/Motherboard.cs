using System.Collections.Generic;
using System;

namespace Computer_Advance__WF.Computer_Component
{
    public class Motherboard : ComputerComponent
    {

        public CPU cpu { get; set; }
        public GPU gpu { get; set; }
        public List<RAM> ram ;
        public List<SSD> ssd;

        private int cpuSlot;
        private int gpuSlot;
        private int ssdSlot;
        private int ramSlot;
                
        public Motherboard(int ssdAmount,int ramAmount, string name, int cost) : base(name, cost)
        {
            validation(ssdAmount, ramAmount);
            this.cpuSlot = 1;
            this.gpuSlot = 1;
            this.ssdSlot = ssdAmount; //Зробити валідацію
            this.ramSlot = ramAmount;
            this.ram = new List<RAM>();
            this.ssd = new List<SSD>();

        }

        public void validation(int ssdAmount, int ramAmount)
        {
            if (ramAmount > 4)
            {
                throw new Exception("В матеренську плату було передано більше слотів під оперативну пам'ять ніж можливо");
            }
            if (ramAmount < 2)
            {
                throw new Exception("В матеренську плату було передано менше слотів під оперативну пам'ять ніж можливо");
            }
            if (ssdAmount > 2)
            {
                throw new Exception("В матеренську плату було передано більше слотів під ssd ніж можливо");
            }
            if (ssdAmount < 1)
            {
                throw new Exception("В матеренську плату було передано меньше слотів під ssd ніж можливо");
            }
        }

        public int getCpuSlot() => cpuSlot;
        public int getGpuSlot() => gpuSlot;
        public int getSsdSlot() => ssdSlot;
        public int getRamSlot() => ramSlot;

        public void addRam(RAM ram)
        {
            this.ram.Add(ram);
        }

        public void addSsd(SSD ssd)
        {
            this.ssd.Add(ssd);
        }

        public int getCurrentCountRamSlots()
        {
            return ram.Count;
        }

        public int getCurrentCountSsdSlots()
        {
            return ssd.Count;
        }

        public override string getAllData()
        {
            return $"Товар : {name}\nЦіна : {cost}\n====Слоти====\nСлотів процесору : {cpuSlot}\n" +
                   $"Слотів відеокарти : {gpuSlot}\nСлотів Sata : {ssdSlot}\nСлоти оперативної пам'яті : {ramSlot}\n";
        }
    }
}
