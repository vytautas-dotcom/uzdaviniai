using System;

namespace OOP_A
{
    internal class Sudetis : ICalculator
    {
        public void CalcNumbers(double a, double b)
        {
            Console.WriteLine(a + b);
        }
    }
}