using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.ThePartyReservationFilterModule
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split().ToList();
            string input;
            List<string> filters = new List<string>();
            while ((input = Console.ReadLine()) != "Print")
            {
                string[] command = input.Split(";");
                string filter = command[0];
                string type = command[1];
                string ext = command[2];
                if (filter == "Add filter")
                {
                    filters.Add($"{type};{ext}");
                }
                else if (filter == "Remove filter")
                {
                    filters.Remove($"{type};{ext}");
                }
            }
            foreach (var filter in filters)
            {
                string[] tokens = filter.Split(";");
                string type = tokens[0];
                string ext = tokens[1];
                switch (type)
                {
                    case "Starts with":
                        names = names.Where(p => !p.StartsWith(ext)).ToList();
                        break;
                    case "Ends with":
                        names = names.Where(p => !p.EndsWith(ext)).ToList();
                        break;
                    case "Length":
                        names = names.Where(p => p.Length != int.Parse(ext)).ToList();
                        break;
                    case "Contains":
                        names = names.Where(p => !p.Contains(ext)).ToList();
                        break;
                }
            }
            Console.WriteLine(String.Join(" ", names));
        }
    }
}
