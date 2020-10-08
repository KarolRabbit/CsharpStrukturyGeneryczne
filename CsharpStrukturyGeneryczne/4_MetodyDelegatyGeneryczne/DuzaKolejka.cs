using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;

namespace _4_MetodyDelegatyGeneryczne
{
    public class DuzaKolejka<T> : IKolejka<T>
    {
        protected Queue<T> kolejka;

        public DuzaKolejka()
        {
            kolejka = new Queue<T>();
        }

        public virtual bool JestPelny => throw new System.NotImplementedException();

        public virtual bool JestPusty
        {
            get
            {
                return kolejka.Count == 0;
            }
        }

        public virtual T Czytaj()
        {
            return kolejka.Dequeue();
        }

        public virtual void Zapisz(T wartosc)
        {
            kolejka.Enqueue(wartosc);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in kolejka)
            {
                yield return item;
            }
        }

    }
}