using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_KlasyIInterfejsyGeneryczne
{
    public class DzialyKolekcja: SortedDictionary<string, SortedSet<Pracownik>>
    {
        public DzialyKolekcja Add(string dzial, Pracownik pracownik)
        {
            if(!this.ContainsKey(dzial))
            {
                this.Add(dzial, new SortedSet<Pracownik>(new PracownikComparer()));
            }
            this[dzial].Add(pracownik);
            return this;
        }
    }
}
