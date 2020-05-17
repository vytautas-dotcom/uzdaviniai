using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace septintasV
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine($"Iveskite du skaicius, kuriuos norite sudeti ir savo varda");
            int x = Int32.Parse(Console.ReadLine());
            int y = Int32.Parse(Console.ReadLine());
            string vard = Console.ReadLine();

            Suma(vard, x, y);

            Console.ReadKey();
        }
        public static void Suma(string vardas, params int[] skaiciai)
        {
            int suma = 0;
            for (int i = 0; i < skaiciai.Length; i++)
            {
                Console.WriteLine(vardas);
                suma += skaiciai[i];
            }
            Console.WriteLine($"suma: {suma}");
        }
    }
}
