using System;
using System.Collections.Generic;
using System.Text;

namespace _09.CustomLinkedList
{
    public class ListNode<T>
    {
        public T Value { get; set; }
        public ListNode<T> NextNode { get; set; }
        public ListNode<T> PreviousNode { get; set; }

        public ListNode(T value)
        {
            Value = value;
        }
    }
}
