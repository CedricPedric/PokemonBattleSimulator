using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Pokemon
    {
        public String name = "";
        public String type;
        public String weakness;
        
        public Pokemon(String name, String type, String weakness)
        {
            this.name = name;
            this.type = type;
            this.weakness = weakness;
        }

        public abstract void BattleCry();
    }
}
