using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace penktasV
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            int eilutes = arr.GetUpperBound(0) + 1;
            int stulpeliai = arr.Length / eilutes;
            int suma = 0;

            for (int i = 0; i < eilutes; i++)
            {
                for (int j = 0; j < stulpeliai; j++)
                {
                    suma += arr[i, j];
                }
            }

            Console.WriteLine(suma);

            Console.ReadLine();
        }
    }
}
