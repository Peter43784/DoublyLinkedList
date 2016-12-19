using System.Collections.Generic;

namespace DoublyLinkedList.Contracts
{
    public interface IDoubleLinkedList<T> : IEnumerable<T>
    {
        void AddFirst(T value);
        void AddLast(T value);
        T GetFirst();
        T GetLast();
        string DisplayForward();
        string DisplayBackward();
        void DeleteFirst();
        void DeleteLast();
    }
}