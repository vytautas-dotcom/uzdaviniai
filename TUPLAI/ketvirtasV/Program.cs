using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ketvirtasV
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 6;
            int y = 2;

            (int suma, int skirtumas, int _, double dalmuo) tuplas =  SumaAtimtisSandaugaDalyba(x, y);

            Console.WriteLine(SumaAtimtisSandaugaDalyba(2, 3).Item3);

            Console.ReadKey();
        }
        static (int, int, int _, double) SumaAtimtisSandaugaDalyba(int a, int b)
        {
            int suma = a + b;
            int skirtumas = a - b;
            int sandauga = a * b;
            double dalmuo = a / b;

            return (suma, skirtumas, sandauga, dalmuo);
         }
    }
}
