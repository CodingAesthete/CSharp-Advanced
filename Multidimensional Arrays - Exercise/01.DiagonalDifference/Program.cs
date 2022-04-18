using System;
using System.Linq;

namespace _01.DiagonalDifference
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[][] matrix = new int[n][];
            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row] = new int[n];
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < input.Length; col++)
                {
                    matrix[row][col] = input[col];
                }
            }
            int sum = 0;
            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = row; col < row + 1; col++)
                {
                    sum += matrix[row][col];
                }
            }
            int sum2 = 0;
            for (int row = matrix.Length - 1; row >= 0; row--)
            {
                sum2 += matrix[row][matrix.Length - row - 1];
            }
            int total = sum - sum2;
            if (total < 0)
            {
                total = -(total);
            }
            Console.WriteLine(total);
        }
    }
}
