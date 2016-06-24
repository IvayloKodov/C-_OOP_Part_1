using System.Collections.Generic;

namespace Problem8.PokemonTrainer
{
    public class Trainer
    {
        public string name;
        public int badges;
        public List<Pokemon> trainerPokemons;

        public Trainer(string name, int badges, List<Pokemon> trainerPokemons)
        {
            this.name = name;
            this.badges = badges;
            this.trainerPokemons = trainerPokemons;
        }
    }
}
