using System;

namespace _07.Tuple
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] firstArray = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string names = firstArray[0] + " " + firstArray[1];
            string town = firstArray[2];
            MyTuple<string, string> firstTuple = new MyTuple<string, string>(names, town);
            string[] secondArray = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string name = secondArray[0];
            int litresOfBeer = int.Parse(secondArray[1]);
            MyTuple<string, int> secondTuple = new MyTuple<string, int>(name, litresOfBeer);
            string[] thirdArray = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int integer = int.Parse(thirdArray[0]);
            double doubleNum = double.Parse(thirdArray[1]);
            MyTuple<int, double> thirdTuple = new MyTuple<int, double>(integer, doubleNum);
            Console.WriteLine(firstTuple);
            Console.WriteLine(secondTuple);
            Console.WriteLine(thirdTuple);
        }
    }
}
