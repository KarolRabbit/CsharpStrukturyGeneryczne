using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_KolekcjeGeneryczne
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<Pracownik> kolejka = new Queue<Pracownik>();
            kolejka.Enqueue(new Pracownik() { Imie = "Karol", Nazwisko = "Króliczek", Wiek = 30, Wzrost = 188 });
            kolejka.Enqueue(new Pracownik() { Imie = "Maciej", Nazwisko = "Zygmunt", Wiek = 30, Wzrost = 183 });
            kolejka.Enqueue(new Pracownik() { Imie = "Olaf", Nazwisko = "Pepito", Wiek = 23, Wzrost = 178 });

            while(kolejka.Count > 0)
            {
                var item = kolejka.Dequeue();
                Console.WriteLine(item.Imie + " ma " + item.Wzrost + " wzrostu.");
                
            }
            kolejka.Enqueue(new Pracownik() { Imie = "Ola", Nazwisko = "Pepko", Wiek = 13, Wzrost = 148 });
            int dlKol = kolejka.Count;
            Console.WriteLine(dlKol.ToString());
            Console.ReadLine();
        }
    }
}
