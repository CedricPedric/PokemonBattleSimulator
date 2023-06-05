using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Arena
    {
        public static int rounds = 0;
        public static int battles = 0;

        private Trainer trainer1;
        private Trainer trainer2;
        private List<Pokeball> trainer1Belt;
        private List<Pokeball> trainer2Belt;
        private int trainer1CurrentPokemon = 0;
        private int trainer2CurrentPokemon = 0;

        private GameState whoWon;
        public Arena(Trainer trainer1, Trainer trainer2)
        {
            this.trainer1 = trainer1;
            this.trainer2 = trainer2;
        }

        public void Stuff()
        
        {   
            //Put the belts in a field so that i dont have to keep calling the method
            trainer1Belt = trainer1.getBelt();
            trainer2Belt = trainer2.getBelt();
            //Randomizes the pokemon!
            Random rand = new Random();
            trainer1Belt = trainer1Belt.OrderBy(_ => rand.Next()).ToList();
            trainer2Belt = trainer2Belt.OrderBy(_ => rand.Next()).ToList();

            //Prints out the pokemon in their belt
            Console.WriteLine("---------------");
            Console.WriteLine(trainer1.getName() + "'s  Pokemon in Order");
            for (int i = 0; i < trainer1Belt.Count; i++)
            {
                Console.WriteLine(trainer1Belt[i].getPokemonInPokeball().getName());
            }
            Console.WriteLine("---------------");
            Console.WriteLine(trainer2.getName() + "'s Pokemon in Order");
            for (int i = 0; i < trainer2Belt.Count; i++)
            {
                Console.WriteLine(trainer2Belt[i].getPokemonInPokeball().getName());
            }
            Console.WriteLine("---------------");

            Thread.Sleep(1000);


            while (true)
            {

                if (trainer1Belt.Count == trainer1CurrentPokemon && trainer2Belt.Count == trainer1CurrentPokemon)
                {
                    Console.WriteLine("Its a Draw!");
                    battles++;
                    break;
                }
                else if (trainer1Belt.Count == trainer1CurrentPokemon )
                {
                    Console.WriteLine("Trainer2 Won!");
                    battles++;
                    break;
                }
                else if (trainer2Belt.Count == trainer2CurrentPokemon )
                {
                    Console.WriteLine("Trainer1 Won!");
                    battles++;
                    break;
                }
                Console.WriteLine("---------------");
                Console.WriteLine("Pokemon on the field!");
                Console.WriteLine(trainer1Belt[trainer1CurrentPokemon].getPokemonInPokeball().getName());
                Console.WriteLine(trainer2Belt[trainer2CurrentPokemon].getPokemonInPokeball().getName());
                Console.WriteLine("---------------");
                Thread.Sleep(1000);

                Battle battle = new Battle();
                whoWon =  battle.BattleBitch(trainer1Belt[trainer1CurrentPokemon].getPokemonInPokeball(), trainer2Belt[trainer2CurrentPokemon].getPokemonInPokeball());
                if (whoWon == GameState.Draw)
                {
                    trainer1CurrentPokemon++;
                    trainer2CurrentPokemon++;
                }
                else if (whoWon == GameState.Trainer1)
                {
                    trainer2CurrentPokemon++;
                }
                else if (whoWon == GameState.Trainer2)
                {
                    trainer1CurrentPokemon++;
                }
                rounds++;
                Thread.Sleep(1000);
            }
            Console.WriteLine("SCORES:");
            Console.WriteLine("rounds: " + rounds);
            Console.WriteLine("battles: " + battles);
        }
    }
}
