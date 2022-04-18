using System;
using System.Linq;

namespace _04.AddVAT
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] prices = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(s => double.Parse(s)).Select(s => s * 1.2).ToArray();
            foreach (var price in prices)
            {
                Console.WriteLine($"{price:f2}");
            }
        }
    }
}
