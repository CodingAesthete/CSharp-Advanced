using System;
using System.Linq;

namespace _07.PredicateForNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Func<string, bool> name = s => s.Length <= n;
            string[] names = Console.ReadLine().Split().Where(name).ToArray();
            Console.WriteLine(String.Join(Environment.NewLine, names));
        }
    }
}
