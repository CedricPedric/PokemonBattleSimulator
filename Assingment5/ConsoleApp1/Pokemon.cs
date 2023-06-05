using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Pokemon
    {

        //All the fiels I used
        private String name = "";
        public enum Types { 
        Grass,
        Fire,
        Water
        }
        private readonly Types type;
        private readonly Types weakness;

        
        public Pokemon(String name, Types type, Types weakness)
        {
            this.name = name;
            this.type = type;
            this.weakness = weakness;
        }
  
        public abstract void BattleCry();

        //All The Get's and Set's
        public string getName()
        {
            return name;
        }
        public void setName(String name)
        {
            this.name = name;
        }
        public Types getType()
        {
            return type;
        }
        public Types getWeakness()
        {
            return weakness;
        }
        
        public bool isWeakAgainst(Pokemon pokemon)
        {
            return pokemon.getType() == this.getWeakness();
        }
    }
}
