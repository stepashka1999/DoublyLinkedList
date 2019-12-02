using System;
using System.Collections.Generic;
using System.Text;

namespace DoublyLinkedList.DoublyLinkedList
{
    public interface IDoubleLinkedList<T>
    {
        IDoubleLinkedNode<T> First { get; set; }
        IDoubleLinkedNode<T> Last { get; set; }
        void Reverse();
        void AddFirst(T value);
        void AddLast(T value);
    }
}
