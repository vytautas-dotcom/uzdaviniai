using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sestasV
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine($"Iveskite du skaicius, kuriuos norite sudeti");
            int x = Int32.Parse(Console.ReadLine());
            int y = Int32.Parse(Console.ReadLine());

            Suma(x, y);

            Console.ReadKey();
        }
        public static void Suma(params int[] skaiciai)
        {
            int suma = 0;
            for (int i = 0; i < skaiciai.Length; i++)
            {
                suma += skaiciai[i];
            }
            Console.WriteLine($"suma: {suma}");
        }
    }
}
