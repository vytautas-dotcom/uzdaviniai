using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pirmasV
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
            Console.WriteLine("Iveskite penkis skaicius");
            int[] arr = new int[5];
            int[] brr = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Iveskite skaiciu nr. {i}:");
                arr[i] = Int32.Parse(Console.ReadLine());
                brr[i] = arr[i] * arr[i];
            }
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Jusu ivestu skaiciu ir ju kvadratu masyvai");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Skaiciai\t\t\tKvadratai");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"{arr[i]}\t\t\t\t{brr[i]}");
            }
        }
    }
}
