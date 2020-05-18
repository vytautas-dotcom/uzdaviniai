using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pirmasV
{
    class Automobilis
    {
        private string pavadinimas;
        private int rida;
        private int kuras;
        private readonly int maxTalpa = 50;

        public void setDuomenys(string pavadinimas, int rida, int kuras)
        {
            this.pavadinimas = pavadinimas;
            this.rida = rida;
            this.kuras = kuras;
        }
        public void Vaziuoti()
        {
            rida+=10;
            kuras--;
        }

        public void Pildyti()
        {
            Console.WriteLine("Kiek norit uzsipilt (Svarbu nevirsyti max talpos!)");
            int litrai = Convert.ToInt32(Console.ReadLine());
            if (litrai + kuras > maxTalpa)
            {
                Console.WriteLine($"Virsijate galima kieki {maxTalpa - kuras - litrai} litrais");
            }
        }
    }
}
