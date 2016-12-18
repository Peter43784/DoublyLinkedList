using NUnit.Framework;

namespace DoublyLinkedList.Test
{
    [TestFixture]
    internal class DoubleLinkedListTest
    {

        [TestCase(1)]
        public void NewDoubleLinkedListNode_TypeOfInteger_ReturnsCorrectValue(int value)
        {
            var node = new DoubleLinkedListNode<int>(value);

            Assert.AreEqual(value, node.Value);
        }

        [TestCase("str")]
        public void NewDoubleLinkedListNode_TypeOfString_ReturnsCorrectValue(string value)
        {
            var node = new DoubleLinkedListNode<string>(value);

            Assert.AreEqual(value, node.Value);
        }
    }
}