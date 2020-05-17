using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace treciasV
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite savo vardas");
            string vardas = Console.ReadLine();

            var tuplas = (10, vardas, 2.5);
            Console.WriteLine(tuplas.Item2);
        }
    }
}
