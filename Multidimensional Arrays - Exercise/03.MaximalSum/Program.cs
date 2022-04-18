using System;
using System.Linq;

namespace _03.MaximalSum
{
    class Program
    {
        static void Main()
        {
            int[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = input[0];
            int cols = input[1];
            int[,] matrix = new int[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                int[] input2 = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = input2[col];
                }
            }
            int max = int.MinValue;
            int mrow = 0;
            int mcol = 0;
            for (int row = 0; row < rows - 2; row++)
            {
                for (int col = 0; col < cols - 2; col++)
                {
                    int sum = 0;
                    for (int srow = row; srow < row + 3; srow++)
                    {
                        for (int scol = col; scol < col + 3; scol++)
                        {
                            sum += matrix[srow, scol];
                        }
                    }
                    if (sum > max)
                    {
                        max = sum;
                        mrow = row;
                        mcol = col;
                    }
                }
            }
            Console.WriteLine($"Sum = {max}");
            for (int row = mrow; row < mrow + 3; row++)
            {
                for (int col = mcol; col < mcol + 3; col++)
                {
                    Console.Write($"{matrix[row, col]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
