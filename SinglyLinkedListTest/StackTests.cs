using NUnit.Framework;
using Datenstrukturen;
using System;

namespace Datenstrukturen.Tests
{
    public class StackTests
    {
        private Stack<int> stack;

        [SetUp]
        public void Setup()
        {
            stack = new Stack<int>();
        }

        [Test]
        public void InsertTestNumber_Push_AddOneElement_PeekReturnsSameElement()
        {
            stack.Push(10);
            Assert.AreEqual(10, stack.Peek());
        }

        [Test]
        public void InsertTestNumber_Push_AddMultipleElements_PeekReturnsLastPushed()
        {
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            Assert.AreEqual(3, stack.Peek());
        }

        [Test]
        public void InsertTestNumber_Pop_RemoveElement_ReturnsCorrectValue()
        {
            stack.Push(1);
            stack.Push(2);
            Assert.AreEqual(2, stack.Pop());
            Assert.AreEqual(1, stack.Peek());
        }

        [Test]
        public void Pop_OnEmptyStack_ThrowsException()
        {
            Assert.Throws<InvalidOperationException>(() => stack.Pop());
        }

        [Test]
        public void Peek_OnEmptyStack_ThrowsException()
        {
            Assert.Throws<InvalidOperationException>(() => stack.Peek());
        }

        [Test]
        public void IsEmpty_WhenNewStack_ReturnsTrue()
        {
            Assert.IsTrue(stack.IsEmpty());
        }

        [Test]
        public void IsEmpty_AfterPush_ReturnsFalse()
        {
            stack.Push(1);
            Assert.IsFalse(stack.IsEmpty());
        }
    }
}
