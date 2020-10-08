using System.Collections.Generic;

namespace _3_KlasyIInterfejsyGeneryczne
{
    public interface IKolejka<T> :IEnumerable<T>
    {
        bool JestPelny { get; }
        bool JestPusty { get; }

        T Czytaj();
        void Zapisz(T wartosc);
    }
}