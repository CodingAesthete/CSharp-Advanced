using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int spec = int.Parse(Console.ReadLine());
            Stack<int> rack = new Stack<int>();
            int counter = 1;
            for (int i = 0; i < nums.Length; i++)
            {
                int current = nums[i];
                if (rack.Sum() + current < spec)
                {
                    rack.Push(current);
                }
                else if (rack.Sum() + current == spec)
                {
                    rack.Push(current);
                    rack.Clear();
                    if (i != nums.Length - 1)
                    {
                        counter++;
                    }
                }
                else if (rack.Sum() + current > spec)
                {
                    rack.Clear();
                    rack.Push(current);
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
