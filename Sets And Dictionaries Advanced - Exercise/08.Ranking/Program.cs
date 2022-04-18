using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> sorted = new Dictionary<string, string>();
            Dictionary<string, Dictionary<string, int>> sorted2 = new Dictionary<string, Dictionary<string, int>>();
            string sente;
            while ((sente = Console.ReadLine()) != "end of contests")
            {
                string[] input = sente.Split(":");
                string contest = input[0];
                string pass = input[1];
                if (!sorted.ContainsKey(contest))
                {
                    sorted.Add(contest, pass);
                }
            }
            string sempre;
            while ((sempre = Console.ReadLine()) != "end of submissions")
            {
                string[] input2 = sempre.Split("=>");
                string contest = input2[0];
                string pass = input2[1];
                string cand = input2[2];
                int points = int.Parse(input2[3]);
                if (sorted.ContainsKey(contest) && sorted[contest] == pass)
                {
                    if (!sorted2.ContainsKey(cand))
                    {
                        sorted2.Add(cand, new Dictionary<string, int>());
                    }
                    if (!sorted2[cand].ContainsKey(contest))
                    {
                        sorted2[cand].Add(contest, points);
                    }
                    else if (sorted2[cand].ContainsKey(contest))
                    {
                        if (points > sorted2[cand][contest])
                        {
                            sorted2[cand][contest] = points;
                        }
                    }
                }
            }
            var sorted3 = sorted2.OrderByDescending(s => s.Value.Values.Sum()).First();
            string winner = sorted3.Key;
            int winnero = sorted3.Value.Values.Sum();
            Console.WriteLine($"Best candidate is {winner} with total {winnero} points.");
            Console.WriteLine("Ranking:");
            foreach (var item in sorted2.OrderBy(s => s.Key))
            {
                Console.WriteLine(item.Key);
                foreach (var itemo in item.Value.OrderByDescending(s => s.Value))
                {
                    Console.WriteLine($"#  {itemo.Key} -> {itemo.Value}");
                }
            }
        }
    }
}