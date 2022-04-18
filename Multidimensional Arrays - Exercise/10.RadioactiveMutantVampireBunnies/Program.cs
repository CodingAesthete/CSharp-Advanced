using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.RadioactiveMutantVampireBunnies
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = input[0];
            int cols = input[1];
            char[,] field = new char[rows, cols];
            int playerRow = -1;
            int playerCol = -1;
            for (int row = 0; row < rows; row++)
            {
                char[] input2 = Console.ReadLine().ToCharArray();
                for (int col = 0; col < cols; col++)
                {
                    field[row, col] = input2[col];
                    if (field[row, col] == 'P')
                    {
                        playerRow = row;
                        playerCol = col;
                    }
                }
            }
            bool isWin = false;
            bool isDead = false;
            char[] directions = Console.ReadLine().ToCharArray();
            foreach (var direction in directions)
            {
                int newPlayerRow = playerRow;
                int newPlayerCol = playerCol;
                if (direction == 'U')
                {
                    newPlayerRow--;
                }
                else if (direction == 'D')
                {
                    newPlayerRow++;
                }
                else if (direction == 'L')
                {
                    newPlayerCol--;
                }
                else if (direction == 'R')
                {
                    newPlayerCol++;
                }
                if (!isValid(newPlayerRow, newPlayerCol, rows, cols))
                {
                    field[playerRow, playerCol] = '.';
                    isWin = true;
                    List<int[]> bunniesCoordinates = GetBunniesCoordinates(field);
                    SpreadBunnies(bunniesCoordinates, field);
                }
                else if (field[newPlayerRow, newPlayerCol] == '.')
                {
                    field[newPlayerRow, newPlayerCol] = 'P';
                    field[playerRow, playerCol] = '.';
                    playerRow = newPlayerRow;
                    playerCol = newPlayerCol;
                    List<int[]> bunniesCoordinates = GetBunniesCoordinates(field);
                    SpreadBunnies(bunniesCoordinates, field);
                    if (field[playerRow, playerCol] == 'B')
                    {
                        isDead = true;
                    }
                }
                else if (field[newPlayerRow, newPlayerCol] == 'B')
                {
                    isDead = true;
                    field[playerRow, playerCol] = '.';
                    playerRow = newPlayerRow;
                    playerCol = newPlayerCol;
                    List<int[]> bunniesCoordinates = GetBunniesCoordinates(field);
                    SpreadBunnies(bunniesCoordinates, field);
                }
                if (isWin || isDead)
                {
                    break;
                }
            }
            PrintField(field);
            string res = "";
            if (isWin)
            {
                res += "won: ";
            }
            else if (isDead)
            {
                res += "dead: ";
            }
            res += $"{playerRow} {playerCol}";
            Console.WriteLine(res);
        }

        private static void PrintField(char[,] field)
        {
            for (int row = 0; row < field.GetLength(0); row++)
            {
                for (int col = 0; col < field.GetLength(1); col++)
                {
                    Console.Write(field[row, col]);
                }
                Console.WriteLine();
            }
        }

        private static void SpreadBunnies(List<int[]> bunniesCoordinates, char[,] field)
        {
            foreach (int[] bunnyCoordinate in bunniesCoordinates)
            {
                int row = bunnyCoordinate[0];
                int col = bunnyCoordinate[1];
                SpreadBunny(row - 1, col, field);
                SpreadBunny(row + 1, col, field);
                SpreadBunny(row, col - 1, field);
                SpreadBunny(row, col + 1, field);
            }
        }

        private static void SpreadBunny(int row, int col, char[,] field)
        {
            int rows = field.GetLength(0);
            int cols = field.GetLength(1);
            if (isValid(row, col, rows, cols))
            {
                field[row, col] = 'B';
            }
        }

        private static List<int[]> GetBunniesCoordinates(char[,] field)
        {
            List<int[]> bunniesCoordinates = new List<int[]>();
            for (int row = 0; row < field.GetLength(0); row++)
            {
                for (int col = 0; col < field.GetLength(1); col++)
                {
                    if (field[row, col] == 'B')
                    {
                        bunniesCoordinates.Add(new int[] { row, col });
                    }
                }
            }
            return bunniesCoordinates;
        }

        private static bool isValid(int row, int col, int rows, int cols)
        {
            return row >= 0 && row < rows && col >= 0 && col < cols;
        }
    }
}
