using DoublyLinkedList.DoublyLinkedList;
using System;

namespace DoublyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            DoubleLinkedList<int> LinkedList = new DoubleLinkedList<int>();
            
            //Заполнение списка
            for(int i = 1; i <= 5; i++)
            {
                LinkedList.AddLast(i);
            }

            Console.WriteLine($"Вывод списка: {LinkedList.ToString()}");

            LinkedList.Reverse();

            Console.WriteLine($"Вывод перевернутого списка: {LinkedList.ToString()}");
            
        }
    }
}
