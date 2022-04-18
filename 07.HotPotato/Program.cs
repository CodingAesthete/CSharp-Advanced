using System;
using System.Collections.Generic;

namespace _07.HotPotato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(); //Alva James William
            int num = int.Parse(Console.ReadLine());
            Queue<string> kids = new Queue<string>(input);
            int toss = 0;
            while (kids.Count > 1)
            {
                toss++;
                string kid = kids.Dequeue();
                if (toss == num)
                {
                    Console.WriteLine($"Removed {kid}");
                    toss = 0;
                }
                else
                {
                    kids.Enqueue(kid);
                }
            }
            Console.WriteLine($"Last is {kids.Dequeue()}");
        }
    }
}