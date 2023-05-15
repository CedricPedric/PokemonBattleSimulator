// See https://aka.ms/new-console-template for more information

using ConsoleApp1;
class Program
{
    static void Main(string[] args)
    {
        Charmander charmander = new Charmander("Charmander","Fire","Water");
        Trainer trainer = new Trainer();
        trainer.belt.Add(new Pokeball(charmander));


        Console.WriteLine(trainer.belt[0].charmander.name);
    }

      
}
