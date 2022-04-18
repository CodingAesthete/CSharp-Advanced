using System;
using System.Linq;

namespace _05.SnakeMoves
{
    class Program
    {
        static void Main()
        {

            int[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            string input2 = Console.ReadLine();
            int rows = input[0];
            int cols = input[1];
            char[,] matrix = new char[rows, cols];
            int counter = -1;
            for (int row = 0; row < rows; row++)
            {
                if (row % 2 == 0)
                {
                    for (int col = 0; col < cols; col++)
                    {
                        counter++;
                        if (counter > input2.Length - 1)
                        {
                            counter = 0;
                        }
                        matrix[row, col] = input2[counter];

                    }
                }
                else
                {
                    for (int col = cols - 1; col >= 0; col--)
                    {

                        counter++;
                        if (counter > input2.Length - 1)
                        {
                            counter = 0;
                        }
                        matrix[row, col] = input2[counter];
                    }
                }
            }
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}