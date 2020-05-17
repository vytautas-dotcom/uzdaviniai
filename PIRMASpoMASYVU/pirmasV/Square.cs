using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pirmasV
{
    class Square : Figura
    {
        public int Krastine { get; set; }
        public Square(int a)
        {
            Krastine = a;
        }
        public void Plotas()
        {
            double plotas = Krastine * Krastine;
            Console.WriteLine($"Kvadrato plotas: {plotas}");
        }
        public void Perimetras()
        {
            double perimetras = Krastine * 4;
            Console.WriteLine($"Kvadrato perimetras: {perimetras}");
        }
    }
}
