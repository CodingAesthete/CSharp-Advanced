using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.TruckTour
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            Queue<string> data = new Queue<string>();
            for (int i = 0; i < count; i++)
            {
                data.Enqueue(Console.ReadLine());
            }
            for (int i = 0; i < data.Count; i++)
            {
                int amount = 0;
                bool check = true;
                for (int j = 0; j < data.Count; j++)
                {
                    int[] curr = data.Dequeue().Split().Select(int.Parse).ToArray();
                    data.Enqueue(String.Join(" ", curr));
                    amount += curr[0];
                    amount -= curr[1];
                    if (amount < 0)
                    {
                        check = false;
                    }
                }
                if (check == true)
                {
                    Console.WriteLine(i);
                    break;
                }
                string temp = data.Dequeue();
                data.Enqueue(temp);
            }
        }
    }
}
