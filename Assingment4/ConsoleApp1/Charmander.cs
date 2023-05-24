using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Charmander : Pokemon
    {

        public Charmander(string name) : base(name, "Fire", "Water") { }

        public override void BattleCry()
        {
            Console.WriteLine("Charmander!");
        }
    }
}
