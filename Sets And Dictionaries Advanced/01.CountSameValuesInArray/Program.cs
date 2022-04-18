using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;

namespace _01.CountSameValuesInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-GB");
            double[] input = Console.ReadLine().Split().Select(double.Parse).ToArray();
            Dictionary<double, int> sorted = new Dictionary<double, int>();
            for (int i = 0; i < input.Length; i++)
            {
                if (!sorted.ContainsKey(input[i]))
                {
                    sorted.Add(input[i], 1);
                }
                else
                {
                    sorted[input[i]]++;
                }
            }
            foreach (var item in sorted)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }
        }
    }
}
