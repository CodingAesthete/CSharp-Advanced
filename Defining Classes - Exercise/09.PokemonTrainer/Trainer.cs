using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _09.PokemonTrainer
{
    public class Trainer
    {
        public List<Pokemon> Pokemons { get; set; }
        public string Name { get; set; }
        public int NumberOfBadges { get; set; }
        public Trainer(string name)
        {
            Pokemons = new List<Pokemon>();
            NumberOfBadges = 0;
            Name = name;
        }
        public void IncreaseNumberOfBadges()
        {
            NumberOfBadges++;
        }
        public void CheckTrainerForDeadPokemons(string element)
        {
            Pokemons = Pokemons.Where(pokemon => pokemon.Health > 0).ToList();
        }
    }
}