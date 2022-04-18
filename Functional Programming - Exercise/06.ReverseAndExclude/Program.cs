using System;
using System.Linq;

namespace _06.ReverseAndExclude
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                if (command == "add")
                {
                    nums = nums.Select(s => s + 1).ToArray();
                }
                else if (command == "subtract")
                {
                    nums = nums.Select(s => s - 1).ToArray();
                }
                else if (command == "print")
                {
                    Console.WriteLine(String.Join(" ", nums));
                }
            }
        }
    }
}
