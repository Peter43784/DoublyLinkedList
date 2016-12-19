using System;
using System.Collections.Generic;
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

        [Test]
        public void DisplayForward_ShouldDisplayAllElements_StartFromTheFirst()
        {
            var list = new DoubleLinkedList<int>();

            list.AddFirst(2);
            list.AddLast(3);
            list.AddFirst(1);
            list.AddLast(4);
            list.AddFirst(0);

            Assert.AreEqual("01234", list.DisplayForward());

        }

        [Test]
        public void DisplayForward_ShouldDisplayAllElements_StartFromTheLast()
        {
            var list = new DoubleLinkedList<int>();

            list.AddFirst(2);
            list.AddLast(3);
            list.AddFirst(1);
            list.AddLast(4);
            list.AddFirst(0);

            Assert.AreEqual("43210", list.DisplayBackward());

        }

        static object[] CountTestElements =
        {
            new object[] {new[] {1,2,3}},
            new object[] {new[] {1,2}},
            new object[] {new[] {1}},
            new object[] {new int[0]}
        };

        [Test, TestCaseSource(nameof(CountTestElements))]
        public void Count_ShouldReturnCorrectAmountOfElements(int[] elements)
        {
           var list = new DoubleLinkedList<int>();

            foreach (var e in elements)
            {
                list.AddLast(e);
            }

            Assert.AreEqual(elements.Length, list.Count);

        }
    }
}
