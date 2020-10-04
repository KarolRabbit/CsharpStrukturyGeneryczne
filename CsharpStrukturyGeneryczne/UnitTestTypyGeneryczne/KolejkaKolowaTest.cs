using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _1_TypyGeneryczne;

namespace UnitTestTypyGeneryczne
{
    [TestClass]
    public class KolejkaKolowaTest
    {
        [TestMethod]
        public void NowaKolejkaJestPusta()
        {
            var kolejka = new KolejkaKolowa<double>(3);
            Assert.IsTrue(kolejka.JestPusty);
        }

        [TestMethod]
        public void KolejkaTrzyelementowaJestPelnaPoTrzechZapisach()
        {
            var kolejka = new KolejkaKolowa<double>(3);
            kolejka.Zapisz(3.3);
            kolejka.Zapisz(2);
            kolejka.Zapisz(0.2);

            Assert.IsTrue(kolejka.JestPelny);
        }

        [TestMethod]
        public void PierwszyWchodziPierwszyWychodzi()
        {
            var kolejka = new KolejkaKolowa<double>(3);
            var wartosc1 = 3.3;
            var wartosc2 = 2;
            kolejka.Zapisz(wartosc1);
            kolejka.Zapisz(wartosc2);

            Assert.AreEqual(wartosc1, kolejka.Czytaj());
            Assert.IsFalse(kolejka.JestPusty);
            Assert.AreEqual(wartosc2, kolejka.Czytaj());

            Assert.IsFalse(kolejka.JestPelny);
            Assert.IsTrue(kolejka.JestPusty);
        }

        [TestMethod]
        public void NadpisujeGdyJestWiekszeNizPojemnosc()
        {
            var kolejka = new KolejkaKolowa<double>(3);
            var wartosci = new[] { 3.3, 4.7, 5, 1, 0.1, 66 };

            foreach (var wartosc in wartosci)
            {
                kolejka.Zapisz(wartosc);
            }

            Assert.AreEqual(wartosci[3], kolejka.Czytaj());
            Assert.AreEqual(wartosci[4], kolejka.Czytaj());
            Assert.AreEqual(wartosci[5], kolejka.Czytaj());

            Assert.IsTrue(kolejka.JestPusty);

        }
    }

}
