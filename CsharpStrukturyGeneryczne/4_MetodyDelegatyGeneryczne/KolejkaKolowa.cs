using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_MetodyDelegatyGeneryczne
{

    public class KolejkaKolowa<T> : DuzaKolejka<T>
    {
        private int _pojemnosc;

        public KolejkaKolowa(int pojemnosc = 5)
        {
            _pojemnosc = pojemnosc;
        }

        public override T Czytaj()
        {
            return base.Czytaj();
        }

        public override void Zapisz(T wartosc)
        {
            kolejka.Enqueue(wartosc);

            if (kolejka.Count > _pojemnosc)
            {
               var usuniety =  kolejka.Dequeue();
                PoUsunieciu(usuniety, wartosc);
            }
        }

        private void PoUsunieciu(T usuniety, T wartosc)
        {
            if(elementUsuniety != null)
            {
                var args = new ElementUsunietyEventsArgs<T>(usuniety, wartosc);
                elementUsuniety(this, args);
            }
        }

        public override bool JestPelny
        {
            get
            {
                return kolejka.Count == _pojemnosc;
            }
        }

        public event EventHandler<ElementUsunietyEventsArgs<T>> elementUsuniety;
    }

    public class ElementUsunietyEventsArgs<T> : EventArgs
    {
        public T ElementUsuniety { get; set; }
        public T ElementNowy { get; set; }

        public ElementUsunietyEventsArgs(T elementUsuniety, T elementNowy)
        {
            ElementUsuniety = elementUsuniety;
            ElementNowy = elementNowy;
        }
    }

}
