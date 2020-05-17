using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pirmasV
{
    class Program
    {
        static void Main(string[] args)
        {
            int sk = 5;
            Console.WriteLine($"Kintamojo sk reiksme pries metoda: {sk}");

            Console.WriteLine($"Kintamojo sk reiksme naudojant metoda: {PakelkKvadratu(sk)}");

            Console.WriteLine($"Kintamojo sk reiksme po metodo panaudojimo: {sk}");

            Console.ReadKey();
        }
        static int PakelkKvadratu(int a)
        {
            return a * a;
        }
    }
}
