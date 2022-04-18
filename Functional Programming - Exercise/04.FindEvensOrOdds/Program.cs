using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.FindEvensOrOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int start = input[0];
            int end = input[1];
            List<int> nums = new List<int>();
            for (int i = start; i <= end; i++)
            {
                nums.Add(i);
            }
            string condition = Console.ReadLine();
            if (condition == "even")
            {
                nums = nums.Where(s => s % 2 == 0).ToList();
            }
            else if (condition == "odd")
            {
                nums = nums.Where(s => s % 2 == 1 || s % 2 == -1).ToList();
            }
            foreach (var num in nums)
            {
                Console.Write($"{num} ");
            }
        }
    }
}