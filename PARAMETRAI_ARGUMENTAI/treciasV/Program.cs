using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace treciasV
{
    class Program
    {
        static void Main(string[] args)
        {
            int sk = 5;
            Console.WriteLine($"Kintamojo sk reiksme pries metoda: {sk}");
            PakelkKvadratu(ref sk);

            Console.WriteLine($"Kintamojo sk reiksme panaudojus metoda: {sk}");

            Console.WriteLine($"Kintamojo sk reiksme po metodo panaudojimo: {sk}");

            Console.ReadKey();
        }
        public static ref int PakelkKvadratu(ref int sk)
        {
            return ref sk * sk;
        }
    }
}
