using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Charmander
    {
        public String name;
        public String type;
        public String weakness;

        public Charmander(String name, String type, String weakness)
        {
            this.name = name;
            this.type = type;
            this.weakness = weakness;
        }

        public void setName(String name)
        {
            this.name = name;
        }
        public void BattleCry()
        {
            Console.WriteLine(this.name + "!");
        }
    }
}
