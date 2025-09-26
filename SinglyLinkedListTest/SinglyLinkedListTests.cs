using Common;
using Datenstrukturen;
using System;
namespace SinglyLinkedListTest
{
    public class Tests
    {
        [Test]
        public void InsertAtEnd_AddsNodeCorrectly()
        {
            var list = new SinglyLinkedList<Person>();

            Person p1 = new Person(new DateTime(2000, 1, 1), "weiblich", "Onur");
            Person p2 = new Person(new DateTime(2000, 1, 1), "weiblich", "Arslan");

            list.InsertAtEnd(p1);
            list.InsertAtEnd(p2);

            Assert.AreEqual("Onur", list.Head.Data.Name);
            Assert.AreEqual("Arslan", list.Head.Next.Data.Name);
            Assert.IsNull(list.Head.Next.Next);
        }
        [Test]
        public void InsertAtSpecificPosition_AddsNodeAtCorrectPosition()
        {
            var list = new SinglyLinkedList<Person>();

            Person p1 = new Person(new DateTime(2000, 1, 1), "weiblich", "Onur");
            Person p2 = new Person(new DateTime(2000, 1, 1), "weiblich", "Arslan");
            Person p3 = new Person(new DateTime(2000, 1, 1), "männlich", "Mehmet");

            list.InsertAtEnd(p1);
            list.InsertAtEnd(p2);
            list.InsertAtSpecificPosition(2, p3);

            Assert.AreEqual("Onur", list.Head.Data.Name);
            Assert.AreEqual("Mehmet", list.Head.Next.Data.Name);
            Assert.AreEqual("Arslan", list.Head.Next.Next.Data.Name);
            Assert.IsNull(list.Head.Next.Next.Next);
        }

        [Test]
        public void Search_ReturnsCorrectNode()
        {
            var list = new SinglyLinkedList<Person>();

            Person p1 = new Person(new DateTime(2000, 1, 1), "weiblich", "Onur");
            Person p2 = new Person(new DateTime(2000, 1, 1), "weiblich", "Arslan");
            Person p3 = new Person(new DateTime(2000, 1, 1), "weiblich", "Maurice");

            list.InsertAtEnd(p1);
            list.InsertAtEnd(p2);
            list.InsertAtEnd(p3);

            var result = list.SearchNode(p => p.Name == "Arslan");

            Assert.IsNotNull(result);
            Assert.AreEqual("Arslan", result.Data.Name);
        }
        [Test]
        public void InsertBefore_ReturnsCorrectNode()
        {
            var list = new SinglyLinkedList<Person>();
            Person p1 = new Person(new DateTime(2000, 1, 1), "weiblich", "Onur");
            Person p2 = new Person(new DateTime(2000, 1, 1), "weiblich", "Arslan");
            Person p3 = new Person(new DateTime(2000, 1, 1), "männlich", "Mehmet");
            Person p4 = new Person(new DateTime(2000, 1, 1), "männlich", "Gabriel");

            list.InsertAtEnd(p1);
            list.InsertAtEnd(p2);
            list.InsertAtEnd(p3);

            list.InsertBefore(p2, p4);

            Assert.IsNotNull(list.Head.Next.Next.Next);
            Assert.AreEqual("Gabriel", list.Head.Next.Data.Name);
        }
        [Test]
        public void InsertAfter_ReturnsCorrectNode()
        {
            var list = new SinglyLinkedList<Person>();
            Person p1 = new Person(new DateTime(2000, 1, 1), "weiblich", "Onur");
            Person p2 = new Person(new DateTime(2000, 1, 1), "weiblich", "Arslan");
            Person p3 = new Person(new DateTime(2000, 1, 1), "männlich", "Mehmet");
            Person p4 = new Person(new DateTime(2000, 1, 1), "männlich", "Gabriel");

            list.InsertAtEnd(p1);
            list.InsertAtEnd(p2);
            list.InsertAtEnd(p3);

            list.InsertAfter(p2, p4);

            Assert.IsNotNull(list.Head.Next.Next.Next);
            Assert.AreEqual("Gabriel", list.Head.Next.Next.Data.Name);
        }

        [Test]
        public void PosOfElement_ReturnCorrectPosNumber()
        {
            var list = new SinglyLinkedList<Person>();
            Person p1 = new Person(new DateTime(2000, 1, 1), "weiblich", "Onur");
            Person p2 = new Person(new DateTime(2000, 1, 1), "weiblich", "Arslan");
            Person p3 = new Person(new DateTime(2000, 1, 1), "männlich", "Mehmet");
            Person p4 = new Person(new DateTime(2000, 1, 1), "männlich", "Gabriel");

            list.InsertAtEnd(p1);
            list.InsertAtEnd(p2);
            list.InsertAtEnd(p3);
            list.InsertAtEnd(p4);

            int result = list.PosOfElement(p3);
            Assert.IsNotNull(list.Head.Next.Next.Next);
            Assert.AreEqual(2, result);
        }
    }
}