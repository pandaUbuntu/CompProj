using System.Collections.Generic;
using Computer_Advance__WF.Computer_Component;

namespace Computer_Advance__WF.Entity
{
    public class Computer
    {
        public string Name { get; set; }
      
        public Motherboard Motherboard { get; set; }
        public PowerSupply PowerSupply { get; set; }


       public List<string> getAllComponentNames()
        {
            List<string> componentNames = new List<string>
            {
               Motherboard.getName(),
               Motherboard.cpu.getName(),
               Motherboard.gpu.getName(),
               Motherboard.getName(),
               PowerSupply.getName()
            };
            Motherboard.ssd.ForEach(delegate (SSD thisSsd)
            {
                componentNames.Add(thisSsd.getName());
            });
            Motherboard.ram.ForEach(delegate (RAM thisRam)
            {
                componentNames.Add(thisRam.getName());
            });

            return componentNames;
        }

        public ComputerComponent getComponent(string nameComponent)
        {
            /*Dictionary<string, ComputerComponent> component = new Dictionary<string, ComputerComponent> //Dictionary
            {
                {
                 Motherboard.getName(),
                 Motherboard
                },
                {
                  Motherboard.cpu.getName(),
                  Motherboard.cpu
                },
                {
                  Motherboard.gpu.getName(),
                  Motherboard.gpu
                },
                {
                  PowerSupply.getName(),
                  PowerSupply
                },
            };

            Motherboard.ssd.ForEach(delegate (SSD thisSsd)
            {
                if (!component.ContainsKey(thisSsd.getName()))
                {
                    component.Add(thisSsd.getName(), thisSsd);
                }
            });
            Motherboard.ram.ForEach(delegate (RAM thisRam)
            {
                if (!component.ContainsKey(thisRam.getName()))
                {
                    component.Add(thisRam.getName(), thisRam);
                }
            });*/

            List<ComputerComponent> components = new List<ComputerComponent> // або ліст
            {
               Motherboard,
               Motherboard.cpu,
               Motherboard.gpu,
               PowerSupply
            };
            var component = components.Find(comp => comp.getName() == nameComponent);
            if(component != null)
            {
                return component;
            }
            var ssdComponent = Motherboard.ssd.Find(ssd => ssd.getName() == nameComponent);
            if (component != null)
            {
                return component;
            }
            var ramComponent = Motherboard.ram.Find(ram => ram.getName() == nameComponent);
            if (component != null)
            {
                return component;
            }
            return null;
        }
    }
}
