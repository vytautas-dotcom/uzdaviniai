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

            int[,] arr = new int[2, 3];
            int[,] brr = new int[3, 2];


            Console.WriteLine("Iveskite matricas");
            Console.WriteLine("Pirma matrica:");

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine($"iveskite {i+1} eulute {j+1} nari");
                    arr[i, j] = Int32.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Antra matrica:");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine($"iveskite {i + 1} eulute {j + 1} nari");
                    arr[i, j] = Int32.Parse(Console.ReadLine());
                }
            }

            int[,] crr = new int[2, 2];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        crr[i, j] += arr[j, k] + brr[k, j];
                    }
                }
            }

            int eilutes = crr.GetUpperBound(0) + 1;
            int stulpeliai = crr.Length / eilutes;
            int suma = 0;

            for (int i = 0; i < eilutes; i++)
            {
                for (int j = 0; j < stulpeliai; j++)
                {
                    Console.Write(crr[i, j]); 
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
