using System;

namespace _1_TypyGeneryczne
{
    class Program
    {
        static void Main(string[] args)
        {
            var kolejka = new KolejkaKolowa(pojemnosc: 3);

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

            Console.WriteLine("W naszej kolejce jest:");
            while (!kolejka.JestPusty)
            {
                Console.WriteLine("\t\t" + kolejka.Czytaj());
            }
            Console.ReadLine();
        }
    }
}
