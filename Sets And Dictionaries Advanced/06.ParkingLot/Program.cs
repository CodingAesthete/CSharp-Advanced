using System;
using System.Collections.Generic;

namespace _06.ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> numbers = new HashSet<string>();
            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                string[] command = input.Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string way = command[0];
                string number = command[1];
                if (way == "IN")
                {
                    numbers.Add(number);
                }
                else if (way == "OUT")
                {
                    numbers.Remove(number);
                }
            }
            if (numbers.Count > 0)
            {
                foreach (var num in numbers)
                {
                    Console.WriteLine(num);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
