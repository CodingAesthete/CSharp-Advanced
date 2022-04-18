using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.KnightsOfHonour
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split().ToList();
            names = names.Select(n => $"Sir {n}").ToList();
            Action<List<string>> Print = a => Console.WriteLine(string.Join(Environment.NewLine, a));
            Print(names);
        }
    }
}
