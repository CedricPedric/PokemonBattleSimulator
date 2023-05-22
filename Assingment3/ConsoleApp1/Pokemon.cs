using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Pokemon
    {
        public String name = "";
        public String type;
        public String weakness;

        public void BattleCry()
        {
            Console.WriteLine(this.name + "!");
        }
        public void setName(String name)
        {
            this.name = name;
        }
    }
}
