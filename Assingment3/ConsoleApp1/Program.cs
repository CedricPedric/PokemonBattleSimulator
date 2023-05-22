// See https://aka.ms/new-console-template for more information

using ConsoleApp1;
class Program
{
    static void Main(string[] args)
    {
        while (true) { 

        //Code to make the trainers
        Trainer trainer1 = new Trainer();
        Console.WriteLine("Enter Trainer 1's Name:");
        string userInput = Console.ReadLine();
        trainer1.setName(userInput);
        Console.WriteLine(trainer1.name);

        Trainer trainer2 = new Trainer();
        Console.WriteLine("Enter Trainer 2's Name:");
        userInput = Console.ReadLine();
        trainer2.setName(userInput);
        Console.WriteLine(trainer2.name);

        //Code to fill the belts with pokeballs
       
        trainer1.belt.Add(new Pokeball(new Bulbasaur("Bulbasaur 1")));
        trainer1.belt.Add(new Pokeball(new Charmander("Charmander 1")));
        trainer1.belt.Add(new Pokeball(new Squirtle("Squirtle 1")));

        trainer2.belt.Add(new Pokeball(new Bulbasaur("Bulbasaur 2")));
        trainer2.belt.Add(new Pokeball(new Charmander("Charmander 2")));
        trainer2.belt.Add(new Pokeball(new Squirtle("Squirtle 2")));

            //The "Battle"
            for (int i = 0; i < 3; i++)
        {
            Console.WriteLine(trainer1.name + " send out " + trainer1.belt[i].pokemon.name + "!");
            Console.WriteLine("It cries out its name!");
            trainer1.belt[i].pokemon.BattleCry();
            Console.WriteLine(trainer1.name + " returned " + trainer1.belt[i].pokemon.name);
            Thread.Sleep(1000); //will sleep for 1 sec

            Console.WriteLine(trainer2.name + " send out " + trainer2.belt[i].pokemon.name + "!");
            Console.WriteLine("It cries out its name!");
            trainer2.belt[i].pokemon.BattleCry();
            Console.WriteLine(trainer2.name + " returned " + trainer2.belt[i].pokemon.name);
            Thread.Sleep(1000); //will sleep for 1 sec
        }
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
