using System;
using System.Collections.Generic;

namespace _3_KlasyIInterfejsyGeneryczne
{
    class Program
    {
        static void Main(string[] args)
        {
  
            var kolejka = new KolejkaKolowa<double>();

            WprowadzanieDanych(kolejka);
            PrzetwarzanieDanych(kolejka);
            Console.ReadLine();

        }

        private static void PrzetwarzanieDanych(IKolejka<double> kolejka)
        {
            var suma = 0.0;
            Console.WriteLine("Suma elementów bufora");
            while (!kolejka.JestPusty)
            {
                suma += kolejka.Czytaj();
            }
            Console.WriteLine("\tsuma: " + suma);
        }

        private static void WprowadzanieDanych(IKolejka<double> kolejka)
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
