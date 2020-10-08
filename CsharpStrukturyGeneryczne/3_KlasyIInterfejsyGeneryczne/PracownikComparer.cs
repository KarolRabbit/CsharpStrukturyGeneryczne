using System.Collections.Generic;

namespace _3_KlasyIInterfejsyGeneryczne
{
    public class PracownikComparer: IEqualityComparer<Pracownik>, IComparer<Pracownik>
    {
        public int Compare(Pracownik x, Pracownik y)
        {
            return string.Compare(x.Nazwisko, y.Nazwisko);
        }

        public bool Equals(Pracownik x, Pracownik y)
        {
            return Equals(x.Nazwisko, y.Nazwisko);
        }

        public int GetHashCode(Pracownik obj)
        {
            return obj.Nazwisko.GetHashCode();
        }
    }
}