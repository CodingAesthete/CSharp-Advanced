using System;

namespace _02.ArrayCreator
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] elements = ArrayCreator.Create(5, "Pesho");
            int[] integers = ArrayCreator.Create(10, 33);
            Console.WriteLine(elements.Length);
            Console.WriteLine(integers.Length);
        }
    }
}

