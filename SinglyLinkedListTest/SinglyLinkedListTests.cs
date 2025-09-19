using Common;
using Datenstrukturen;
namespace SinglyLinkedListTest
{
    public class Tests
    {
        [Test]
        public void InsertAtEnd_AddsNodeCorrectly()
        {
            Node head = null;
            head = SinglyLinkedList.insertAtEnd(new Person(new DateTime(2000, 1, 1), "weiblich", "Onur"));
            head = SinglyLinkedList.insertAtEnd(new Person(new DateTime(2000, 1, 1), "weiblich", "Arslan"));

            Assert.AreEqual("Onur", head.Data.Name);
            Assert.AreEqual("Arslan", head.Next.Data.Name);
            Assert.IsNull(head.Next.Next);
        }
        [Test]
        public void InsertAtSpecificPosition_AddsNodeAtCorrectPosition()
        {
            Node head = null;
            head = SinglyLinkedList.insertAtEnd(new Person(new DateTime(2000, 1, 1), "weiblich", "Onur"));
            head = SinglyLinkedList.insertAtEnd(new Person(new DateTime(2000, 1, 1), "weiblich", "Arslan"));
            head = SinglyLinkedList.insertAtSpecificPosition(2, new Person(new DateTime(2000, 1, 1), "männlich", "Mehmet"));

            Assert.AreEqual("Onur", head.Data.Name);
            Assert.AreEqual("Mehmet", head.Next.Data.Name);
            Assert.AreEqual("Arslan", head.Next.Next.Data.Name);
            Assert.IsNull(head.Next.Next.Next);
        }
        [Test]
        public void SearchSpecificPerson_ReturnsCorrectNode()
        {
            Node head = null;
            head = SinglyLinkedList.insertAtEnd(new Person(new DateTime(2000, 1, 1), "weiblich", "Onur"));
            head = SinglyLinkedList.insertAtEnd(new Person(new DateTime(2000, 1, 1), "weiblich", "Arslan"));
            head = SinglyLinkedList.insertAtEnd(new Person(new DateTime(2000, 1, 1), "weiblich", "Maurice"));
            Node result = SinglyLinkedList.searchNode("Arslan");

            Assert.IsNotNull(result);
            Assert.AreEqual("Arslan", result.Data.Name);
        }
    }
}