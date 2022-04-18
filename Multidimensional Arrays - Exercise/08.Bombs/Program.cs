using System;
using System.Linq;

namespace _08.Bombs
{
    class Program
    {
        static void Main(string[] args)
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
            string[] input2 = Console.ReadLine().Split();
            foreach (var curr in input2)
            {
                int[] coord = curr.Split(",").Select(int.Parse).ToArray();
                int row = coord[0];
                int col = coord[1];
                int damage = matrix[row, col];
                bool check = false;
                if (isValid(row, col, rows, cols) && matrix[row, col] > 0)
                {
                    check = true;
                    matrix[row, col] = 0;
                }
                if (check)
                {
                    ReduceCell(row - 1, col, matrix, damage);
                    ReduceCell(row + 1, col, matrix, damage);
                    ReduceCell(row, col - 1, matrix, damage);
                    ReduceCell(row, col + 1, matrix, damage);
                    ReduceCell(row - 1, col - 1, matrix, damage);
                    ReduceCell(row + 1, col - 1, matrix, damage);
                    ReduceCell(row - 1, col + 1, matrix, damage);
                    ReduceCell(row + 1, col + 1, matrix, damage);
                }
            }
            int count = 0;
            int sum = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] > 0)
                    {
                        count++;
                        sum += matrix[row, col];
                    }
                }
            }
            Console.WriteLine($"Alive cells: {count}");
            Console.WriteLine($"Sum: {sum}");
            PrintMatrix(matrix);
        }
        private static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[row, col]} ");
                }
                Console.WriteLine();
            }
        }
        private static void ReduceCell(int row, int col, int[,] matrix, int damage)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            if (isValid(row, col, rows, cols) && matrix[row, col] > 0)
            {
                matrix[row, col] -= damage;
            }
        }
        private static bool isValid(int row, int col, int rows, int cols)
        {
            return row >= 0 && row < rows && col >= 0 && col < cols;
        }
    }
}