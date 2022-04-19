using System;
using System.Collections.Generic;

namespace _05.GenericCountMethodString
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> boxes = new List<string>();
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                Box<string> box = new Box<string>(Console.ReadLine());
                boxes.Add(box.Value);
            }
            string raw = Console.ReadLine();
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