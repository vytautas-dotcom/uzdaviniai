using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pirmas
{
    class Program
    {
        static void Main(string[] args)
        {
            Tikrink();

            Console.ReadKey();
        }
        static void Tikrink()
        {
            Console.WriteLine("Iveskite skaiciu");
            
                int.TryParse(Console.ReadLine(),out int ivestasSkaicius);

            if (ivestasSkaicius > 0)
                Console.WriteLine("Teigiamas");
            else if(ivestasSkaicius < 0)
                Console.WriteLine("NEIGIAMAS");
            else
                Console.WriteLine("NULIS");
        }
    }
}
