using System;
using System.Collections.Generic;
using System.Text;

namespace _04.GenericSwapMethodInteger
{
    public class Box<T>
    {
        public T Value { get; set; }
        public Box(T value)
        {
            Value = value;
        }
        public override string ToString()
        {
            Type typos = Value.GetType();
            string fullName = typos.FullName;
            return $"{fullName}: {Value}";
        }
    }
}
