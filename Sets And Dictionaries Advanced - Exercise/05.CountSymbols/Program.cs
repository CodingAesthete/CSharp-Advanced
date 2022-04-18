using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] letters = input.ToCharArray();
            Dictionary<char, int> sorted = new Dictionary<char, int>();
            for (int i = 0; i < letters.Length; i++)
            {
                if (!sorted.ContainsKey(letters[i]))
                {
                    sorted.Add(letters[i], 0);
                }
                sorted[letters[i]]++;
            }
            foreach (var item in sorted.OrderBy(s => s.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
        }
    }
}