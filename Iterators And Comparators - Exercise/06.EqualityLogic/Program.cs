using System;
using System.Collections.Generic;

namespace _06.EqualityLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<Person> people = new HashSet<Person>();
            SortedSet<Person> people2 = new SortedSet<Person>();
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                string[] input = Console.ReadLine().Split();
                string name = input[0];
                int age = int.Parse(input[1]);
                Person person = new Person(name, age);
                people.Add(person);
                people2.Add(person);
            }
            Console.WriteLine(people2.Count);
            Console.WriteLine(people.Count);
        }
    }
}