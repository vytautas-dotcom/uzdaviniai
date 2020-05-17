using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_A
{
    public class Atimtis : ICalculator
    {
        public void CalcNumbers(double a, double b)
        {
            Console.WriteLine(a - b);
        }
    }
}
