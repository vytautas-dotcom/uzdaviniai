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
            Console.WriteLine("Iveskite skaiciu, keliu Fibonacci sekos neriu suma nori rasti");
            Console.WriteLine(Fib(Int32.Parse(Console.ReadLine())));

            Console.ReadKey();
        }
        static int Fib(int n)
        {
            if (n == 0 || n == 1)
                return 1;
            else
                return Fib(n - 1) + Fib(n - 2);
        }
    }
    
}
