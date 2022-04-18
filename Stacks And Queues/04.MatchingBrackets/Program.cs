using System;
using System.Collections.Generic;

namespace _04.MatchingBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string arr = Console.ReadLine();
            Stack<int> indexes = new Stack<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]=='(')
                {
                    indexes.Push(i);
                }
                else if (arr[i] == ')')
                {
                    int startIndex = indexes.Pop();
                    string bracketsStr = arr.Substring(startIndex, i - startIndex + 1);
                    Console.WriteLine(bracketsStr);
                }
            }
        }
    }
}
