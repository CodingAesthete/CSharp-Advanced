using System;
using System.Linq;

namespace _08.ListOfPredicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int[] deviders = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Func<int[], int, bool> tester = Devider;
            for (int i = 1; i <= num; i++)
            {
                if (Devider(deviders, i) == true)
                {
                    Console.Write($"{i} ");
                }
            }
        }
        static bool Devider(int[] deviders, int num)
        {
            bool check = true;
            foreach (var devider in deviders)
            {
                if (num % devider != 0)
                {
                    check = false;
                }
            }
            return check;
        }
    }
}
