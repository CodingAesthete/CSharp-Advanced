using System;
using System.Collections.Generic;

namespace _08.TrafficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            Queue<string> cars = new Queue<string>();
            string input;
            int counter = 0;
            while ((input = Console.ReadLine()) != "end")
            {
                if (input != "green")
                {
                    cars.Enqueue(input);
                }
                else
                {
                    if (cars.Count > 0)
                    {
                        for (int i = 0; i < count; i++)
                        {
                            counter++;
                            Console.WriteLine($"{cars.Dequeue()} passed!");
                            if (cars.Count == 0)
                            {
                                break;
                            }
                        }
                    }

                }
            }
            Console.WriteLine($"{counter} cars passed the crossroads.");
        }
    }
}