using System;
using System.Linq;

namespace _01.ListyIterator
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] first = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Skip(1).ToArray();
            ListyIterator<string> list = new ListyIterator<string>(first.ToList());
            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                if (input == "Move")
                {
                    Console.WriteLine(list.Move());
                }
                else if (input == "HasNext")
                {
                    Console.WriteLine(list.HasNext());
                }
                else if (input == "Print")
                {
                    try
                    {
                        list.Print();
                    }
                    catch (InvalidOperationException ex)
                    {

                        Console.WriteLine(ex.Message);
                    }
                }
            }
        }
    }
}

