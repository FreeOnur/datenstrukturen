// See https://aka.ms/new-console-template for more information
using Common;
using Datenstrukturen;
class Program
{
    static void Main()
    {
        Node head = null;
        head = SinglyLinkedList.insertAtEnd(head, new Person(new DateTime(2000, 1, 1), "weiblich","Onur"));
        head = SinglyLinkedList.insertAtEnd(head, new Person(new DateTime(2000, 1, 1), "weiblich", "Arslan"));
        SinglyLinkedList.PrintSinglyLinkedList(head);

    }
}
