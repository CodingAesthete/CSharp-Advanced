using System;
using System.Linq;

namespace _08.Threeuple
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] firstArray = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string names = firstArray[0] + " " + firstArray[1];
            string address = firstArray[2];
            firstArray = firstArray.Skip(3).ToArray();
            string town = String.Join(" ", firstArray);
            Threeuple<string, string, string> threeuple1 = new Threeuple<string, string, string>(names, address, town);
            string[] secondArray = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string name = secondArray[0];
            int litresOfBeer = int.Parse(secondArray[1]);
            bool drunk = secondArray[2] == "drunk" ? true : false;
            Threeuple<string, int, bool> threeuple2 = new Threeuple<string, int, bool>(name, litresOfBeer, drunk);
            string[] thirdArray = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string namer = thirdArray[0];
            double accountBalance = double.Parse(thirdArray[1]);
            string bankName = thirdArray[2];
            Threeuple<string, double, string> threeuple3 = new Threeuple<string, double, string>(namer, accountBalance, bankName);
            Console.WriteLine(threeuple1);
            Console.WriteLine(threeuple2);
            Console.WriteLine(threeuple3);
        }
    }
}
