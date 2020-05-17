using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace devintasV
{
    class Program
    {
        static void Main(string[] args)
        {
            Masyvas1();

            Console.ReadKey();
        }
        static void Masyvas1()
        {
            Console.WriteLine("Masyvu dydzius");
            int a = Int32.Parse(Console.ReadLine());
            int b = Int32.Parse(Console.ReadLine());
            int c = Int32.Parse(Console.ReadLine());
            int[][] arr = new int[3][];
            arr[0] = new int[a];
            arr[1] = new int[b];
            arr[2] = new int[c];
            int[] suma = new int[3];
            double sumaVisas = 0;
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    arr[i][j] = rand.Next(1, 11);
                    suma[i] += arr[i][j];
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Masyvo nr. {i+1} vidurkis {(double)suma[i]/arr[i].Length}");
                sumaVisas += (double)suma[i] / arr[i].Length;
            }
            Console.WriteLine($"Masyvu vidurkiu vidurkis {(double)sumaVisas/3}");
        }
    }
}
