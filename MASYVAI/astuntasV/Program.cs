using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace astuntasV
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
            //Console.WriteLine("Masyvo dydi");
            //int n = Int32.Parse(Console.ReadLine());
            int[] arr = new int[1000000];
            Random rand = new Random();
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(1, 11);
            }
            stopwatch.Stop();

            
            Console.WriteLine("Trukme: {0}", stopwatch.Elapsed);
        }
    }
}
