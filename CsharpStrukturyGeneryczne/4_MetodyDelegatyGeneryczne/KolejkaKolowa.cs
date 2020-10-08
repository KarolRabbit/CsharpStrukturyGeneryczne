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

                if (kolejka.Count > _pojemnosc) kolejka.Dequeue();
            }

            public override bool JestPelny
            {
                get
                {
                    return kolejka.Count == _pojemnosc;
                }
            }
        }
    
}
