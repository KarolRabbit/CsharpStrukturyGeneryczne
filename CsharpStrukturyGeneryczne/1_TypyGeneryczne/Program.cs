using System;

namespace _1_TypyGeneryczne
{
    class Program
    {
        static void Main(string[] args)
        {
            //var Kolejka = new KolejkaKolowa(3);



            //while (!Kolejka.BuffFull)
            //{
            //    var valueIn = Console.ReadLine();
            //    Kolejka.AddItem(valueIn);

            //}

            //var value = Console.ReadLine();
            //Kolejka.AddItem(value);

            //if (Kolejka.BuffFull)
            //{
            //    //while(Kolejka.SubItem() != null)
            //    Console.WriteLine(Kolejka.SubItem());
            //}

            //Console.ReadLine();

            //---------------------------------------------------------------------------------------------
            var kolejka = new KolejkaKolowa<double>(pojemnosc: 3);

            WprowadzanieDanych(kolejka);
            PrzetwarzanieDanych(kolejka);
            Console.ReadLine();

            //var osoby = new KolejkaKolowa<Osoba>(pojemnosc: 3);

            //osoby.Zapisz(new Osoba { Imie = "Karol", Nazwisko = "Króliczek", Wiek = 30, Wzrost = 188 });
            //osoby.Zapisz(new Osoba { Imie = "Maciej", Nazwisko = "Zygmunt", Wiek = 30, Wzrost = 184 });
            //osoby.Zapisz(new Osoba { Imie = "Szymon", Nazwisko = "Małek", Wiek = 30, Wzrost = 184 });
            //osoby.Zapisz(new Osoba { Imie = "Dominik", Nazwisko = "Mini", Wiek = 22, Wzrost = 198 });

            //Console.WriteLine("W naszej kolejce jest:\n");
            //while (!osoby.JestPusty)
            //{
            //    var osobaWyswietlana = osoby.Czytaj();

            //    Console.WriteLine($"Imię: {osobaWyswietlana.Imie},\nNazwisko: {osobaWyswietlana.Nazwisko},\nWiek: {osobaWyswietlana.Wiek},\nWzrost: {osobaWyswietlana.Wzrost}\n");
            //}
            //Console.ReadLine();

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

    //class Osoba
    //{
    //    public string Imie { get; set; }
    //    public string Nazwisko { get; set; }
    //    public int Wiek { get; set; }
    //    public int Wzrost { get; set; }
    //}
}
