using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pirmasV
{
    class Lizard : Gyvunas
    {
        public int musiuSk = 0;

        public Lizard(string seima) : base()
        {
            this.seima = seima;
        }
        public void CatchFly()
        {
            Console.WriteLine("Gaudo");
            musiuSk++;
        }
    }
}
