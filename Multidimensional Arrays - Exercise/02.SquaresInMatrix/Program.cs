using System;
using System.Linq;

namespace _02.SquaresInMatrix
{
    class Program
    {
        static void Main()
        {
            long[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToArray();
            long rows = input[0];
            long cols = input[1];
            char[,] matrix = new char[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                char[] input2 = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = input2[col];
                }
            }
            int count = 0;
            for (int row = 0; row < rows - 1; row++)
            {
                for (int col = 0; col < cols - 1; col++)
                {
                    char a = matrix[row, col];
                    char b = matrix[row, col + 1];
                    char c = matrix[row + 1, col];
                    char d = matrix[row + 1, col + 1];
                    if (a == b && a == c && a == d)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}