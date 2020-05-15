using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ketvirtas
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
            Console.WriteLine("Iveskite metus");

            int.TryParse(Console.ReadLine(), out int ivestasSkaicius);



            if ((ivestasSkaicius % 4 == 0 && ivestasSkaicius % 100 != 0) || 
                (ivestasSkaicius % 400 == 0))
                Console.WriteLine("Metai keliamieji, juose yra 366 dienos");
            else
                Console.WriteLine("Metai nera keliamieji, juose yra 365 dienos");
                    
        }
    }
}
