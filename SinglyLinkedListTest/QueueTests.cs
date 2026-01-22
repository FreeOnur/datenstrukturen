using NUnit.Framework;
using System;

[TestFixture]
public class QueueTests
{
    private Queue<int> queue;

    [SetUp]
    public void Setup()
    {
        queue = new Queue<int>();
    }

    [Test]
    public void IsEmpty_NewQueue_ReturnsTrue()
    {
        Assert.IsTrue(queue.IsEmpty());
    }

    [Test]
    public void Enqueue_OneElement_IsEmptyReturnsFalse()
    {
        queue.Enqueue(5);
        Assert.IsFalse(queue.IsEmpty());
    }

    [Test]
    public void Enqueue_ThenDequeue_ReturnsSameElement()
    {
        queue.Enqueue(10);
        int result = queue.Dequeue();

        Assert.AreEqual(10, result);
    }

    [Test]
    public void Enqueue_MultipleElements_DequeueReturnsInCorrectOrder()
    {
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);

        Assert.AreEqual(1, queue.Dequeue());
        Assert.AreEqual(2, queue.Dequeue());
        Assert.AreEqual(3, queue.Dequeue());
    }

    [Test]
    public void Peek_ReturnsFirstElementWithoutRemovingIt()
    {
        queue.Enqueue(42);

        int value = queue.Peek();

        Assert.AreEqual(42, value);
        Assert.IsFalse(queue.IsEmpty());
    }

    [Test]
    public void Dequeue_OnEmptyQueue_ThrowsException()
    {
        Assert.Throws<InvalidOperationException>(() => queue.Dequeue());
    }

    [Test]
    public void Peek_OnEmptyQueue_ThrowsException()
    {
        Assert.Throws<InvalidOperationException>(() => queue.Peek());
    }

    [Test]
    public void Dequeue_LastElement_MakesQueueEmpty()
    {
        queue.Enqueue(7);
        queue.Dequeue();

        Assert.IsTrue(queue.IsEmpty());
    }

    [Test]
    public void Enqueue_AfterDequeue_WorksCorrectly()
    {
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Dequeue();   
        queue.Enqueue(3);

        Assert.AreEqual(2, queue.Dequeue());
        Assert.AreEqual(3, queue.Dequeue());
        Assert.IsTrue(queue.IsEmpty());
    }
}
