using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.OpinionPoll
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                string[] splitted = Console.ReadLine().Split();
                string name = splitted[0];
                int age = int.Parse(splitted[1]);
                Person person = new Person(name, age);
                people.Add(person);
            }
            foreach (var person in people.OrderBy(s => s.Name).Where(s => s.Age > 30))
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}
