using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_TypyGeneryczne
{
    public class KolejkaKolowa<T>
    {
        //private int head;
        //private int tail;
        //private bool buffFull;
        //private bool buffEmpty;


        //string[] buffer;


        //public KolejkaKolowa(int length)
        //{
        //    buffer = new string[length];
        //    head = 0;
        //    tail = 0;
        //}

        //public void AddItem(string item)
        //{
        //    buffer[head] = item;
        //    head++;
        //    head = (head == (buffer.Length)) ? 0 : head;
        //    tail = (head == tail) ? tail++ : tail;
        //    tail = (head == (buffer.Length)) ? 0 : tail;
        //}

        //public string SubItem()
        //{
        //    string item = buffer[tail];

        //    if (tail != head)
        //    {
        //        tail++;
        //        tail = (tail == buffer.Length) ? 0 : tail;
        //    }
        //    else
        //    {
        //        item = null;
        //    }
        //    return item;
        //}

        //public bool BuffFull
        //{
        //    get
        //    {
        //        if (((head + 1) == tail) || ((head == (buffer.Length - 1)) && (tail == 0)))
        //        {
        //            return true;
        //        }
        //        else
        //        {
        //            return false;
        //        }
        //    }
        //}

        //public bool BuffEmpty
        //{
        //    get
        //    {
        //        return (tail == head) ? true : false;
        //    }

        //}

        private T[] bufor;
        private int poczatekBufora;
        private int koniecBufora;

        public KolejkaKolowa() : this(pojemnosc: 5)
        {

        }

        public KolejkaKolowa(int pojemnosc)
        {
            bufor = new T[pojemnosc + 1];
            poczatekBufora = 0;
            koniecBufora = 0;
        }

        public void Zapisz(T wartosc)
        {
            bufor[koniecBufora] = wartosc;
            koniecBufora = (koniecBufora + 1) % bufor.Length;

            if (koniecBufora == poczatekBufora)
            {
                poczatekBufora = (poczatekBufora + 1) % bufor.Length;
            }
        }

        public T Czytaj()
        {
            var wynik = bufor[poczatekBufora];
            poczatekBufora = (poczatekBufora + 1) % bufor.Length;
            return wynik;
        }

        public int Pojemnosc
        {
            get
            {
                return bufor.Length;
            }
        }
        public bool JestPusty
        {
            get
            {
                return koniecBufora == poczatekBufora;
            }
        }
        public bool JestPelny
        {
            get
            {
                return (koniecBufora + 1) % bufor.Length == poczatekBufora;
            }
        }
    }
}
