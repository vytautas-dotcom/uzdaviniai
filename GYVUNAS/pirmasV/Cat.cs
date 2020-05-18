using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pirmasV
{
    class Cat : Gyvunas
    {
        public int miaukimuSk = 0;

        public Cat(string seima) : base()
        {
            this.seima = seima;
        }
        public void Meow()
        {
            Console.WriteLine("Miau miau");
            miaukimuSk++;
        }
    }
}
