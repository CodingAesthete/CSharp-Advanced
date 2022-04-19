using System;

namespace _02.GenericBoxOfInteger
{
    public class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                Box<int> boxi = new Box<int>(int.Parse(Console.ReadLine()));
                Console.WriteLine(boxi.ToString());
            }
        }
    }
}
