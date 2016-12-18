using NUnit.Framework;

namespace DoublyLinkedList.Test
{
    [TestFixture]
    internal class DoubleLinkedListTest
    {
        [TestCase(1)]
        [TestCase(10)]
        [TestCase(100)]
        public void NewDoubleLinkedListNode_ReturnsCorrectValue(int number)
        {
            var node = new DoubleLinkedListNode(number);

            Assert.AreEqual(number, node.value);
        }
    }
}
