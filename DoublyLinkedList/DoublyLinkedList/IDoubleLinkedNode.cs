using System;
using System.Collections.Generic;
using System.Text;

namespace DoublyLinkedList.DoublyLinkedList
{
    public interface IDoubleLinkedNode<T>
    {
        T Value { get; set; }
        IDoubleLinkedNode<T> Next { get; set; }
        IDoubleLinkedNode<T> Prev { get; set; }
    }
}
