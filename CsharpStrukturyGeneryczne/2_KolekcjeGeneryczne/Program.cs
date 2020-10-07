using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _2_KolekcjeGeneryczne
{
    class Program
    {
        enum Section { bookkeeping = 0, electricians = 2, miners = 5, mechanics = 4, management = 3, director = 1 };

        static void Main(string[] args)
        {
            SprawdzenieKolejki();
            SprawdzenieStosu();
            SprawdzenieHashSetu();
            SprawdzenieLinkedListy();
            //SprawdzenieDictionary();  Usunąłem niechcący
            SprawdzenieSortedDictionary();

            Console.ReadLine();
        }

        private static void SprawdzenieSortedDictionary()
        {
            SortedDictionary<Section, List<Pracownik>> Workers = new SortedDictionary<Section, List<Pracownik>>();

            Workers.Add(Section.bookkeeping, new List<Pracownik> {new Pracownik { Nazwisko = "Kulińska", Imie = "Anna", Wiek = 28, Pensja = 3200 },
                                                                      new Pracownik { Nazwisko = "Bagieta", Imie = "Magdalena", Wiek = 38, Pensja = 3700 },
                                                                      new Pracownik { Nazwisko = "Wymyk", Imie = "Michalina", Wiek = 41, Pensja = 3800 },});

            Workers.Add(Section.electricians, new List<Pracownik> {new Pracownik { Nazwisko = "Woźniak", Imie = "Kamil", Wiek = 21, Pensja = 3100 },
                                                                       new Pracownik { Nazwisko = "Bobrek", Imie = "Michał", Wiek = 38, Pensja = 4700 },
                                                                       new Pracownik { Nazwisko = "Jurmyk", Imie = "Andrzej", Wiek = 31, Pensja = 3800},
                                                                       new Pracownik { Nazwisko = "Kozak", Imie = "Jan", Wiek = 27, Pensja = 4100 }});

            Workers.Add(Section.miners, new List<Pracownik> {new Pracownik { Nazwisko = "Janiak", Imie = "Kamil", Wiek = 21, Pensja = 3400 },
                                                                 new Pracownik { Nazwisko = "Boban", Imie = "Czesław", Wiek = 38, Pensja = 4700 },
                                                                 new Pracownik { Nazwisko = "Domagała", Imie = "Rafał", Wiek = 21, Pensja = 3800},
                                                                 new Pracownik { Nazwisko = "Kozak", Imie = "Jan", Wiek = 27, Pensja = 4300 },
                                                                 new Pracownik { Nazwisko = "Dalko", Imie = "Anatol", Wiek = 22, Pensja = 3400 },
                                                                 new Pracownik { Nazwisko = "Miłowow", Imie = "Andrzej", Wiek = 48, Pensja = 5100 }});

            Workers.Add(Section.mechanics, new List<Pracownik> {new Pracownik { Nazwisko = "Wojtak", Imie = "Kamil", Wiek = 25, Pensja = 3200 },
                                                                    new Pracownik { Nazwisko = "Bjorek", Imie = "Michał", Wiek = 31, Pensja = 4700 },
                                                                    new Pracownik { Nazwisko = "Myk", Imie = "Andrzej", Wiek = 31, Pensja = 3800},
                                                                    new Pracownik { Nazwisko = "Wojtak", Imie = "Jan", Wiek = 41, Pensja = 4800 }});

            Workers.Add(Section.management, new List<Pracownik> {new Pracownik { Nazwisko = "Buda", Imie = "Anna", Wiek = 42, Pensja = 7200 },
                                                                     new Pracownik { Nazwisko = "Misiek", Imie = "Sławomir", Wiek = 48, Pensja = 7700 },
                                                                     new Pracownik { Nazwisko = "Łybyk", Imie = "Michał", Wiek = 51, Pensja = 7800 },});

            Workers.Add(Section.director, new List<Pracownik> { new Pracownik { Nazwisko = "Króliczek", Imie = "Karol", Wiek = 30, Pensja = 10200 } });

            foreach (var section in Workers)
            {
                Console.WriteLine("\nDział: " + section.Key);
                foreach (var worker in section.Value)
                {
                    Console.WriteLine(worker.Imie + ": " + worker.Nazwisko + ": " + worker.Pensja);
                }
            }
        }

        private static void AddEmployee(ref Dictionary<Section, List<Pracownik>> dic, Section sec, string readEmp)
        {

            string[] employeeData;
            string name = "";
            string secName = "";
            int age = 0;
            int wage = 0;

            employeeData = readEmp.Split(';');
            if (employeeData.Length == 4)
            {
                name = employeeData[0];
                secName = employeeData[1];
                if (Int32.TryParse(employeeData[2], out int result1))
                {
                    age = result1;
                }
                else { return; }

                if (Int32.TryParse(employeeData[3], out int result2))
                {
                    wage = result2;
                }
                else { return; }

                dic[sec].Add(new Pracownik { Imie = name, Nazwisko = secName, Wiek = age, Pensja = wage });
            }
            else return;

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
