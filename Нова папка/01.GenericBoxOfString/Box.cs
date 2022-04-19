using System;
using System.Collections.Generic;
using System.Text;

namespace _01.GenericBoxOfString
{
    public class Box<T>
    {
        public T value { get; set; }
        public Box(T value)
        {
            this.value = value;
        }
        public void ToString()
        {
            Console.WriteLine($"{value.GetType()}: {value}");
        }
    }
}
