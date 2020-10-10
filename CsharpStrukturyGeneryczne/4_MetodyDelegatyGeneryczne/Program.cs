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
        static void WypiszNaKonsoli(double dane)
        {
            Console.WriteLine(dane);
        }
        static void Main(string[] args)
        {
            var kolejka = new KolejkaKolowa<double>(pojemnosc: 3);

            Action<double> drukuj = delegate (double dane)
            {
                Console.WriteLine(dane);
            };

            Action<bool> drukujBool = d => Console.WriteLine(d);

            double l1 = 9;
            double l2 = 3;
            Func<double, double> potegowanie = p => p * p;
            Func<double, double, double> dodawanie = (x, y) => x + y;
            Func<double, double, double> odejmowanie = (x, y) => x - y;
            Func<double, double, double> dzielenie = (x, y) => x / y;

            Predicate<double> JestWiekszenizSto = d => d > 100; 

            drukuj(potegowanie(l1));
            drukuj(dodawanie(l1, l2));
            drukuj(odejmowanie(l1, l2));
            drukuj(dzielenie(l1, l2));

            drukujBool(JestWiekszenizSto(potegowanie(l1)));

            WprowadzanieDanych(kolejka);

            //var inty = kolejka.WyswietlJako<double, int>();

            //foreach (var item in inty)
            //{
            //    Console.WriteLine(item);
            //}

           // var delegatDruku = new Drukarka<double>(WypiszNaKonsoli);

            kolejka.Drukuj(d => Console.WriteLine(d));

            Console.WriteLine("____________________");

            PrzetwarzanieDanych(kolejka);
            Console.ReadLine();

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
