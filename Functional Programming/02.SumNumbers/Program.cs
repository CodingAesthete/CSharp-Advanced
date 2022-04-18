using System;
using System.Linq;

namespace _02.SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(s =>
            {
                return int.Parse(s);
            }).ToArray();
            Func<int[], int> Sum = SumDelegate;
            Func<int[], int> Count = CountDelegate;
            PrintResult(Count, Sum, nums);
        }
        static int CountDelegate(int[] nums)
        {
            return nums.Count();
        }
        static int SumDelegate(int[] nums)
        {
            return nums.Sum();
        }
        static void PrintResult(Func<int[], int> count, Func<int[], int> sum, int[] nums)
        {
            Console.WriteLine(count(nums));
            Console.WriteLine(sum(nums));
        }
    }
}
