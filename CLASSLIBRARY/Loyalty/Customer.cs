using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loyalty
{
    internal class Customer : IPrintable, IComparable<Customer>
    {
        public string vardas;
        private double lojalumoTaskai { get; set; }
        public Customer(string vardas)
        {
            this.vardas = vardas;
        }

        public void Print()
        {
            Console.WriteLine(ToString());
        }

        public int CompareTo(Customer other)
        {
            return this.lojalumoTaskai.CompareTo(other.lojalumoTaskai);
        }

        public void RegisterPurchase(PurchaseItem preke)
        {
            if (lojalumoTaskai < 100)
            { lojalumoTaskai += preke.kaina;
                Console.WriteLine($"Jums prideta {preke.kaina} tasku"); }
            else if (lojalumoTaskai > 100)
            { lojalumoTaskai += (double)(preke.kaina + preke.kaina * 0.1);
                Console.WriteLine($"Jums prideta {preke.kaina + preke.kaina * 0.1} tasku"); }
            else if (lojalumoTaskai > 500)
                lojalumoTaskai += (double)(preke.kaina + preke.kaina * 0.2);
            Console.WriteLine($"Jums prideta {preke.kaina * 0.2} tasku");
        }
    }
}
