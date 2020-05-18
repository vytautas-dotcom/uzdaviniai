using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pirmasV
{
    static class Calculator
    {
        public static void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public static void Substract(int a, int b)
        {
            Console.WriteLine(a - b);
        }
        public static void Multiply(int a, int b)
        {
            Console.WriteLine(a * b);
        }
        public static void Divide(int a, int b)
        {
            Console.WriteLine((double)(a / b));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Calculator.Add(12, 6);
            Calculator.Substract(12, 6);
            Calculator.Multiply(12, 6);
            Calculator.Divide(12, 6);

            Console.ReadKey();
        }
    }
}
