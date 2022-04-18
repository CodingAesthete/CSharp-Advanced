using System;

namespace _04.SymbolInMatrix
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int rows = n;
            int cols = n;
            char[,] matrix = new char[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                string input = Console.ReadLine();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = input[col];
                }
            }
            char sign = char.Parse(Console.ReadLine());
            bool check = false;
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    char curr = matrix[row, col];
                    if (curr == sign)
                    {
                        check = true;
                        Console.WriteLine($"({row}, {col})");
                        return;
                    }
                }
            }
            if (check == false)
            {
                Console.WriteLine($"{sign} does not occur in the matrix");
            }
        }
    }
}
