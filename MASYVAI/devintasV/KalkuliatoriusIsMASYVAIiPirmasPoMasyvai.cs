using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace devintasV
{
    class KalkuliatoriusIsMASYVAIiPirmasPoMasyvai
    {
            public int a;
            public int b;

            public static void Sudek(int x, int y)
            {
                Console.WriteLine($"Suma: {x + y}");
            }
            public static void Atimk(int x, int y)
            {
                Console.WriteLine($"Skirtumas: {x - y}");
            }
            public static void Daugink(int x, int y)
            {
                Console.WriteLine($"Sandauga: {x * y}");
            }
            public static void Dalink(int x, int y)
            {
                Console.WriteLine($"Dalmuo: {(double)(x / y)}");
            }
    }
}
