using System;

namespace _05.DateModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            string dateOneStr = Console.ReadLine();
            string dateTwoStr = Console.ReadLine();
            int diff = DateModifier.GetDiff(dateOneStr, dateTwoStr);
            Console.WriteLine(diff);
        }
    }
}

