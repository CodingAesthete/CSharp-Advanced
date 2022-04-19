using System;
using System.Linq;

namespace _04.QuickSort
{
    class Program
    {
        public static void Main(string[] args)
        {
            long[] nums = Console.ReadLine().Split().Select(long.Parse).ToArray();

            Array.Sort(nums);
            Console.WriteLine(String.Join(" ", nums));
        }

        public static void SelectSort(long[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                int min = i;
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[j] < nums[min])
                    {
                        min = j;
                    }
                }
                Swap(nums, i, min);
            }
        }
        public static void Swap(long[] nums, int i, int j)
        {
            if (i == j)
            {
                return;
            }
            nums[i] = nums[i] ^ nums[j];
            nums[j] = nums[i] ^ nums[j];
            nums[i] = nums[i] ^ nums[j];
        }
    }
}