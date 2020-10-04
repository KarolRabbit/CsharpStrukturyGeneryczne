using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestTypyGeneryczne
{
    [TestClass]
    public class HashSet
    {
        [TestMethod]
        public void IntersectWithTest()
        {
            var set1 = new HashSet<int>() { 1, 2, 3 };
            var set2 = new HashSet<int>() { 2, 3, 4 };

            set1.IntersectWith(set2);

            Assert.AreEqual(2, set1.Count);
        }

        [TestMethod]
        public void SymmetricExceptWithTest()
        {
            var set1 = new HashSet<int>() { 1, 2, 3 };
            var set2 = new HashSet<int>() { 2, 3, 4 };

            set1.SymmetricExceptWith(set2);

            Assert.AreEqual(2, set1.Count);
            Assert.IsTrue(set1.Contains(1));
            Assert.IsTrue(set1.Contains(4));
        }

        [TestMethod]
        public void Test()
        {
            var set1 = new HashSet<int>() { 1, 2, 3, 4, 5 };
            var set2 = new HashSet<int>() { 2, 3, 4 };

            set1.RemoveWhere(x => x > 2);

            Assert.AreEqual(2, set1.Count);
            Assert.IsTrue(!set1.Contains(4));
        }

        [TestMethod]
        public void RemoveTest()
        {
            var set1 = new HashSet<int>() { 1, 2, 8, 4, 5 };
            var set2 = new HashSet<int>() { 2, 3, 4 };

            set1.Remove(8);

            Assert.AreEqual(4, set1.Count);
            Assert.IsTrue(!set1.Contains(8));
        }
    }
}
