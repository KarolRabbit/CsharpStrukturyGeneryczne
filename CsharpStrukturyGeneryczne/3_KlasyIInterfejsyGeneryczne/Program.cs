﻿using System;
using System.Collections.Generic;

namespace _3_KlasyIInterfejsyGeneryczne
{
    class Program
    {
        static void Main(string[] args)
        {

            //var kolejka = new KolejkaKolowa<double>();

            //WprowadzanieDanych(kolejka);
            //foreach (var item in kolejka)
            //{
            //    Console.WriteLine(item);
            //}
            //PrzetwarzanieDanych(kolejka);
            //Console.ReadLine();

            SortedDictionary<string, SortedSet<Pracownik>> pracownicy = new SortedDictionary<string, SortedSet<Pracownik>>();

            pracownicy.Add("Księgowość", new SortedSet<Pracownik>(new PracownikComparer()));
            pracownicy["Księgowość"].Add(new Pracownik { Imie = "Jan", Nazwisko = "Kopernik", Pensja = 3800 });
            pracownicy["Księgowość"].Add(new Pracownik { Imie = "Anna", Nazwisko = "Domagała", Pensja = 4800 });

            pracownicy.Add("Informatyka", new SortedSet<Pracownik>(new PracownikComparer()));
            pracownicy["Informatyka"].Add(new Pracownik { Imie = "Jonasz", Nazwisko = "Zwała", Pensja = 3900 });
            pracownicy["Informatyka"].Add(new Pracownik { Imie = "Błażej", Nazwisko = "Fopernik", Pensja = 5800 });
            pracownicy["Informatyka"].Add(new Pracownik { Imie = "Anna", Nazwisko = "Cała", Pensja = 4100 });
            pracownicy["Informatyka"].Add(new Pracownik { Imie = "Justyna", Nazwisko = "Cała", Pensja = 4300 });

            foreach (var dzial in pracownicy)
            {
                Console.WriteLine("\nDział: " + dzial.Key);
                foreach (var pracownik in dzial.Value)
                {
                    Console.WriteLine("\t" + pracownik.Nazwisko);
                }
            }

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
