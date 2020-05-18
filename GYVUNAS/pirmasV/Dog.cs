using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pirmasV
{
    class Dog : Gyvunas
    {
        public int lojimuSk = 0;

        public Dog(string seima) : base()
        {
            this.seima = seima;
        }
        public void Bark()
        {
            Console.WriteLine("Au au");
            lojimuSk++;
        }
    }
}
