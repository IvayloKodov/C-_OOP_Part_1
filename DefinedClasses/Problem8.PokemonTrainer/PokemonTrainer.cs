using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem8.PokemonTrainer
{
    public class PokemonTrainer
    {
        static void Main()
        {
            var trainerPokemons = new Dictionary<string, List<Pokemon>>();
            var allTrainers = new List<Trainer>();

            string input = Console.ReadLine();
            while (input != "Tournament")
            {
                string[] pokemonAndTrainerInfo = input
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string trainerName = pokemonAndTrainerInfo[0];
                string pokemonName = pokemonAndTrainerInfo[1];
                string pokemonElement = pokemonAndTrainerInfo[2];
                int pokemonHealth = int.Parse(pokemonAndTrainerInfo[3]);
                Pokemon pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);

                if (!trainerPokemons.ContainsKey(trainerName))
                {
                    trainerPokemons.Add(trainerName, new List<Pokemon>());
                }
                trainerPokemons[trainerName].Add(pokemon);
                input = Console.ReadLine();
            }
            foreach (var trainerPokemon in trainerPokemons)
            {
                Trainer trainer = new Trainer(trainerPokemon.Key, 0, trainerPokemon.Value);
                allTrainers.Add(trainer);
            }
            input = Console.ReadLine();
            while (input != "End")
            {
                allTrainers=allTrainers.Select(t =>
                {
                    if (t.trainerPokemons.Any(p => p.element == input))
                    {
                        t.badges++;
                    }
                    else
                    {
                        t.trainerPokemons.ForEach(p => p.health -= 10);
                        t.trainerPokemons.RemoveAll(p => p.health <= 0);
                    }
                    return t;
                }).ToList();
                input = Console.ReadLine();
            }

            allTrainers.OrderByDescending(t => t.badges)
                .ToList()
                .ForEach(t => Console.WriteLine($"{t.name} {t.badges} {t.trainerPokemons.Count}"));
        }
    }
}