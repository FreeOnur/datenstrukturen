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
        private static Node head;
        public static Node insertAtEnd(Person person)
        {
            Node newNode = new Node(person);
            if (head == null)
            {
                head = newNode;
                return newNode;
            }
            Node last = head;
            while (last.Next != null)
            {
                last = last.Next;
            }
            last.Next = newNode;
            return head;
        }

        public static Node insertAtSpecificPosition(int pos, Person person)
        {
            if(pos<1)
            {
                return head;
            }
            if (pos == 1)
            {
                Node newNode = new Node(person);
                newNode.Next = head;
                head = newNode;
                return newNode;
            }
            Node current = head;
            for (int i = 1; i < pos -1 && current != null; i++)
            {
                current = current.Next;
            }
            if (current == null)
            {
                return head;
            }
            Node newNode2 = new Node(person);
            newNode2.Next = current.Next;
            current.Next = newNode2;
            return head;
        }

        public static Node searchNode(string name)
        {
            Node current = head;
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
            Node current = head;
            while (current != null)
            {
                Console.WriteLine(current.Data);
                current = current.Next;
            }
        }
    }
}
