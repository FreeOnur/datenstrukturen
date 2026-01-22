using Common;

public class Queue<T>
{
    private Node<T> topNode;

    public void Enqueue(T element)
    {
        Node<T> newNode = new Node<T>(element);

        if (topNode == null)
        {
            topNode = newNode;
            return;
        }

        Node<T> current = topNode;
        while (current.Next != null)
        {
            current = current.Next;
        }

        current.Next = newNode;
    }

    public T Dequeue()
    {
        if (topNode == null)
        {
            throw new InvalidOperationException("Queue is empty.");
        }

        T value = topNode.Data;
        topNode = topNode.Next;
        return value;
    }

    public T Peek()
    {
        if (topNode == null)
        {
            throw new InvalidOperationException("Queue is empty.");
        }

        return topNode.Data;
    }

    public bool IsEmpty()
    {
        return topNode == null;
    }
}
