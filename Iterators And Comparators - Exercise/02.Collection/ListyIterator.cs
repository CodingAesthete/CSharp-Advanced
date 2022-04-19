using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _02.Collection
{
    public class ListyIterator<T> : IEnumerable<T>
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

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in List)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}