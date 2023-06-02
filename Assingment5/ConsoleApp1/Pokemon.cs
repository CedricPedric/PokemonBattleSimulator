using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Pokemon
    {
        public String name = "";
        public String type;
        public String weakness;
        public enum types { 
        Grass,
        Fire,
        Water
        }

        
        public Pokemon(String name, String type, String weakness)
        {
            this.name = name;
            this.type = type;
            this.weakness = weakness;
        }

        public abstract void BattleCry();

        //setters and getters for the name field
        public string getName()
        {
            return name;
        }
        public void setName(String name)
        {
            this.name = name;
        }
        //setters and getters for the type field
        public string getType()
        {
            return type;
        }
        public void setType(String type)
        {
            this.type = type;
        }
        //setters and getters for the weakness field
        public string getWeakness()
        {
            return weakness;
        }
        public void setWeakness(String weakness)
        {
            this.weakness = weakness;
        }
    }
}
