using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using _2_KolekcjeGeneryczne;

namespace UnitTestTypyGeneryczne
{
    [TestClass]
    public class Kolejka
    {
        [TestMethod]
        public void UzyciePeek()
        {
            Queue<Pracownik> kolejka = new Queue<Pracownik>();
            kolejka.Enqueue(new Pracownik() { Imie = "Karol", Nazwisko = "Króliczek", Wiek = 30, Wzrost = 188 });
            kolejka.Enqueue(new Pracownik() { Imie = "Maciej", Nazwisko = "Zygmunt", Wiek = 30, Wzrost = 183 });
            kolejka.Enqueue(new Pracownik() { Imie = "Olaf", Nazwisko = "Pepito", Wiek = 23, Wzrost = 178 });

            kolejka.Peek();
            Assert.AreEqual(3, kolejka.Count);

            kolejka.Dequeue();
            Assert.AreEqual(2, kolejka.Count);
        }

        [TestMethod]
        public void UzycieToArray()
        {
            var kolejka = new Queue<int>();
            kolejka.Enqueue(1);
            kolejka.Enqueue(2);
            kolejka.Enqueue(3);
            kolejka.Enqueue(4);

            int[] tab = kolejka.ToArray();
            kolejka.Dequeue();

            Assert.AreEqual(4, tab.Length);
            Assert.AreEqual(3, kolejka.Count);
        }

        [TestMethod]
        public void UzycieClear()
        {
            var kolejka = new Queue<int>();
            kolejka.Enqueue(1);
            kolejka.Enqueue(2);
            kolejka.Enqueue(3);
            kolejka.Enqueue(4);

            kolejka.Clear();

            Assert.AreEqual(0, kolejka.Count);
        }
    }
}
