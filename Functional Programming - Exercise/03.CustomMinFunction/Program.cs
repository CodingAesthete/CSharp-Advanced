using System;
using System.Linq;

namespace _03.CustomMinFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Func<int[], int> Small = a => a.Min();
            Console.WriteLine(Small(nums));
        }
    }
}
