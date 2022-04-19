using System;
using System.Collections.Generic;
using System.Text;

namespace _03.GenericSwapMethodString
{
    public class Box<T>
    {
        public T value { get; set; }
        public Box(T value)
        {
            this.value = value;
        }
        public override string ToString()
        {
            Type typos = value.GetType();
            string fullName = typos.FullName;
            return $"{fullName}: {this.value}";
        }
    }
}

