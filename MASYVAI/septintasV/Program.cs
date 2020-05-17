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
            Masyvas1();
            Console.ReadKey();
        }
        static void Masyvas1()
        {
            int[] arr = new int[10];
            int[] brr = new int[3];
            Console.WriteLine("Iveskite pirma masyva");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Iveskite skaiciu nr. {i+1}:");
                arr[i] = Int32.Parse(Console.ReadLine());
            }

            Console.WriteLine("Iveskite antra masyva");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Iveskite skaiciu nr. {i+1}:");
                brr[i] = Int32.Parse(Console.ReadLine());
            }
            int p;
            for (int i = 0; i < arr.Length; i++)
            {
                for (p = 0; p < brr.Length; p++)
                    if (arr[i] == brr[p])
                        break;

                if (p == brr.Length)
                    Console.WriteLine("nera");
            }
            Console.WriteLine("yra"); ;
        }
    }
}
