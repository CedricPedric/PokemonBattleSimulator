using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Trainer
    {   
        private string name = "Trainer";
        private readonly int MaxBelt = 6;
        private List<Pokeball> belt = new List<Pokeball>(6);
        public void setName(String name)
        {
            this.name = name;
        }
        public string getName()
        {
            return this.name;   
        }
        public List<Pokeball> getBelt()
        {
            return belt;
        }
        public void addPokemon(Pokemon pokemon)
        {   
            if (this.belt.Count == MaxBelt)
            {
                throw new ArgumentException("The pokeball belt is already full!");
                // illegalargument exception
            }
            else
            {
                this.belt.Add(new Pokeball(pokemon));
            }
        }
    }
}
