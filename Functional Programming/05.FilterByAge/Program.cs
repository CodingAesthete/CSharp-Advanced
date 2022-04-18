using System;

namespace _05.FilterByAge
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
            int n = int.Parse(Console.ReadLine());
            Person[] person = new Person[n];
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
                person[i] = new Person() { Name = input[0], Age = int.Parse(input[1]) };
            }
            string condition = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string format = Console.ReadLine();
            Func<Person, bool> Condition = GetCondition(condition, age);
            Action<Person> PrintResult = PrintDelegate(format);
            Printer(person, Condition, PrintResult);
        }
        static void Printer(Person[] person, Func<Person, bool> fiction, Action<Person> fiction2)
        {
            foreach (var persono in person)
            {
                if (fiction(persono))
                {
                    fiction2(persono);
                }
            }
        }

        static Action<Person> PrintDelegate(string format)
        {
            switch (format)
            {
                case "name":
                    return p =>
                    {
                        Console.WriteLine($"{p.Name}");
                    };
                case "age":
                    return p =>
                    {
                        Console.WriteLine($"{p.Age}");
                    };
                case "name age":
                    return p =>
                    {
                        Console.WriteLine($"{p.Name} - {p.Age}");
                    };
                default: return null;
            }
        }

        static Func<Person, bool> GetCondition(string condition, int age)
        {
            switch (condition)
            {
                case "younger": return p => p.Age < age;
                case "older": return p => p.Age >= age;
                default: return null;
            }
        }
    }
}
