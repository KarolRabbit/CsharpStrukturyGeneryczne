using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace _4_MetodyDelegatyGeneryczne
{
    class Program
    {
        static void Main(string[] args)
        {
            var kolejka = new KolejkaKolowa<double>(pojemnosc: 3);
            kolejka.elementUsuniety += Kolejka_elementUsuniety;

            WprowadzanieDanych(kolejka);

            kolejka.Drukuj(d => Console.WriteLine(d));

            Console.WriteLine("____________________");

            PrzetwarzanieDanych(kolejka);
            Console.ReadLine();
        }

        private static void Kolejka_elementUsuniety(object sender, ElementUsunietyEventsArgs<double> e)
        {
            Console.WriteLine("Element usunięty: {0}, nowy element w kolekcji: {1}", e.ElementUsuniety, e.ElementNowy);
        }

        private static void PrzetwarzanieDanych(KolejkaKolowa<double> kolejka)
        {
            var suma = 0.0;
            Console.WriteLine("Suma elementów bufora");
            while (!kolejka.JestPusty)
            {
                suma += kolejka.Czytaj();
            }
            Console.WriteLine("\tsuma: " + suma);
        }

        private static void WprowadzanieDanych(KolejkaKolowa<double> kolejka)
        {
            while (true)
            {
                var wartosc = 0.0;
                var wartoscwejsciowa = Console.ReadLine();

                if (double.TryParse(wartoscwejsciowa, out wartosc))
                {
                    kolejka.Zapisz(wartosc);
                    continue;
                }
                break;
            }
        }
    }
}
