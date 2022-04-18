using System;
using System.Linq;

namespace _01.SortEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(", ").Select(s =>
            {
                return int.Parse(s);
            }).Where(s => s % 2 == 0).OrderBy(s => s).ToArray();
            Console.WriteLine(String.Join(", ", nums));
        }
    }
}
