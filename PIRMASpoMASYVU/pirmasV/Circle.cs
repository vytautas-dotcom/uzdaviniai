using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pirmasV
{
    class Circle : Figura
    {
        public int Spindulys { get; set; }
        public Circle(int r)
        {
            Spindulys = r;
        }
        public void Plotas()
        {
            double plotas = Math.PI * Math.Pow(Spindulys, 2);
            Console.WriteLine($"Apskritimo plotas: {plotas}");
        }
        public void Perimetras()
        {
            double perimetras = Math.PI * Spindulys * 2;
            Console.WriteLine($"Apskritimo perimetras: {perimetras}");
        }
    }
}
