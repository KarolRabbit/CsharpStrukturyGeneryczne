﻿using System;
using System.Collections.Generic;
using System.Linq;
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

            WprowadzanieDanych(kolejka);

            //var inty = kolejka.WyswietlJako<double, int>();

            //foreach (var item in inty)
            //{
            //    Console.WriteLine(item);
            //}

            var delegatDruku = new Drukarka<double>(WypiszNaKonsoli);

            kolejka.Drukuj(delegatDruku);

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
