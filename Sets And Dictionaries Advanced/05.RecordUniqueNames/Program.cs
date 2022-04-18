using System;
using System.Collections.Generic;

namespace _05.RecordUniqueNames
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> people = new HashSet<string>();
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                string input = Console.ReadLine();
                people.Add(input);
            }
            foreach (var person in people)
            {
                Console.WriteLine(person);
            }
        }
    }
}
