using System;

namespace _07.PascalTriangle
{
    class Program
    {
        static void Main()
        {
            long n = int.Parse(Console.ReadLine());
            long[][] jagged = new long[n][];
            for (int row = 0; row < jagged.Length; row++)
            {
                jagged[row] = new long[row + 1];
                for (int col = 0; col < jagged[row].Length; col++)
                {
                    long sum = 0;
                    if (row - 1 > 0 && col < jagged[row - 1].Length)
                    {
                        sum += jagged[row - 1][col];
                    }
                    if (row - 1 > 0 && col - 1 >= 0)
                    {
                        sum += jagged[row - 1][col - 1];
                    }
                    if (sum == 0)
                    {
                        sum = 1;
                    }
                    jagged[row][col] = sum;
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
        }
    }
}
