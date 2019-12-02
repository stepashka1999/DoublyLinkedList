using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DoublyLinkedList.DoublyLinkedList
{
    class DoubleLinkedList<T> : IDoubleLinkedList<T>
    {
        public IDoubleLinkedNode<T> First { get; set; }
        public IDoubleLinkedNode<T> Last { get; set; }

        public int Count { get; private set; }

        public void AddFirst(T value)
        {
            var element = new DoubleLinkedNode<T>(value);
            var temp = First;
            element.Next = temp;
            First = element;

            if (Count == 0) Last = First;
            else temp.Prev = First;

            Count++;
        }

        public void AddLast(T value)
        {
            var element = new DoubleLinkedNode<T>(value);
            
            if(Count == 0)
            {
                First = element;
                Last = element;
            }
            else
            {
                var temp = Last;
                Last.Next = element;
                Last = element;
                element.Prev = temp;
            }

            Count++;
        }

        public void Reverse()
        {
            var firstEl = First;
            var secondEl = Last;

            for(int i = 0; i < Count/2; i++)
            {
                var temp = firstEl.Value;

                firstEl.Value = secondEl.Value;
                secondEl.Value = temp;

                firstEl = firstEl.Next;
                secondEl = secondEl.Prev;
            }
        }

        override public string ToString()
        {
            var element = First;
            string res = "";

            for(int i = 0; i < Count; i++)
            {
                res += element.Value.ToString() + "    ";
                element = element.Next;
            }

            return res;
        }

    }
}
