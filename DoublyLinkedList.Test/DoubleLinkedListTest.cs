using System;
using DoublyLinkedList.Contracts;
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
            IDoubleLinkedList<int> list = new DoubleLinkedList<int>();

            list.AddFirst(1);

            Assert.AreEqual(value, list.GetFirst());
        }

        [TestCase(1)]
        public void DoubleLinkedList_AddLast_ReturnsCorrectElement(int value)
        {
            var list = new DoubleLinkedList<int>();

            list.AddLast(1);

            Assert.AreEqual(value, list.GetLast());

        }

        [Test]
        public void EmptyDoubleLinkedList_GetFirstGetLast_ThrowsExeption()
        {
            var list = new DoubleLinkedList<int>();

            Assert.Throws(Is.TypeOf<NullReferenceException>()
                    .And.Message.EqualTo("Collection is empty"),
                () => list.GetFirst());
            Assert.Throws(Is.TypeOf<NullReferenceException>()
                    .And.Message.EqualTo("Collection is empty"),
                () => list.GetLast());
        }

        [Test]
        public void OneElement_AddFirst_LastShouldBeEqualFirst()
        {
            var list = new DoubleLinkedList<int>();

            list.AddFirst(1);

            Assert.AreEqual(list.GetFirst(), list.GetLast());

        }

        [Test]
        public void OneElement_AddLast_LastShouldBeEqualFirst()
        {
            var list = new DoubleLinkedList<int>();

            list.AddLast(1);

            Assert.AreEqual(list.GetFirst(), list.GetLast());

        }
    }
}
