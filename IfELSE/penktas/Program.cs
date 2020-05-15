using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace penktas
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

            bool isTrue = int.TryParse(Console.ReadLine(), out int ivestasSkaicius);

            if (isTrue)
            {
                if(ivestasSkaicius == 1)
                    Console.WriteLine("Mes nugalėjom");
                else if(ivestasSkaicius >= 2 && ivestasSkaicius <= 10)
                    Console.WriteLine("Neblogas pasirodymas");
                else if(ivestasSkaicius > 10)
                    Console.WriteLine("kitąmet bandysim vėl");
                else
                    Console.WriteLine("Ivestas netinkamas skaicius");
            }
            else
                Console.WriteLine("Ivestas netinkamas zenklas");
        }
    }
}
