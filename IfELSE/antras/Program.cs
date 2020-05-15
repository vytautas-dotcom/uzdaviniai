using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace antras
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

            int.TryParse(Console.ReadLine(), out int ivestasSkaicius);

            if (ivestasSkaicius % 2 == 0 && ivestasSkaicius % 3 == 0)
                Console.WriteLine("2 ir 3 kartotinis");
            else if (ivestasSkaicius % 2 == 0 && ivestasSkaicius % 3 != 0)
                Console.WriteLine("LYGINIS");
            else if (ivestasSkaicius % 2 != 0)
                Console.WriteLine("NELYGINIS");
        }
    }
}
