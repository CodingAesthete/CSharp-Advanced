using System;
using System.Collections.Generic;

namespace _04.CitiesByContinentAndCountry
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, List<string>>> sorted = new Dictionary<string, Dictionary<string, List<string>>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string continent = input[0];
                string country = input[1];
                string town = input[2];
                if (!sorted.ContainsKey(continent))
                {
                    sorted.Add(continent, new Dictionary<string, List<string>>());
                    sorted[continent].Add(country, new List<string>());
                    sorted[continent][country].Add(town);
                }
                else
                {
                    if (!sorted[continent].ContainsKey(country))
                    {
                        sorted[continent].Add(country, new List<string>());
                        sorted[continent][country].Add(town);
                    }
                    else if (sorted[continent].ContainsKey(country))
                    {
                        sorted[continent][country].Add(town);
                    }
                }
            }
            foreach (var item in sorted)
            {
                Console.WriteLine($"{item.Key}:");
                foreach (var itemo in item.Value)
                {
                    Console.Write($"{itemo.Key} -> ");
                    Console.Write(String.Join(", ", itemo.Value));
                    Console.WriteLine();
                }
            }
        }
    }
}
