using System;
using System.Collections.Generic;
using System.Text;

namespace _05.GenericCountMethodString
{
    public class Box<T>
    {
        public int Count { get; set; }
        public T Value { get; set; }
        public Box(T value)
        {
            Value = value;
            Count = value.ToString().Length;
        }
        public override string ToString()
        {
            Type typos = Value.GetType();
            string fullName = typos.FullName;
            return $"{fullName}: {Value}";
        }
    }
}
