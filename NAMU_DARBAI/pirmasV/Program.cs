using System;

namespace pirmasV
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu, keliu Fibonacci sekos neriu suma nori rasti");
            Console.WriteLine(Fib(Int32.Parse(Console.ReadLine())));

            Console.ReadKey();
        }

        private static int Fib(int n)
        {
            if (n == 0)
                return 0;
            else if (n == 1)
                return 1;

            return Fib(n - 1) + Fib(n - 2);
        }
    }
}