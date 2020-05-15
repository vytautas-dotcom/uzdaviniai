using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trecias
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
            Console.WriteLine("Iveskite temperatura");

            int.TryParse(Console.ReadLine(), out int ivestasSkaicius);

            if (ivestasSkaicius == 0)
                Console.WriteLine("Salta");
            else if (ivestasSkaicius > 0 && ivestasSkaicius <= 10)
                Console.WriteLine("Vesu");
            else if (ivestasSkaicius > 10 && ivestasSkaicius <= 20)
                Console.WriteLine("Silta");
            else if (ivestasSkaicius > 20 && ivestasSkaicius <= 30)
                Console.WriteLine("Karsta");
            else
                Console.WriteLine("Temperatura nepapuola nei i viena aprasyta rezi");
        }
    }
}
