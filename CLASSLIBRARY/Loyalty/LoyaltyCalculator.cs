using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loyalty
{
    internal class LoyaltyCalculator
    {
        private Customer Klientai { get; set; }
        private PurchaseItem Prekes { get; set; }
        public LoyaltyCalculator(string vardas, string pavadinimas, int kaina)
        {
            Klientai.vardas = vardas;
            Prekes.pavadinimas = pavadinimas;
            Prekes.kaina = kaina;
        }
        public void PrintCustomer()
        {
            Klientai.Print();
        }
        public void PrintItems()
        {
            Prekes.Print();
        }
        public void RegisterPurchase(Customer vardas, PurchaseItem pavadinimas)
        {
            vardas.RegisterPurchase(pavadinimas);
        }
    }
}
