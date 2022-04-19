using System;
using System.Linq;

namespace _04.Froggy
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(",").Select(int.Parse).ToArray();
            Lake lake = new Lake(nums.ToList());
            Console.WriteLine(String.Join(", ", lake));
        }
    }
}

