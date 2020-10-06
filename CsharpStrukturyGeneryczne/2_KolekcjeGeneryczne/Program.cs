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
            SprawdzenieKolejki();
            SprawdzenieStosu();
            SprawdzenieHashSetu();
            SprawdzenieLinkedListy();

            Console.ReadLine();
        }

        private static void SprawdzenieLinkedListy()
        {
            LinkedList<int> linList = new LinkedList<int>();

            Console.WriteLine("Dodajemy elementy listy");
            linList.AddFirst(2);
            linList.AddLast(4);
            linList.AddLast(8);
            foreach (var item in linList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nDodajemy liczbę 100 po 2 oraz 200 przed 8");
            var pierwsza = linList.First;
            var ostatnia = linList.Last;
            linList.AddAfter(pierwsza, 100);
            linList.AddBefore(ostatnia, 200);
            foreach (var item in linList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nDodajemy na początek 13 oraz 26 i wyświetlamy całą listę");
            linList.AddFirst(26);
            linList.AddFirst(13);
            var wezel = linList.First;
            while (wezel != null)
            {
                Console.WriteLine(wezel.Value);
                wezel = wezel.Next;
            }
        }

        private static void SprawdzenieHashSetu()
        {
            HashSet<int> liczbyHashSet = new HashSet<int>();
            liczbyHashSet.Add(2);
            liczbyHashSet.Add(4);
            liczbyHashSet.Add(6);
            liczbyHashSet.Add(8);
            liczbyHashSet.Add(4);
            liczbyHashSet.Add(6);

            foreach (var item in liczbyHashSet)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("");

            HashSet<Pracownik> pracownicyHS = new HashSet<Pracownik>();
            Pracownik pracownik1 = new Pracownik() { Imie = "Tomasz", Nazwisko = "Komoran", Wiek = 44, Wzrost = 198 };
            Pracownik pracownik2 = new Pracownik() { Imie = "Artur", Nazwisko = "Burek", Wiek = 24, Wzrost = 168 };

            var dodano1 = pracownicyHS.Add(pracownik1);
            pracownicyHS.Add(pracownik2);
            var dodano2 = pracownicyHS.Add(pracownik1);

            Console.WriteLine(dodano1);
            Console.WriteLine(dodano2);
            Console.WriteLine("");

            foreach (var item in pracownicyHS)
            {
                Console.WriteLine(item.Imie + " " + item.Nazwisko);
            }
            Console.WriteLine("");
        }

        private static void SprawdzenieStosu()
        {
            Stack<Pracownik> stos = new Stack<Pracownik>();
            stos.Push(new Pracownik() { Imie = "Karol", Nazwisko = "Króliczek", Wiek = 30, Wzrost = 188 });
            stos.Push(new Pracownik() { Imie = "Maciej", Nazwisko = "Zygmunt", Wiek = 30, Wzrost = 183 });
            stos.Push(new Pracownik() { Imie = "Olaf", Nazwisko = "Pepito", Wiek = 23, Wzrost = 178 });

            while (stos.Count > 0)
            {
                var item = stos.Pop();
                Console.WriteLine(item.Imie + " ma " + item.Wzrost + " wzrostu.");

            }
            Console.WriteLine("");
        }

        private static void SprawdzenieKolejki()
        {
            Queue<Pracownik> kolejka = new Queue<Pracownik>();
            kolejka.Enqueue(new Pracownik() { Imie = "Karol", Nazwisko = "Króliczek", Wiek = 30, Wzrost = 188 });
            kolejka.Enqueue(new Pracownik() { Imie = "Maciej", Nazwisko = "Zygmunt", Wiek = 30, Wzrost = 183 });
            kolejka.Enqueue(new Pracownik() { Imie = "Olaf", Nazwisko = "Pepito", Wiek = 23, Wzrost = 178 });

            while (kolejka.Count > 0)
            {
                var item = kolejka.Dequeue();
                Console.WriteLine(item.Imie + " ma " + item.Wzrost + " wzrostu.");

            }
            Console.WriteLine("");
        }
    }
}
