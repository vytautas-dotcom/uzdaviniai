using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace penktasV
{
    class Program
    {
        static void Main(string[] args)
        {
            int sk = 5;
            int sk2 = 1;
            Console.WriteLine($"Kintamojo sk reiksme pries metoda: {sk}");
            PakelkKvadratu(sk2, in sk);

            Console.WriteLine($"Kintamojo sk reiksme panaudojus metoda: {sk}");

            Console.WriteLine($"Kintamojo sk reiksme po metodo panaudojimo: {sk}");

            Console.ReadKey();
        }
        public static void PakelkKvadratu(int sk2, in int sk)
        {
            //sk = sk2;  sito neleidzia modifikuoti
            sk2 = sk;
        }
    }
}
