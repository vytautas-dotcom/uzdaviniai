using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace antrasV
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu, kurio faktoriala norite rasti");
            Console.WriteLine(Fib(Int32.Parse(Console.ReadLine())));

            Console.ReadKey();
        }
        static int Fib(int n)
        {
            if (n == 0 || n == 1)
                return 1;
            else
                return n * Fib(n - 1);
        }
    }
}
