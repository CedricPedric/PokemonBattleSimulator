using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Battle 
    {      
        public string BattleBitch(Pokemon trainer1Pokemon, Pokemon trainer2Pokemon )
        {
            if (trainer1Pokemon.getType() == trainer2Pokemon.getType())
            {
                Console.WriteLine("This Battle is a Draw!");
                return "Draw";
            }
            else if (trainer1Pokemon.getType() == trainer2Pokemon.getWeakness())
            {
                return "Trainer1";
            }
            else if (trainer2Pokemon.getType() == trainer1Pokemon.getWeakness())
            {
                return "Trainer2";
            }
            else
            {
                return "Helemaal Niks";
            }
        }   

    }
}
