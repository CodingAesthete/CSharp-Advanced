using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.TheVlogger
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, SortedSet<string>>> app =
                new Dictionary<string, Dictionary<string, SortedSet<string>>>();
            string sento;
            while ((sento = Console.ReadLine()) != "Statistics")
            {
                string[] input = sento.Split();
                string command = input[1];
                if (command == "joined")
                {
                    string vlogger = input[0];
                    if (!app.ContainsKey(vlogger))
                    {
                        app.Add(vlogger, new Dictionary<string, SortedSet<string>>());
                        app[vlogger].Add("following", new SortedSet<string>());
                        app[vlogger].Add("followers", new SortedSet<string>());
                    }
                }
                else if (command == "followed")
                {
                    string vlogger = input[0];
                    string vlogger2 = input[2];
                    if (app.ContainsKey(vlogger) && app.ContainsKey(vlogger2) && vlogger != vlogger2)
                    {
                        app[vlogger2]["followers"].Add(vlogger);
                        app[vlogger]["following"].Add(vlogger2);
                    }
                }
            }
            Console.WriteLine($"The V-Logger has a total of {app.Keys.Count} vloggers in its logs.");
            int count = 0;
            Dictionary<string, Dictionary<string, SortedSet<string>>> sortedApp =
                app.OrderByDescending(s => s.Value["followers"].Count).
                ThenBy(s => s.Value["following"].Count).ToDictionary(s => s.Key, s => s.Value);
            foreach (var item in sortedApp)
            {
                count++;
                Console.WriteLine($"{count}. {item.Key} : {item.Value["followers"].Count} followers, {item.Value["following"].Count} following");
                if (count == 1)
                {
                    foreach (var itemo in item.Value["followers"])
                    {
                        Console.WriteLine($"*  {itemo}");
                    }
                }
            }
        }
    }
}
