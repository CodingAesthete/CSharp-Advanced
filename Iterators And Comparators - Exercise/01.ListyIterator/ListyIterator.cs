using System;
using System.Collections.Generic;
using System.Text;

namespace _01.ListyIterator
{
    public class ListyIterator<T>
    {
        private int index = 0;
        public List<T> List { get; set; }
        public ListyIterator(List<T> list)
        {
            List = list;
        }
        public bool Move()
        {
            if (index < List.Count - 1)
            {
                index++;
                return true;
            }
            return false;
        }
        public bool HasNext()
        {
            if (index < List.Count - 1)
            {
                return true;
            }
            return false;
        }
        public void Print()
        {
            if (index >= List.Count)
            {
                throw new InvalidOperationException("Invalid Operation!");
            }
            Console.WriteLine(List[index]);
        }
    }
}