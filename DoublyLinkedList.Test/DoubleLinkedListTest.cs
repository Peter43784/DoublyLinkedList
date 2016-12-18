using NUnit.Framework;
using DoublyLinkedList.Implementation;

namespace DoublyLinkedList.Test
{
    [TestFixture]
    internal class DoubleLinkedListTest
    {

        [TestCase(1)]
        public void DoubleLinkedList_AddFirst_ReturnsCorrectElement(int value)
        {
            var list = new DoubleLinkedList<int>();

            list.AddFirst(1);

            Assert.AreEqual(value, list.First.Value);
        }

        [TestCase(1)]
        public void DoubleLinkedList_AddLast_ReturnsCorrectElement(int value)
        {
            var list = new DoubleLinkedList<int>();

            list.AddLast(1);

            Assert.AreEqual(value, list.Last.Value);

        }

    }
}
