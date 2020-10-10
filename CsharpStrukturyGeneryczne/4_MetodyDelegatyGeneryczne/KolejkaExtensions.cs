using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_MetodyDelegatyGeneryczne
{
    public delegate void Drukarka<T>(T dane);

    public static class KolejkaExtensions
    {
        public static  IEnumerable<Twyj> Mapuj<T, Twyj>(this IKolejka<T> kolejka, Converter<T, Twyj> konwerter)
        {
            
            foreach (var item in kolejka)
            {
                var wynik = konwerter(item);
                yield return wynik;
            }
        }

        public static void Drukuj<T>(this IKolejka<T> kolejka, Drukarka<T> Wypisz)
        {
            foreach (var item in kolejka)
            {
                Wypisz(item);
            }
        }
    }
}
