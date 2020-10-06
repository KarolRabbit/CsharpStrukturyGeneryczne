using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestTypyGeneryczne
{
    [TestClass]
    public class LinkedList
    {
        [TestMethod]
        public void AddFirstLastTest()
        {
            LinkedList<int> linList = new LinkedList<int>();

            linList.AddFirst(1);
            linList.AddLast(2);
            linList.AddFirst(3);

            var link1 = linList.First;

            Assert.AreEqual(1, link1.Next.Value);
        }

        [TestMethod]
        public void BeforeTest()
        {
            LinkedList<int> linList = new LinkedList<int>();

            linList.AddFirst(1);
            linList.AddLast(44);
            linList.AddLast(2);
            linList.AddFirst(3);

            var link1 = linList.Last;
            var link2 = linList.AddBefore(link1, 100);

            Assert.AreEqual(100, link1.Previous.Value);
            Assert.IsTrue(link2 == link1.Previous);
        }

        [TestMethod]
        public void FindTest()
        {
            LinkedList<int> linList = new LinkedList<int>();

            linList.AddFirst(1);
            linList.AddLast(44);
            linList.AddLast(2);
            linList.AddFirst(3);

            var link1 = linList.First;

            Assert.AreEqual(link1.Next, linList.Find(1));
        }
    }
}
