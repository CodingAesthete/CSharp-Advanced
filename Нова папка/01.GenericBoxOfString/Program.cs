using System;

namespace _01.GenericBoxOfString
{
    public class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                Box<string> name = new Box<string>(Console.ReadLine());
                name.ToString();
            }
        }
    }
}

