using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.ProductShop
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Dictionary<string, double>> sorted = new SortedDictionary<string, Dictionary<string, double>>();
            string input;
            while ((input = Console.ReadLine()) != "Revision")
            {
                string[] command = input.Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string shop = command[0];
                string product = command[1];
                double price = double.Parse(command[2]);
                if (!sorted.ContainsKey(shop))
                {
                    sorted.Add(shop, new Dictionary<string, double>());
                    sorted[shop].Add(product, price);
                }
                else
                {
                    sorted[shop].Add(product, price);
                }
            }
            foreach (var item in sorted)
            {
                Console.WriteLine($"{item.Key}->");
                foreach (var itemo in item.Value)
                {
                    Console.WriteLine($"Product: {itemo.Key}, Price: {itemo.Value}");
                }
            }
        }
    }
}
