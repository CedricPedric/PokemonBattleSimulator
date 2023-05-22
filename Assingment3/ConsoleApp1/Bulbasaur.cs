using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Bulbasaur: Pokemon
    {
        public Bulbasaur(String name, String type, String weakness)
        {
            this.name = name;
            this.type = type;
            this.weakness = weakness;
        }
    }
}
