namespace DoublyLinkedList.Contracts
{
    internal interface IDoubleLinkedList<T>
    {
        void AddFirst(T value);
        void AddLast(T value);
    }
}