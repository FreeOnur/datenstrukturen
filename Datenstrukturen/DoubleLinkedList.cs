using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datenstrukturen
{
    public class DoubleLinkedList<T>
    {
        private static Node<T> head;

        public Node<T> InsertAfter(T elementBefore, T elementToInsert)
        {
            if (elementBefore == null || head == null)
            {
                Node<T> newNode = new Node<T>(elementToInsert);
                if (head != null)
                {
                    newNode.Next = head;
                    head.Before = newNode;
                }
                head = newNode;
                return newNode;
            }
            Node<T> current = head;
            while (current != null && !current.Data.Equals(elementBefore))
            {
                current = current.Next;
            }
            Node<T> newNode2 = new Node<T>(elementToInsert);
            newNode2.Next = current.Next;
            newNode2.Before = current;
            if (current.Next != null)
            {
                current.Next.Before = newNode2;
            }
            current.Next = newNode2;
            return newNode2;
        }

        public Node<T> InsertBefore(T elementAfter, T elementToInsert)
        {
            Node<T> current = head;
            if (head != null && head.Data.Equals(elementAfter))
            {
                Node<T> newNode = new Node<T>(elementToInsert);
                newNode.Next = head;
                head.Before = newNode;
                head = newNode;
                return newNode;
            }
            while (current != null && !current.Data.Equals(elementAfter))
            {
                current = current.Next;
            }
            if (current == null)
            {
                return null;
            }
            Node<T> newNode2 = new Node<T>(elementToInsert);
            newNode2.Next = current;
            newNode2.Before = current.Before;
            if (current.Before != null)
            {
                current.Before.Next = newNode2;
            }
            current.Before = newNode2;
            return newNode2;
        }

        public int PosOfElement(T person)
        {
            Node<T> current = head;
            int pos = 0;
            while (current != null)
            {
                if(current.Data.Equals(person))
                {
                    return pos;
                }
                current = current.Next;
                pos++;
            }
            return -1;
        }
    }
}
