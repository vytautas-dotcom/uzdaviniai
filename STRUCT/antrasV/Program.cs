using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace antrasV
{
    struct Koordinates
    {
        public int x;
        public int y;
        public void setKoordinates(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public void sudetiKoordinates()
        {
            Console.WriteLine($"{x + y}");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Koordinates koordinates = new Koordinates();
            koordinates.setKoordinates(5, 8);
            koordinates.sudetiKoordinates();

            Console.ReadKey();
        }
    }
}
