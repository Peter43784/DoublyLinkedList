using DoublyLinkedList.Implementation;
using NUnit.Framework;

namespace DoublyLinkedList.Test
{
    [TestFixture]
    internal class DoubleLinkedListNodeTest
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

        [Test]
        public void DoubleLinkedListNode__CorrectPreviousNode()
        {
            var node = new DoubleLinkedListNode<int>(1);
            var previousNode = new DoubleLinkedListNode<int>(2);

            node.Previous = previousNode;

            Assert.AreEqual(node.Previous, previousNode);
        }

        [Test]
        public void NewDoubleLinkedListNode_CorrectNextNode()
        {
            var node = new DoubleLinkedListNode<int>(1);
            var nextNode = new DoubleLinkedListNode<int>(2);

            node.Next = nextNode;

            Assert.AreEqual(node.Next, nextNode);
        }
    }
}