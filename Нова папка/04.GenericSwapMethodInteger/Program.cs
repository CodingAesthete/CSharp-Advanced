using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.GenericSwapMethodInteger
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Box<int>> boxes = new List<Box<int>>();
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                Box<int> box = new Box<int>(int.Parse(Console.ReadLine()));
                boxes.Add(box);
            }
            int[] indexes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            SwapElements(boxes, indexes[0], indexes[1]);
            Console.WriteLine(String.Join(Environment.NewLine, boxes));
        }
        static void SwapElements<T>(List<Box<T>> boxes, int firstIndex, int secondIndex)
        {
            Box<T> temp = boxes[firstIndex];
            boxes[firstIndex] = boxes[secondIndex];
            boxes[secondIndex] = temp;
        }
    }
}
