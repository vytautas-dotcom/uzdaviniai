using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_A
{
    class Calculator
    {
        public ICalculator Paskaiciuok { get; set; }
        public void GautiReiksmes(double a, double b)
        {
            Paskaiciuok.CalcNumbers(a, b);
        }
    }
}
