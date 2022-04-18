using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MaximumAndMinimumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> nums = new Stack<int>();
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                int[] coms = Console.ReadLine().Split().Select(int.Parse).ToArray();
                if (coms[0] == 1)
                {
                    nums.Push(coms[1]);
                }
                else if (coms[0] == 2)
                {
                    if (nums.Count > 0)
                    {
                        nums.Pop();
                    }
                }
                else if (coms[0] == 3)
                {
                    if (nums.Count > 0)
                    {
                        Console.WriteLine(nums.Max());
                    }
                }
                else if (coms[0] == 4)
                {
                    if (nums.Count > 0)
                    {
                        Console.WriteLine(nums.Min());
                    }
                }
            }
            Console.WriteLine(String.Join(", ", nums.ToList()));
        }
    }
}
