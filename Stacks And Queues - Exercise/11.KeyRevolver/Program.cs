using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.KeyRevolver
{
    class Program
    {
        static void Main()
        {
            int priceBullet = int.Parse(Console.ReadLine());
            int sizeGunBarrel = int.Parse(Console.ReadLine());
            int[] input1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] input2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int intel = int.Parse(Console.ReadLine());
            Stack<int> bullets = new Stack<int>(input1);
            Queue<int> locks = new Queue<int>(input2);
            int times = sizeGunBarrel;
            while (bullets.Any() && locks.Any())
            {
                int currbullet = bullets.Pop();
                intel -= priceBullet;
                times--;
                int currlock = locks.Peek();
                if (currbullet <= currlock)
                {
                    Console.WriteLine("Bang!");
                    locks.Dequeue();
                }
                else
                {
                    Console.WriteLine("Ping!");
                }
                if (times == 0)
                {
                    if (bullets.Count > 0)
                    {
                        Console.WriteLine("Reloading!");
                        times = sizeGunBarrel;
                    }
                }
            }
            if (locks.Count == 0)
            {
                Console.WriteLine($"{bullets.Count} bullets left. Earned ${intel}");
            }
            else
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
            }
        }
    }
}