using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_MetodyDelegatyGeneryczne
{
    public static class KolejkaExtensions
    {
        public static  IEnumerable<Twyj> WyswietlJako<T, Twyj>(this IKolejka<T> kolejka)
        {
            var konwerter = TypeDescriptor.GetConverter(typeof(T));
            foreach (var item in kolejka)
            {
                var wynik = konwerter.ConvertTo(item, typeof(Twyj));
                yield return (Twyj)wynik;
            }
        }

        public static void Drukuj<T>(this IKolejka<T> kolejka)
        {
            foreach (var item in kolejka)
            {
                Console.WriteLine(item);
            }
        }
    }
}
