using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace Datenstrukturen
{
    public class SinglyLinkedList
    {
        private static Node<Person> head;
        public static Node<Person> insertAtEnd(Person person)
        {
            Node<Person> newNode = new Node<Person>(person);
            if (head == null)
            {
                head = newNode;
                return newNode;
            }
            Node<Person> last = head;
            while (last.Next != null)
            {
                last = last.Next;
            }
            last.Next = newNode;
            return head;
        }

        public static Node<Person> insertAtSpecificPosition(int pos, Person person)
        {
            if(pos<1)
            {
                return head;
            }
            if (pos == 1)
            {
                Node<Person> newNode = new Node<Person>(person);
                newNode.Next = head;
                head = newNode;
                return newNode;
            }
            Node<Person> current = head;
            for (int i = 1; i < pos -1 && current != null; i++)
            {
                current = current.Next;
            }
            if (current == null)
            {
                return head;
            }
            Node<Person> newNode2 = new Node<Person>(person);
            newNode2.Next = current.Next;
            current.Next = newNode2;
            return head;
        }

        public static Node<Person> searchNode(string name)
        {
            Node<Person> current = head;
            while (current != null)
            {
                if (current.Data.Name == name)
                {
                    return current;
                }
                current = current.Next;
            }
            return null;
        }

        public static void printSinglyLinkedList()
        {
            Node<Person> current = head;
            while (current != null)
            {
                Console.WriteLine(current.Data);
                current = current.Next;
            }
        }
    }
}
