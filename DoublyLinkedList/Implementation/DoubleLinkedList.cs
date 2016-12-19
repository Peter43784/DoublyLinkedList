using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using DoublyLinkedList.Contracts;

namespace DoublyLinkedList.Implementation
{
    public class DoubleLinkedList<T> : IDoubleLinkedList<T>
    {
        private DoubleLinkedListNode<T> _first;

        private DoubleLinkedListNode<T> _last;

        public int Count { get; private set; }

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

            Count++;
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

            Count++;
        }

        public void DeleteFirst()
        {
            if (_first == null)
            {
                throw new NullReferenceException("Collection is empty");
            }

            if (_first == _last)
            {
                _first = _last = null;
                Count = 0;
                return;
            }
            _first = _first.Next;
            _first.Previous = null;
            Count--;
        }

        public void DeleteLast()
        {
            if (_first == null)
            {
                throw new NullReferenceException("Collection is empty");
            }

            if (_first == _last)
            {
                _first = _last = null;
                Count = 0;
                return;
            }
            _last = _last.Previous;
            _last.Next = null;
            Count--;
        }

        //TODO: adjust formatting
        public string DisplayBackward()
        {
            StringBuilder result = new StringBuilder();
            var node = _last;
            while (node != null)
            {
                result.Append(node.Value);
                node = node.Previous;
            }
            return result.ToString();
        }

        //TODO: adjust formatting
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
        public IEnumerator<T> GetEnumerator()
        {
            var first = _first;
            while (first != null)
            {
                yield return first.Value;
                first = first.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}