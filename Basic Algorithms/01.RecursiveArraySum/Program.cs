using System;
using System.Linq;

namespace _01.RecursiveArraySum
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int result = Sum(nums, 0);
            Console.WriteLine(result);
        }

        private static int Sum(int[] nums, int index)
        {
            if (index == nums.Length - 1)
            {
                return nums[index];
            }
            return nums[index] + Sum(nums, index + 1);
        }
    }
}