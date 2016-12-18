using NUnit.Framework;

namespace DoublyLinkedList.Test
{
    [TestFixture]
    internal class DoubleLinkedListTest
    {

        [TestCase(1)]
        public void DoubleLinkedList_AddFirst_ReturnsCorrectElement(int value)
        {
            IDoubleLinkedList<T> list = new DoubleLinkedList<T>();

            list.AddFirst(1);

            Assert.AreEqual(value, list.First);
        }

        [TestCase(1)]
        public void DoubleLinkedList_AddLast_ReturnsCorrectElement(int value)
        {
            IDoubleLinkedList<T> list = new DoubleLinkedList<T>();

            list.AddLast(1);

            Assert.AreEqual(value, list.Last);

        }

    }
}
