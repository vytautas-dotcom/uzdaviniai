using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pirmasV
{
    class Gyvunas
    {
        public string vardas;
        public string seima;
        public Gyvunas() 
        {
            vardas = "Bob";
            seima = "Suniniai";
        }
        public Gyvunas(string vardas, string seima) : this()
        {
            this.vardas = vardas;
            this.seima = seima;
        }
        public void Greet()
        {
            Console.WriteLine($"Labas aš {vardas} iš {seima} giminės");
        }
    }
}
