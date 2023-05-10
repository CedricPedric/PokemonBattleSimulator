using System;

class Program
{
    public static void Main(string[] args)
    {
        Charmander charmander = new Charmander("Charmander", "Fire", "Water");
        while (true)
        {
            Console.WriteLine("Name your Charmander! Type exit to quit!");
            string NewName = Console.ReadLine();
            charmander.setName(NewName);
            if (charmander.name == "exit")
            {
                break;
            }
            Console.WriteLine("Your Charmander Cries out its name!");
            for (int i = 0; i < 10; i++)
            {
                charmander.BattleCry();
            }
        }
    }

    class Charmander
    {
        public String name;
        public String type;
        public String weakness;

        public Charmander(String name, String type, String weakness)
        {
            this.name = name;
            this.type = type;
            this.weakness = weakness;
        }

        public String getName()
        {
            return name;
        }

        public void setName(String name)
        {
            this.name = name;
        }
        public void BattleCry()
        {
            Console.WriteLine(this.name + "!");
        }
    }
}