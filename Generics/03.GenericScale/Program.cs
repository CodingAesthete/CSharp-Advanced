using System;

namespace _03.GenericScale
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            EqualityScale<int> scale = new EqualityScale<int>(5, 6);
            bool check = scale.AreEqual();
            Console.WriteLine(check);
        }
    }
}

