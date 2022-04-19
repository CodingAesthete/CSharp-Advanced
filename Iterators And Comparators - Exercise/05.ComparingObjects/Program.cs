using System;
using System.Collections.Generic;

namespace _05.ComparingObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                string[] command = input.Split();
                int age = int.Parse(command[1]);
                Person person = new Person(command[0], age, command[2]);
                people.Add(person);
            }
            int index = int.Parse(Console.ReadLine()) - 1;
            int equal = 0;
            int diff = 0;
            foreach (var item in people)
            {
                if (item.CompareTo(people[index]) == 0)
                {
                    equal++;
                }
                else
                {
                    diff++;
                }
            }
            if (equal < 2)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine($"{equal} {diff} {equal + diff}");
            }
        }
    }
}