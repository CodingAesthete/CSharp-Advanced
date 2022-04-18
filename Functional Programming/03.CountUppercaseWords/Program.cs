using System;
using System.Linq;

namespace _03.CountUppercaseWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Where(s => s[0] == s.ToUpper()[0]).ToArray();
            Console.WriteLine(String.Join(Environment.NewLine, words));
        }
    }
}