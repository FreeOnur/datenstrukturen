﻿using Common;
using Datenstrukturen;
using System;
using NUnit.Framework;

namespace DatenstrukturenTests
{
    [TestFixture]
    public class DoubleLinkedListTests
    {
        private DoubleLinkedList<Person> list;
        private Person p1;
        private Person p2;
        private Person p3;
        private Person p4;

        [SetUp]
        public void SetUp()
        {
            list = new DoubleLinkedList<Person>();

            p1 = new Person(new DateTime(2000, 1, 1), "weiblich", "Onur");
            p2 = new Person(new DateTime(2000, 1, 1), "weiblich", "Arslan");
            p3 = new Person(new DateTime(2000, 1, 1), "männlich", "Mehmet");
            p4 = new Person(new DateTime(2000, 1, 1), "männlich", "Gabriel");
        }

        [Test]
        public void InsertAfter_WhenInsertingBetweenElements_PosOfElementIsCorrect()
        {
            list.InsertAfter(null, p1);
            list.InsertAfter(p1, p2);
            list.InsertAfter(p2, p3);

            list.InsertAfter(p2, p4);

            Assert.AreEqual(2, list.PosOfElement(p4));
        }

        [Test]
        public void InsertBefore_WhenInsertingBeforeExistingElement_PosOfElementIsCorrect()
        {
            list.InsertAfter(null, p1);
            list.InsertAfter(p1, p2);
            list.InsertAfter(p2, p3);

            list.InsertBefore(p2, p4);

            Assert.AreEqual(1, list.PosOfElement(p4));
        }

        [Test]
        public void PosOfElement_WhenListHasMultipleElements_ReturnsCorrectPositions()
        {
            list.InsertAfter(null, p1);
            list.InsertAfter(p1, p2);
            list.InsertAfter(p2, p3);

            Assert.AreEqual(0, list.PosOfElement(p1));
            Assert.AreEqual(1, list.PosOfElement(p2));
            Assert.AreEqual(2, list.PosOfElement(p3));
        }
    }
}
