using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Arena
    {
        public int rounds = 0;
        public int battles = 0;

        public Trainer trainer1;
        public Trainer trainer2;
        private int trainer1CurrentPokemon = 0;
        private int trainer2CurrentPokemon = 0;
        public string whoWon = "";

        public Arena(Trainer trainer1, Trainer trainer2)
        {
            this.trainer1 = trainer1;
            this.trainer2 = trainer2;
        }

        public void Stuff()
        
        {
            //This randomizes the pokemon!

            Random rand = new Random();
            trainer1.belt = trainer1.belt.OrderBy(_ => rand.Next()).ToList();
            trainer2.belt = trainer2.belt.OrderBy(_ => rand.Next()).ToList();

            Console.WriteLine("Trainer 1's Pokemon in Order");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(trainer1.belt[i].pokemon.name);
            }
            Console.WriteLine("---------------");
            Console.WriteLine("Trainer 2's Pokemon in Order");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(trainer2.belt[i].pokemon.name);
            }
            Console.WriteLine("---------------");
            while (true)
            {

                if (trainer1.belt.Count == trainer1CurrentPokemon && trainer2.belt.Count == trainer1CurrentPokemon)
                {
                    Console.WriteLine("Its a Draw!");
                    battles++;
                    break;
                }
                else if (trainer1.belt.Count == trainer1CurrentPokemon )
                {
                    Console.WriteLine("Trainer2 Won!");
                    battles++;
                    break;
                }
                else if (trainer2.belt.Count == trainer2CurrentPokemon )
                {
                    Console.WriteLine("Trainer1 Won!");
                    battles++;
                    break;
                }
                Console.WriteLine(trainer1.belt[trainer1CurrentPokemon].pokemon.name);
                Console.WriteLine(trainer2.belt[trainer2CurrentPokemon].pokemon.name);

                Battle battle = new Battle();
                whoWon = battle.BattleBitch(trainer1.belt[trainer1CurrentPokemon].pokemon, trainer2.belt[trainer2CurrentPokemon].pokemon);
                if (whoWon == "Draw")
                {
                    trainer1CurrentPokemon++;
                    trainer2CurrentPokemon++;
                }
                else if (whoWon == "Trainer1")
                {
                    trainer2CurrentPokemon++;
                }
                else if (whoWon == "Trainer2")
                {
                    trainer1CurrentPokemon++;
                }
                rounds++;
            }
            Console.WriteLine("SCORES:");
            Console.WriteLine("rounds: " + rounds);
            Console.WriteLine("battles: " + battles);
        }
    }
}
