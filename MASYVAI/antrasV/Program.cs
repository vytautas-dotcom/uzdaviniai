using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace antrasV
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
            Console.WriteLine("Iveskite skaiciu, kiek megstamu knygu turite");
            int n = Int32.Parse(Console.ReadLine());
            string[] arr = new string[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Iveskite knyga nr. {i+1}:");
                arr[i] = Console.ReadLine();
            }

            Array.Sort(arr);
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Jusu surusiuotos knygos");
            Console.WriteLine("------------------------------------------");
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
