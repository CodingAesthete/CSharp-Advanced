using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _03.Stack
{
    public class Stack<T> : IEnumerable<T>
    {
        private int index = -1;
        public List<T> Elements { get; set; }
        public Stack()
        {
            Elements = new List<T>();
        }
        public void Push(List<T> elements)
        {
            foreach (var item in elements)
            {
                ++index;
                Elements.Insert(index, item);
            }
        }
        public void Pop()
        {
            if (index < 0)
            {
                throw new InvalidOperationException("No elements");
            }
            index--;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = index; i >= 0; i--)
            {
                yield return Elements[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}