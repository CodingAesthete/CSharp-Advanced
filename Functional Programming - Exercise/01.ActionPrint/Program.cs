using System;

namespace _01.ActionPrint
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
            string[] names = Console.ReadLine().Split();
            foreach (var name in names)
            {
                Action<string> Actio = Print(name);
                Actio(name);
            }
        }
        static Action<string> Print(string namer)
        {
            return p => Console.WriteLine($"{namer}");
        }
    }
}