using System;

namespace _01.BasicStackOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> numeros = new Stack<int>();
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int pushes = nums[0];
            int pops = nums[1];
            int num = nums[2];
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            if (pushes >= numbers.Length)
            {
                pushes = numbers.Length;
            }
            for (int i = 0; i < pushes; i++)
            {
                numeros.Push(numbers[i]);
            }
            if (pops <= numeros.Count)
            {
                for (int i = 0; i < pops; i++)
                {
                    numeros.Pop();
                }
            }
            else
            {
                pops = numeros.Count;
                for (int i = 0; i < pops; i++)
                {
                    numeros.Pop();
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