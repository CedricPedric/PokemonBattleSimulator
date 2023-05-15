// See https://aka.ms/new-console-template for more information

using ConsoleApp1;
class Program
{
    static void Main(string[] args)
    {
        while (true) { 
        Charmander charmander = new Charmander("Charmander","Fire","Water"); //Default Charmander

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
        for(int i = 0; i < 5; i++) 
        {
            trainer1.belt.Add(new Pokeball(charmander));
            trainer2.belt.Add(new Pokeball(charmander));
        }
        //The "Battle"
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(trainer1.name + " send out " + trainer1.belt[i].charmander.name + "!");
            Console.WriteLine("It cries out its name!");
            trainer1.belt[i].charmander.BattleCry();
            Console.WriteLine(trainer1.name + " returned " + trainer1.belt[i].charmander.name);
            Thread.Sleep(1000); //will sleep for 1 sec

            Console.WriteLine(trainer2.name + " send out " + trainer2.belt[i].charmander.name + "!");
            Console.WriteLine("It cries out its name!");
            trainer2.belt[i].charmander.BattleCry();
            Console.WriteLine(trainer2.name + " returned " + trainer2.belt[i].charmander.name);
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
