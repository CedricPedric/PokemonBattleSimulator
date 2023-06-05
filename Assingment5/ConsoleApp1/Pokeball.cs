using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
        public sealed class Pokeball{
        private readonly Pokemon pokemon;
            
        public Pokeball(Pokemon pokemon) {
            this.pokemon = pokemon;
        }
        
        public Pokemon getPokemonInPokeball()
        {
            return pokemon;
        }
    } 
    
}
