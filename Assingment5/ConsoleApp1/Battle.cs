using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Battle 
    {
 
        public GameState StartBattle(Pokemon trainer1Pokemon, Pokemon trainer2Pokemon )
        {
            if (trainer1Pokemon.getType() == trainer2Pokemon.getType())
            {
                Console.WriteLine("This Battle is a Draw!");
                return GameState.Draw;
            }
            else if (trainer1Pokemon.isWeakAgainst(trainer2Pokemon))
            {
                Console.WriteLine(trainer2Pokemon.getName() + " Has slain " + trainer1Pokemon.getName() + "!");
                return GameState.Trainer1;
            }
            else if (trainer2Pokemon.isWeakAgainst(trainer1Pokemon))
            {
                Console.WriteLine(trainer1Pokemon.getName() + " Has slain " + trainer2Pokemon.getName() + "!");
                return GameState.Trainer2;
            }
            else 
            {
                return GameState.Draw;
            }

         
        }   

    }
}
