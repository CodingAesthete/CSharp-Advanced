using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantity = int.Parse(Console.ReadLine());
            Queue<int> nums = new Queue<int>();
            Queue<int> left = new Queue<int>();
            int[] orders = Console.ReadLine().Split().Select(int.Parse).ToArray();
            bool check = true;
            for (int i = 0; i < orders.Length; i++)
            {
                int current = orders[i];
                int sum = nums.Sum();
                if (current + sum <= quantity)
                {
                    if (check == true)
                    {
                        nums.Enqueue(current);
                    }
                    else
                    {
                        left.Enqueue(current);
                    }
                }
                else if (current + sum > quantity)
                {
                    check = false;
                    left.Enqueue(current);
                }
            }
            int max1 = 0;
            int max2 = 0;
            if (left.Count > 0)
            {
                max1 = left.Max();
            }
            if (nums.Count > 0)
            {
                max2 = nums.Max();
            }
            Console.WriteLine(Math.Max(max1, max2));
            if (left.Count > 0)
            {
                Console.WriteLine($"Orders left: {String.Join(" ", left.ToList())}");
            }
            else
            {
                Console.WriteLine("Orders complete");
            }
        }
    }
}