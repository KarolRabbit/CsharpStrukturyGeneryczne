using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestTypyGeneryczne
{
    [TestClass]
    public class Doctionary
    {
        [TestMethod]
        public void DictionarySimplyTest()
        {
            Dictionary<int, string> dictionary = new Dictionary<int, string>();

            dictionary.Add(1, "jeden");
            dictionary.Add(2, "dwa");
            dictionary.Add(3, "trzy");

            Assert.AreEqual("jeden", dictionary[1]);
            Assert.IsTrue(dictionary.ContainsValue("trzy"));

            dictionary.Remove(2);

            Assert.IsTrue(dictionary.Count == 2);
        }

        [TestMethod]
        public void DictionaryTranslateTest()
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();

            dictionary.Add("one", "jeden");
            dictionary.Add("two", "dwa");
            dictionary.Add("three", "trzy");

            Assert.AreEqual("jeden", dictionary["one"]);
            Assert.IsTrue(dictionary.ContainsKey("three"));

        }
    }
}
