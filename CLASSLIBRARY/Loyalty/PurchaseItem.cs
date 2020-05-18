using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loyalty
{
    internal class PurchaseItem : IPrintable, IComparable<PurchaseItem>
    {
        public string pavadinimas;
        public int kaina;
        public PurchaseItem(string pavadinimas, int kaina)
        {
            this.pavadinimas = pavadinimas;
            this.kaina = kaina;
        }
        public override string ToString()
        {
            return "Pavadinimas: " + pavadinimas + ", Kaina: " + kaina;
        }

        public void Print()
        {
            Console.WriteLine(ToString());
        }

        public int CompareTo(PurchaseItem obj)
        {
            return this.pavadinimas.CompareTo(obj.pavadinimas);
        }
    }
}
