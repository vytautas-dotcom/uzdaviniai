using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace antras
{
    class Program
    {
        static void Main(string[] args)
        {
            getKMI();

            Console.ReadKey();
        }
        static void getKMI()
        {
            Console.WriteLine("Iveskite savo svori (kg) ir ugi (m)");
            int svoris = Int32.Parse(Console.ReadLine());
            double ugis = double.Parse(Console.ReadLine());
            double KMI = svoris / (Math.Pow(ugis, 2));
            Console.WriteLine($"Jusu KMI = {Math.Round(KMI, 2)}");
        }
    }
}
