using System;
using System.Collections.Generic;

namespace _03.OldestFamilyMember
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            int count = int.Parse(Console.ReadLine());
            Family family = new Family();
            for (int i = 0; i < count; i++)
            {
                string[] splitted = Console.ReadLine().Split();
                string name = splitted[0];
                int age = int.Parse(splitted[1]);
                Person person = new Person(name, age);
                family.AddMember(person);
            }
            Person persono = family.GetOldestMember();
            Console.WriteLine($"{persono.Name} {persono.Age}");
        }
    }
}
