// See https://aka.ms/new-console-template for more information

using ConsoleApp1;
class Program
{
    static void Main(string[] args)
    {
        while (true)
        {

            //Code to make the trainers
            Trainer trainer1 = new Trainer();
            Console.WriteLine("Enter Trainer 1's Name:");
            string userInput = Console.ReadLine();
            trainer1.setName(userInput);

            Trainer trainer2 = new Trainer();
            Console.WriteLine("Enter Trainer 2's Name:");
            userInput = Console.ReadLine();
            trainer2.setName(userInput);

            //Code to fill the belts with pokeballs

            trainer1.addPokemon(new Charmander("Charmander 1"));
            trainer1.addPokemon(new Bulbasaur("Bulbasaur 1"));
            trainer1.addPokemon(new Squirtle("Squirtle 1"));
            trainer1.addPokemon(new Squirtle("Squirtle 2"));
            trainer1.addPokemon(new Squirtle("Squirtle 3"));
            trainer1.addPokemon(new Squirtle("Squirtle 4"));
           
            trainer2.addPokemon(new Charmander("Charmander 1"));
            trainer2.addPokemon(new Bulbasaur("Bulbasaur 1"));
            trainer2.addPokemon(new Squirtle("Squirtle 1"));

            //The "Battle"
            Arena arena = new Arena(trainer1, trainer2);
            arena.Start();
            //The End
            Console.WriteLine("The Game Has Ended! Do you want to see it again? (Yes or No):");
            userInput = Console.ReadLine();
            if (userInput.ToLower() == "no")
            {
                break;
            }
        }

    }




}
