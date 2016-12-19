using System;
using DoublyLinkedList.Contracts;

namespace DoublyLinkedList.Implementation
{
    public class DoubleLinkedList<T> : IDoubleLinkedList<T>
    {
        private DoubleLinkedListNode<T> _first;

        private DoubleLinkedListNode<T> _last;

        public void AddFirst(T value)
        {
             _first = new DoubleLinkedListNode<T>(value);
        }

        public void AddLast(T value)
        {
            _last = new DoubleLinkedListNode<T>(value);
        }

        public T GetFirst()
        {
            if (_first == null)
            {
                throw new NullReferenceException("Collection is empty");
            }
           return _first.Value;
        }

        public T GetLast()
        {
            if (_last == null)
            {
                throw new NullReferenceException("Collection is empty");
            }
            return _last.Value;
        }
    }
}