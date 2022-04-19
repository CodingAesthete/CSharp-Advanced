using System;
using System.Collections.Generic;

namespace _06.GenericCountMethodDouble
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<double> boxes = new List<double>();
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                Box<double> box = new Box<double>(double.Parse(Console.ReadLine()));
                boxes.Add(box.Value);
            }
            double raw = double.Parse(Console.ReadLine());
            Console.WriteLine(ReturnCount(boxes, raw));
        }
        static int ReturnCount<T>(List<T> boxes, T raw) where T : IComparable<T>
        {
            int count = 0;
            for (int i = 0; i < boxes.Count; i++)
            {
                int diff = boxes[i].CompareTo(raw);
                if (diff > 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}