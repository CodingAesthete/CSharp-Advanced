using System;
using System.Linq;

namespace _03.PrimaryDiagonal
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int rows = n;
            int cols = n;
            int[,] matrix = new int[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = input[col];
                }
            }
            int sum = 0;
            for (int row = 0; row < rows; row++)
            {
                for (int col = row; col < row + 1; col++)
                {
                    int curr = matrix[row, col];
                    sum += curr;
                }
            }
            Console.WriteLine(sum);
        }
    }
}