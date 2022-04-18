using System;
using System.Linq;

namespace _04.MatrixShuffling
{
    class Program
    {
        static void Main()
        {
            int[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = input[0];
            int cols = input[1];
            string[,] matrix = new string[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                string[] input2 = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = input2[col];
                }
            }
            string input3;
            while ((input3 = Console.ReadLine()) != "END")
            {
                string[] command = input3.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (command[0] != "swap")
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }
                else
                {
                    if (command.Length != 5)
                    {
                        Console.WriteLine("Invalid input!");
                        continue;
                    }
                    int prow = int.Parse(command[1]);
                    int pcol = int.Parse(command[2]);
                    int srow = int.Parse(command[3]);
                    int scol = int.Parse(command[4]);
                    if (prow < 0 || prow > rows - 1 ||
                        pcol < 0 || pcol > cols - 1 ||
                        srow < 0 || srow > rows - 1 ||
                        scol < 0 || scol > cols - 1)
                    {
                        Console.WriteLine("Invalid input!");
                        continue;
                    }
                    else
                    {
                        string first = matrix[prow, pcol];
                        string second = matrix[srow, scol];
                        matrix[prow, pcol] = second;
                        matrix[srow, scol] = first;
                        for (int row = 0; row < rows; row++)
                        {
                            for (int col = 0; col < cols; col++)
                            {
                                Console.Write($"{matrix[row, col]} ");
                            }
                            Console.WriteLine();
                        }
                    }
                }
            }
        }
    }
}
