using System;

namespace _09.PokemonTrainer
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Trainer> trainers = new List<Trainer>();
            string input;
            while ((input = Console.ReadLine()) != "Tournament")
            {
                string[] splitted = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string trainerName = splitted[0];
                string pokemonName = splitted[1];
                string element = splitted[2];
                int health = int.Parse(splitted[3]);
                var trainer = trainers.FirstOrDefault(s => s.Name == trainerName);
                if (trainer != null)
                {
                    trainer.Pokemons.Add(new Pokemon(pokemonName, element, health));
                }
                else
                {
                    Trainer newTrainer = new Trainer(trainerName);
                    newTrainer.Pokemons.Add(new Pokemon(pokemonName, element, health));
                    trainers.Add(newTrainer);
                }
            }
            string input2;
            while ((input2 = Console.ReadLine()) != "End")
            {
                for (int i = 0; i < trainers.Count; i++)
                {
                    trainers[i].CheckTrainerForDeadPokemons(input2);
                    if (!trainers[i].Pokemons.Any(s => s.Element == input2))
                    {
                        foreach (var item in trainers[i].Pokemons)
                        {
                            item.ReduceHealth();
                        }
                    }
                    else
                    {
                        trainers[i].IncreaseNumberOfBadges();
                    }
                }
            }
            foreach (var item in trainers.ToList())
            {
                item.Pokemons.RemoveAll(s => s.Health <= 0);
            }
            foreach (var trainer in trainers.OrderByDescending(x => x.NumberOfBadges))
            {
                Console.WriteLine($"{trainer.Name} {trainer.NumberOfBadges} {trainer.Pokemons.Count}");
            }
        }
    }
}
