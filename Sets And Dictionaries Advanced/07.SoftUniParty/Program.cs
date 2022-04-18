using System;
using System.Collections.Generic;

namespace _08.SoftUniParty
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> invited = new HashSet<string>();
            string input;
            while ((input = Console.ReadLine()) != "PARTY")
            {
                invited.Add(input);
            }
            string input2;
            while ((input2 = Console.ReadLine()) != "END")
            {
                invited.Remove(input2);
            }
            Console.WriteLine(invited.Count);
            foreach (var item in invited)
            {
                char[] num = item.ToCharArray();
                char start = num[0];
                if (char.IsDigit(start))
                {
                    Console.WriteLine(item);
                }
            }
            foreach (var item in invited)
            {
                char[] num = item.ToCharArray();
                char start = num[0];
                if (char.IsLetter(start))
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}