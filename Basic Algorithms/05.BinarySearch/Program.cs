using System;
using System.Linq;

namespace _05.BinarySearch
{
    class Program
    {
        private const int KEY_NOT_FOUND = -1;
        public static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int num = int.Parse(Console.ReadLine());
            int result = Binary(nums, num, 0, nums.Length - 1);
            Console.WriteLine(result);
        }

        private static int Binary(int[] nums, int key, int start, int end)
        {
            while (end >= start)
            {
                int middle = (start + end) / 2;
                if (key > nums[middle])
                {
                    start = middle + 1;
                }
                else if (key < nums[middle])
                {
                    end = middle - 1;
                }
                else
                {
                    return middle;
                }
            }
            return KEY_NOT_FOUND;
        }
    }
}
