using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace astuntasV
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine($"Iveskite du skaicius, kuriuos norite sudeti ir savo varda");
            int x = Int32.Parse(Console.ReadLine());
            int y = Int32.Parse(Console.ReadLine());
            int suma;
            Sandauga(x, out suma, y);
            Console.WriteLine($"suma: {suma}");

            Console.ReadKey();
        }
        public static void Sandauga(int sk1, out int suma, int sk2 = 1)
        {
            suma = sk1 * sk2;
        }
    }
}
