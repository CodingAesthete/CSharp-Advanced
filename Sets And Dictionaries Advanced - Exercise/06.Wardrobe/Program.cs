using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> sorted = new Dictionary<string, Dictionary<string, int>>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(new[] { " -> ", "," }, StringSplitOptions.RemoveEmptyEntries);
                string colour = input[0];
                string[] data = input.Skip(1).ToArray();
                if (!sorted.ContainsKey(colour))
                {
                    sorted.Add(colour, new Dictionary<string, int>());
                }
                for (int j = 0; j < data.Length; j++)
                {
                    string current = data[j];
                    if (!sorted[colour].ContainsKey(current))
                    {
                        sorted[colour].Add(current, 0);
                    }
                    sorted[colour][current]++;
                }
            }
            string[] output = Console.ReadLine().Split();
            string color = output[0];
            string kind = output[1];
            foreach ((string colour, Dictionary<string, int> colorData) in sorted)
            {
                Console.WriteLine($"{colour} clothes:");
                foreach ((string clothes, int count) in colorData)
                {
                    if (color == colour && kind == clothes)
                    {
                        Console.WriteLine($"* {clothes} - {count} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {clothes} - {count}");
                    }
                }
            }
        }
    }
}
