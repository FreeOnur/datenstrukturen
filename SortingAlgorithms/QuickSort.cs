using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
namespace SortingAlgorithms
{
    public class QuickSort<T> : ISortAlgorithm<T> where T : IComparable<T>
    {
        Node<T> GetLastNode(Node<T> node)
        {
            while (node != null && node.Next != null)
            {
                node = node.Next;
            }
            return node;
        }
        public void Sort(Node<T> head)
        {
            if (head == null || head.Next == null)
                return;
            Node<T> last = GetLastNode(head);
            Sort(head, last);
        }
        void Sort(Node<T> start, Node<T> last)
        {
            if (start == null || last == null || start == last || start == last.Next)
                return;
            Node<T> pivot = Partition(start, last);
            Sort(start,pivot.Before);
            Sort(pivot.Next, last);
        }

        Node<T> Partition(Node<T> start, Node<T> lastNode)
        {
            Node<T> pivot = lastNode;
            Node<T> i = start.Before;
            for (Node<T> j = start; j != lastNode; j = j.Next)
            {
                if (j.Data.CompareTo(pivot.Data) < 0)
                {
                    i = (i == null) ? start : i.Next;
                    T temporaryNode = i.Data;
                    i.Data = j.Data;
                    j.Data = temporaryNode;
                }
            }
            i = (i == null) ? start : i.Next;
            T temp = i.Data;
            i.Data = lastNode.Data;
            lastNode.Data = temp;
            return i;
        }

        

        
    }
}
