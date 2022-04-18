using System;
using System.Linq;

namespace _06.JaggedArrayModification
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[][] jagged = new int[n][];
            for (int row = 0; row < n; row++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                jagged[row] = new int[input.Length];
                for (int col = 0; col < jagged[row].Length; col++)
                {
                    jagged[row][col] = input[col];
                }
            }
            string input2;
            while ((input2 = Console.ReadLine()) != "END")
            {
                string[] command = input2.Split();
                int row = int.Parse(command[1]);
                int col = int.Parse(command[2]);
                int num = int.Parse(command[3]);
                if (row >= 0 && col >= 0 && row < n && col < n)
                {
                    if (command[0] == "Add")
                    {
                        jagged[row][col] += num;
                    }
                    else if (command[0] == "Subtract")
                    {
                        jagged[row][col] -= num;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid coordinates");
                }
            }
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write($"{jagged[row][col]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
