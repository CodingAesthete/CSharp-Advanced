using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>(arr);

            string input;
            while ((input=Console.ReadLine().ToLower())!="end")
            {
                string[] strArr = input.Split();
                string command = strArr[0].ToLower();

                if (command=="add")
                {
                    stack.Push(int.Parse(strArr[1]));
                    stack.Push(int.Parse(strArr[2]));
                }
                else if (command=="remove")
                {
                    int numsToRemove = int.Parse(strArr[1]);

                    if (numsToRemove<=stack.Count)
                    {
                        for (int i = 0; i < numsToRemove; i++)
                        {
                            stack.Pop();
                        }
                    }
                }
            }

            Console.WriteLine($"Sum: {stack.ToArray().Sum()}");
        }
    }
}
