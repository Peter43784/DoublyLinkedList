using System;
using System.Text;
using DoublyLinkedList.Contracts;

namespace DoublyLinkedList.Implementation
{
    public class DoubleLinkedList<T> : IDoubleLinkedList<T>
    {
        private DoubleLinkedListNode<T> _first;

        private DoubleLinkedListNode<T> _last;

        public void AddFirst(T value)
        {
            if (_first == null)
            {
                _first = new DoubleLinkedListNode<T>(value);
                _last = _first;
            }
            else
            {
                var newNode = new DoubleLinkedListNode<T>(value) {Next = _first};
                _first = newNode;
                _first.Next.Previous = _first;
            }
        }

        public void AddLast(T value)
        {
            
            if (_first == null)
            {
                _last = new DoubleLinkedListNode<T>(value);
                _first = _last;
            }
            else
            {
                var newNode = new DoubleLinkedListNode<T>(value) { Previous = _last };
                _last = newNode;
                _last.Previous.Next = _last;

            }
        }

        public string DisplayForward()
        {
            StringBuilder result = new StringBuilder();
            var node = _first; 
            while (node != null)
            {
                result.Append(node.Value);
                node = node.Next;
            }
           return result.ToString();
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