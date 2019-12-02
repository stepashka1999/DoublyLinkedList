using System;
using System.Collections.Generic;
using System.Text;

namespace DoublyLinkedList.DoublyLinkedList
{
    class DoubleLinkedNode<T> : IDoubleLinkedNode<T>
    {
        public T Value { get; set; }

        public DoubleLinkedNode(T value)
        {
            Value = value;
        }

        public IDoubleLinkedNode<T> Next { get; set; }
        public IDoubleLinkedNode<T> Prev { get; set; }
    }
}
