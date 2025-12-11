using Common;

public class Stack<T>
{
    private Node<T> topNode;

    public void Push(T element)
    {
        Node<T> newNode = new Node<T>(element);
        newNode.Next = topNode;
        topNode = newNode;
    }

    public T Pop()
    {
        if (topNode == null)
        {
            throw new InvalidOperationException("Stack is empty.");
        }

        T value = topNode.Data;
        topNode = topNode.Next;
        return value;
    }

    public T Peek()
    {
        if (topNode == null)
        {
            throw new InvalidOperationException("Stack is empty.");
        }

        return topNode.Data;
    }
    public bool IsEmpty()
    {
        return topNode == null;
    }
}
