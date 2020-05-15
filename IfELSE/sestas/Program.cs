using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sestas
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
            Console.WriteLine("Iveskite du skaicius");

            int.TryParse(Console.ReadLine(), out int ivestasSkaicius1);
            int.TryParse(Console.ReadLine(), out int ivestasSkaicius2);

            if (ivestasSkaicius1 % 2 == 0 && ivestasSkaicius2 % 2 == 0)
                Console.WriteLine("Abu skaičiai lyginiai");
            else if ((ivestasSkaicius1 % 2 == 0 && ivestasSkaicius2 % 2 != 0) || (ivestasSkaicius1 % 2 != 0 && ivestasSkaicius2 % 2 == 0))
                Console.WriteLine("Bent vienas iš skaičių nėra lyginis");
            else
                Console.WriteLine("Abu nelyginiai");
        }
    }
}
