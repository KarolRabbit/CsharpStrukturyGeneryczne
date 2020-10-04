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

            Console.WriteLine("");

            Stack<Pracownik> stos = new Stack<Pracownik>();
            stos.Push(new Pracownik() { Imie = "Karol", Nazwisko = "Króliczek", Wiek = 30, Wzrost = 188 });
            stos.Push(new Pracownik() { Imie = "Maciej", Nazwisko = "Zygmunt", Wiek = 30, Wzrost = 183 });
            stos.Push(new Pracownik() { Imie = "Olaf", Nazwisko = "Pepito", Wiek = 23, Wzrost = 178 });

            while (stos.Count > 0)
            {
                var item = stos.Pop();
                Console.WriteLine(item.Imie + " ma " + item.Wzrost + " wzrostu.");

            }

            Console.ReadLine();
        }
    }
}
