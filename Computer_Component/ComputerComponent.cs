using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_Advance__WF.Computer_Component
{
    public class ComputerComponent
    {
         protected string name;
         protected int cost;

         public string getName()=>name ;
         public void setName(string name)
         {
             this.name = name ;
         }

         public int getCost() => cost;
         public void setCost(int cost)
         {
             this.cost = cost;
         }

         public virtual string getAllData()
         {
             return " ";
         }

         public ComputerComponent(string name, int cost)
         {
             this.name = name;
             this.cost = cost;
         }

    }
}
