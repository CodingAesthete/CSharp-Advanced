using System;
using System.Linq;

namespace _06.JaggedArrayManipulator
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            double[][] jagged = new double[n][];
            for (int row = 0; row < jagged.Length; row++)
            {
                double[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
                jagged[row] = new double[input.Length];
                for (int col = 0; col < jagged[row].Length; col++)
                {
                    jagged[row][col] = input[col];
                }
            }
            for (int row = 0; row < jagged.Length - 1; row++)
            {
                if (jagged[row].Length == jagged[row + 1].Length)
                {
                    for (int srow = row; srow < row + 2; srow++)
                    {
                        for (int scol = 0; scol < jagged[row].Length; scol++)
                        {
                            jagged[srow][scol] *= 2;
                        }
                    }
                }
                else
                {
                    for (int srow = row; srow < row + 2; srow++)
                    {
                        for (int scol = 0; scol < jagged[srow].Length; scol++)
                        {
                            jagged[srow][scol] /= 2;
                        }
                    }
                }
            }
            string input2;
            while ((input2 = Console.ReadLine()) != "End")
            {
                string[] command = input2.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                long row = long.Parse(command[1]);
                long col = long.Parse(command[2]);
                long value = long.Parse(command[3]);
                if (row >= 0 && row < jagged.Length && col >= 0 && col < jagged[row].Length)
                {
                    if (command[0] == "Add")
                    {
                        jagged[row][col] += value;
                    }
                    else if (command[0] == "Subtract")
                    {
                        jagged[row][col] -= value;
                    }
                }
                else
                {
                    continue;
                }
            }
            for (int row = 0; row < jagged.Length; row++)
            {
                for (int col = 0; col < jagged[row].Length; col++)
                {
                    Console.Write($"{jagged[row][col]} ");
                }
                Console.WriteLine();
            }
            return;
        }
    }
}