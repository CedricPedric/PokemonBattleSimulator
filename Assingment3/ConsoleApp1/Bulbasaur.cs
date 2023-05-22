using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Bulbasaur: Pokemon
    {
        public Bulbasaur(string name) : base(name, "Grass", "Fire") { }

        public override void BattleCry()
        {
            Console.WriteLine("Bulbasaur!");
        }

    }
}
