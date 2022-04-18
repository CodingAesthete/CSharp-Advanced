using System;
using System.Collections.Generic;
using System.Linq;

namespace _12.CupsAndBottles
{
    class Program
    {
        static void Main()
        {
            int[] cupsnums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] bottlesnums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> cups = new Queue<int>(cupsnums);
            Stack<int> bottles = new Stack<int>(bottlesnums);
            int wasted = 0;
            while (cups.Count != 0 && bottles.Count != 0)
            {
                int currcup = cups.Dequeue();
                int currbottle = bottles.Pop();
                int total = currcup - currbottle;
                if (total > 0)
                {
                    List<int> cow = cups.ToList();
                    cups = new Queue<int>();
                    cups.Enqueue(total);
                    for (int i = 0; i < cow.Count; i++)
                    {
                        cups.Enqueue(cow[i]);
                    }
                }
                else if (total == 0)
                {

                }
                else if (total < 0)
                {
                    wasted += -total;
                }
            }
            if (!bottles.Any())
            {
                Console.WriteLine($"Cups: {String.Join(" ", cups)}");
                Console.WriteLine($"Wasted litters of water: {wasted}");

            }
            else if (!cups.Any())
            {
                Console.WriteLine($"Bottles: {String.Join(" ", bottles)}");
                Console.WriteLine($"Wasted litters of water: {wasted}");
            }
        }
    }
}
