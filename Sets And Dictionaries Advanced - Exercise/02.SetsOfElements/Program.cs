using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.SetsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int n = input[0];
            int m = input[1];
            HashSet<int> firstSet = new HashSet<int>();
            HashSet<int> secondSet = new HashSet<int>();
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                firstSet.Add(num);
            }
            for (int i = 0; i < m; i++)
            {
                int num = int.Parse(Console.ReadLine());
                secondSet.Add(num);
            }
            foreach (var num in firstSet)
            {
                if (secondSet.Contains(num))
                {
                    Console.Write($"{num} ");
                }
            }
        }
    }
}