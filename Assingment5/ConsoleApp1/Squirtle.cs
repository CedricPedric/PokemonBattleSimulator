using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Squirtle: Pokemon
    {
        public Squirtle(string name) : base(name, Types.Water, Types.Grass) { }
        public override void BattleCry()
        {
            Console.WriteLine("Squirtle!");
        }
    }
}
