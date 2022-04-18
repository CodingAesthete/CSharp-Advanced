using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;

namespace _03.PeriodicTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            SortedSet<string> elements = new SortedSet<string>();
            for (int i = 0; i < lines; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < input.Length; j++)
                {
                    elements.Add(input[j]);
                }
            }
            foreach (var element in elements)
            {
                Console.Write($"{element} ");
            }
        }
    }
}