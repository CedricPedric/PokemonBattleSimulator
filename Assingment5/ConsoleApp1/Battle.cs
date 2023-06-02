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
            //Charmander Wins!
            else if (trainer1Pokemon.type == "Fire" && trainer2Pokemon.type == "Grass")
            {
                Console.WriteLine("Trainer 1's Charmander Kills Bulbasaur!");
                return "Trainer1";
            }
            else if (trainer1Pokemon.type == "Grass" && trainer2Pokemon.type == "Fire")
            {
                Console.WriteLine("Trainer 2's Charmander Kills Bulbasaur!");
                return "Trainer2";
            }
            //Bulbasaur Wins!
            else if (trainer1Pokemon.type == "Grass" && trainer2Pokemon.type == "Water")
            {
                Console.WriteLine("Trainer 1's Bulbasaur Kills Squirtle!");
                return "Trainer1";
            }
            else if (trainer1Pokemon.type == "Water" && trainer2Pokemon.type == "Grass")
            {
                Console.WriteLine("Trainer 2's Bulbasaur Kills Squirtle!");
                return "Trainer2";
            }
            //Squirtle Wins!
            else if (trainer1Pokemon.type == "Water" && trainer2Pokemon.type == "Fire")
            {
                Console.WriteLine("Trainer 1's Squirtle Kills Charmander!");
                return "Trainer1";
            }
            else if (trainer1Pokemon.type == "Fire" && trainer2Pokemon.type == "Water")
            {
                Console.WriteLine("Trainer 2's Squirtle Kills Charmander!");
                return "Trainer2";
            }
            else
            {
                return "Helemaal Niks";
            }
        }   

    }
}
