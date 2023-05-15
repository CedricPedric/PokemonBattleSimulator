using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Trainer
    {   
      
        public string name = "Trainer";
        public void setName(String name)
        {
            this.name = name;
        }
        public List<Pokeball> belt = new List<Pokeball>();

        
    }
}
