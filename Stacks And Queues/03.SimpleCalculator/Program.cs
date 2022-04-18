using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split().Reverse().ToArray();
            Stack<string> stack = new Stack<string>();

            for (int i = 0; i < arr.Length; i++)
            {
                stack.Push(arr[i]);
            }

            while (stack.Count>1)
            {
                int firstNum = int.Parse(stack.Pop());
                string sign = stack.Pop();
                int secondNum = int.Parse(stack.Pop());

                if (sign=="+")
                {
                    stack.Push((firstNum + secondNum).ToString());
                }
                else if (sign == "-")
                {
                    stack.Push((firstNum - secondNum).ToString());
                }
            }

            Console.WriteLine(stack.Pop());
        }
    }
}
