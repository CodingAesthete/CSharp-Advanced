using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.PredicateParty
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> input = Console.ReadLine()
                .Split()
                .ToList();

            while (true)
            {
                List<string> command = Console.ReadLine()
                    .Split()
                    .ToList();

                if (command[0] == "Remove")
                {
                    input.RemoveAll(x =>
                    {
                        if (command[1] == "StartsWith")
                            return x.StartsWith(command[2]);

                        else if (command[1] == "EndsWith")
                            return x.EndsWith(command[2]);

                        else if (command[1] == "Length")
                            return x.Length == int.Parse(command[2]);

                        else return false;
                    });
                }

                if (command[0] == "Double")
                {
                    if (command[1] == "StartsWith")
                    {
                        List<string> startsWith = input.Where(x => x.StartsWith(command[2])).ToList();

                        int index = input.FindIndex(x => x.StartsWith(command[2]));

                        if (index != -1) // Валидация на индекса
                        {
                            input.InsertRange(index, startsWith);
                        }
                    }
                    else if (command[1] == "EndsWith")
                    {
                        List<string> endsWith = input.Where(x => x.EndsWith(command[2])).ToList();

                        int index = input.FindIndex(x => x.EndsWith(command[2]));

                        if (index != -1) // Валидация на индекса
                        {
                            input.InsertRange(index, endsWith);
                        }

                    }
                    else if (command[1] == "Length")
                    {
                        List<string> doubleLength = input.Where(x => x.Length == int.Parse(command[2])).ToList();

                        int index = input.FindIndex(x => x.Length == int.Parse(command[2]));

                        if (index != -1) // Валидация на индекса
                        {
                            input.InsertRange(index, doubleLength);
                        }
                    }
                }

                else if (command[0] == "Party!")
                    break;
            }

            if (input.Count != 0)
            {
                Console.Write(string.Join(", ", input));
                Console.WriteLine(" are going to the party!");
            }

            else Console.WriteLine("Nobody is going to the party!");
        }
    }
}
