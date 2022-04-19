using System;
using System.Collections.Generic;
using System.Text;

namespace _01.Box
{
    public class Box<T>
    {
        public int Count => stacko.Count;
        public Stack<T> stacko { get; set; }
        public Box()
        {
            stacko = new Stack<T>();
        }
        public void Add(T element)
        {
            stacko.Push(element);
        }
        public T Remove()
        {
            return stacko.Pop();
        }
    }
}
