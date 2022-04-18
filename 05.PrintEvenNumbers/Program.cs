using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _05.PrintEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]%2==0)
                {
                    queue.Enqueue(arr[i]);
                }
            }

            Console.WriteLine(String.Join(", ",queue));
        }
    }
}
