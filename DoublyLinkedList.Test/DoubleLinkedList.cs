using System;

namespace DoublyLinkedList.Test
{
    internal class DoubleLinkedList<T> : IDoubleLinkedList<T>
    {
        public DoubleLinkedListNode<T> First { get; private set; }

        public DoubleLinkedListNode<T> Last { get; set; }

        public void AddFirst(T value)
        {
             First = new DoubleLinkedListNode<T>(value);
        }

        public void AddLast(T value)
        {
            Last = new DoubleLinkedListNode<T>(value);
        }
    }
}