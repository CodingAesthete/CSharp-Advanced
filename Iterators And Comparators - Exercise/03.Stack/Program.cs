using System;
using System.Linq;

namespace _03.Stack
{
    public class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stacko = new Stack<int>();
            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                string[] command = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (command[0] == "Push")
                {
                    int[] elements = command.Skip(1).Select(s => s.Split(",").First()).Select(int.Parse).ToArray();
                    stacko.Push(elements.ToList());
                }
                else if (command[0] == "Pop")
                {
                    try
                    {
                        stacko.Pop();
                    }
                    catch (InvalidOperationException ex)
                    {

                        Console.WriteLine(ex.Message);
                    }
                }
            }
            foreach (var item in stacko)
            {
                Console.WriteLine(item);
            }
            foreach (var item in stacko)
            {
                Console.WriteLine(item);
            }
        }
    }
}