namespace DoublyLinkedList
{
    public class DoubleLinkedListNode<T>
    {
        public T Value { get; private set; }

        public DoubleLinkedListNode(T value)
        {
            Value = value;
        }
    }
}