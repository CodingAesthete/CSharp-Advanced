using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.BasicQueueOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> numeros = new Queue<int>();
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int enqueues = nums[0];
            int dequeues = nums[1];
            int num = nums[2];
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            if (enqueues >= numbers.Length)
            {
                enqueues = numbers.Length;
            }
            for (int i = 0; i < enqueues; i++)
            {
                numeros.Enqueue(numbers[i]);
            }
            if (numeros.Count > 0)
            {
                for (int i = 0; i < dequeues; i++)
                {
                    numeros.Dequeue();
                    if (numeros.Count == 0)
                    {
                        break;
                    }
                }
            }
            if (numeros.Count > 0)
            {
                if (numeros.Contains(num))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine(numeros.Min());
                }
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
