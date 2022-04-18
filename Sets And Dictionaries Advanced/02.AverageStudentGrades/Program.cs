using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.AverageStudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<decimal>> sorted = new Dictionary<string, List<decimal>>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = input[0];
                decimal note = decimal.Parse(input[1]);
                if (!sorted.ContainsKey(name))
                {
                    sorted.Add(name, new List<decimal>());
                }
                sorted[name].Add(note);
            }
            foreach (var student in sorted)
            {
                Console.Write($"{student.Key} -> ");
                foreach (var note in student.Value)
                {
                    Console.Write($"{note:f2} ");
                }
                Console.Write($"(avg: {(student.Value.Average()):f2})");
                Console.WriteLine();
            }
        }
    }
}