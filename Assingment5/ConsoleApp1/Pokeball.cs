using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
        public sealed class Pokeball{
        private readonly Pokemon pokemon;
        private bool isOpen;
        public Pokeball(Pokemon pokemon) {
            this.pokemon = pokemon;
        }
        
        public string openPokeball()
        {
            this.isOpen = true;
            return ($"Send out:{getPokemonInPokeball().getName()}!");
        }
        public string closePokeball()
        {
            this.isOpen = false;
            return ($"Returns:{getPokemonInPokeball().getName()}!");
        }
        public Pokemon getPokemonInPokeball()
        {
            return pokemon;
        }
    } 
    
}
