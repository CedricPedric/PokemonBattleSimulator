using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Arena
    {
        private static int roundsCount;
        private static int battleCounter;

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
        public int getBattlesCounter()
        {
            return Arena.battleCounter;
        }

        public static void increaseBattleCounter() {
            Arena.battleCounter++;
        }

        public int getRoundCounter()
        {
            return Arena.roundsCount;
        }

        public static void increaseRoundCounter()
        {
            Arena.roundsCount++;
        }



        public void Start()
        
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
                    increaseBattleCounter();
                    break;
                }
                else if (trainer1Belt.Count == trainer1CurrentPokemon )
                {
                    Console.WriteLine($"{trainer2.getName()} Won!");
                    increaseBattleCounter();
                    break;
                }
                else if (trainer2Belt.Count == trainer2CurrentPokemon )
                {
                    Console.WriteLine($"{trainer1.getName()} Won!");
                    increaseBattleCounter();
                    break;
                }
                Console.WriteLine("---------------");
                Console.WriteLine("Pokemon on the field!");
                Console.WriteLine($"{trainer1.getName()} {trainer1Belt[trainer1CurrentPokemon].openPokeball()}");
                Console.WriteLine($"{trainer2.getName()} {trainer2Belt[trainer2CurrentPokemon].openPokeball()}");
                Console.WriteLine("---------------");
                Thread.Sleep(1000);

                Battle battle = new Battle();
                trainer1Belt[trainer1CurrentPokemon].openPokeball();
                trainer2Belt[trainer2CurrentPokemon].openPokeball();
                whoWon =  battle.StartBattle(trainer1Belt[trainer1CurrentPokemon].getPokemonInPokeball(), trainer2Belt[trainer2CurrentPokemon].getPokemonInPokeball());
                if (whoWon == GameState.Draw)
                {
                    Console.WriteLine($"{trainer1.getName()} {trainer1Belt[trainer1CurrentPokemon].closePokeball()}");
                    Console.WriteLine($"{trainer2.getName()} {trainer2Belt[trainer2CurrentPokemon].closePokeball()}");
                    trainer1CurrentPokemon++;
                    trainer2CurrentPokemon++;
                }
                else if (whoWon == GameState.Trainer1)
                {
                    Console.WriteLine($"{trainer2.getName()} {trainer2Belt[trainer2CurrentPokemon].closePokeball()}");
                    trainer2CurrentPokemon++;
                }
                else if (whoWon == GameState.Trainer2)
                {
                    Console.WriteLine($"{trainer1.getName()} {trainer1Belt[trainer1CurrentPokemon].closePokeball()}");
                    trainer1CurrentPokemon++;
                }
                increaseRoundCounter();
                Thread.Sleep(1000);
            }

            Console.WriteLine("SCORES:");
            Console.WriteLine("rounds: " +  getRoundCounter());
            Console.WriteLine("battles: " + getBattlesCounter());
        }
    }
}
