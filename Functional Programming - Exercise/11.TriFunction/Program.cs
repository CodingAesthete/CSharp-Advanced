using System;

namespace _11.TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Split();
            Func<string, int, bool> Check = Funktio;
            foreach (var name in names)
            {
                if (Check(name, count))
                {
                    Console.WriteLine(name);
                    return;
                }
            }
        }

        static bool Funktio(string name, int count)
        {
            int counte = 0;
            for (int i = 0; i < name.Length; i++)
            {
                counte += name[i];
            }
            if (counte < count)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
