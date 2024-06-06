using System;
using System.Collections.Generic;
using Computer_Advance__WF.Computer_Component;
using Computer_Advance__WF.Entity;


namespace Computer_Advance__WF
{
    public class ComputerBuilder 
    {
        private Computer computer;
        private Dictionary<string, Computer> computers;

        public ComputerBuilder()
        {
            computer = new Computer();
            computers = new Dictionary<string, Computer>();
        }

        public ComputerBuilder reset()
        {
            computer = new Computer();
            return this;
        }

        public ComputerBuilder addedMotherboard(int ssd, int ram, string name, int cost)
        {
            computer.Motherboard = new Motherboard(ssd, ram, name, cost);

            return this;
        }

        public ComputerBuilder addedCpu(string name, int cost, int frequency)
        {
            computer.Motherboard.cpu = new CPU(name, cost, frequency);

            return this;
        }

        public ComputerBuilder addedGpu(string name, int cost, int amount)
        {
            computer.Motherboard.gpu = new GPU(name, cost, amount);

            return this;
        }

       
        public ComputerBuilder addedSsd(string name, int cost, int amount)
        {
            if(computer.Motherboard.getSsdSlot() > computer.Motherboard.getCurrentCountSsdSlots()) 
            {
                computer.Motherboard.addSsd(new SSD(name, cost, amount));
            }
            else
            {
                throw new Exception("Зайвий ссд");
            }
               
            return this;
        }

        public ComputerBuilder addedPoweSupply(string name, int cost, int power)
        {
            computer.PowerSupply = new PowerSupply(name, cost, power);

            return this;
        }

        public ComputerBuilder addedRam(string name, int cost, int amount)
        {
            if (computer.Motherboard.getRamSlot() > computer.Motherboard.getCurrentCountRamSlots())
            {
                computer.Motherboard.addRam(new RAM(name, cost, amount));
            } 
            else
            {
                throw new Exception("Зайва оперативка");
            }

            return this;
        }


        public ComputerBuilder addedName(string name)
        {
            computer.Name = name;
            
            return this;
        }

        
        public ComputerBuilder addNewComputer()
        {
            computers.Add(computer.Name, computer);
            return this;
        }

        public Dictionary<string, Computer> getDictionaryComputers()
        {
            return computers;   
        }

        public Computer GetComputer()
        {
            return computer;
        }
    }
}
