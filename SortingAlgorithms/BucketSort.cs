using Common;
using Datenstrukturen;
using System.Collections.Generic;

namespace SortingAlgorithms
{
    public class BucketSort : ISortAlgorithm<double>
    {
        private double FindMaxNode(Node<double> head)
        {
            double max = head.Data;
            Node<double> current = head;
            while (current != null)
            {
                if (current.Data > max)
                    max = current.Data;
                current = current.Next;
            }
            return max;
        }

        private double FindMinNode(Node<double> head)
        {
            double min = head.Data;
            Node<double> current = head;
            while (current != null)
            {
                if (current.Data < min)
                    min = current.Data;
                current = current.Next;
            }
            return min;
        }

        private int GetListLength(Node<double> head)
        {
            int length = 0;
            Node<double> current = head;
            while (current != null)
            {
                length++;
                current = current.Next;
            }
            return length;
        }

        public void Sort(Node<double> head)
        {
            if (head == null || head.Next == null)
                return;

            double minValue = FindMinNode(head);
            double maxValue = FindMaxNode(head);

            int length = GetListLength(head);

            double range = maxValue - minValue;
            if (range == 0)
                return;

            double bucketSize = range / length;

            DoubleLinkedList<double>[] buckets = new DoubleLinkedList<double>[length];
            for (int i = 0; i < length; i++)
                buckets[i] = new DoubleLinkedList<double>();

            Node<double> current = head;
            while (current != null)
            {
                int bucketIndex = (int)((current.Data - minValue) / bucketSize);

                if (bucketIndex < 0)
                    bucketIndex = 0;

                if (bucketIndex >= length)
                    bucketIndex = length - 1;

                buckets[bucketIndex].InsertAfter(default, current.Data);
                current = current.Next;
            }
            for (int i = 0; i < length; i++)
            {
                buckets[i].SetSortAlgorithm(new InsertionSort<double>());
                buckets[i].Sort();
            }
            List<double> values = new List<double>();
            for (int i = 0; i < length; i++)
            {
                Node<double> bucketCurrent = buckets[i].Head;
                while (bucketCurrent != null)
                {
                    values.Add(bucketCurrent.Data);
                    bucketCurrent = bucketCurrent.Next;
                }
            }

            Node<double> write = head;
            int idx = 0;
            while (write != null)
            {
                write.Data = values[idx++];
                write = write.Next;
            }
        }
    }
}
