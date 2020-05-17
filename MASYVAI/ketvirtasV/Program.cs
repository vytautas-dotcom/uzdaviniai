using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ketvirtasV
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
            Console.WriteLine("Masyvo dydi");
            int nr = Int32.Parse(Console.ReadLine());
            int[] arr = new int[nr];
            int[] brr = new int[nr];
            Random rand = new Random();
            int ctr;

            for (int i = 0; i < nr; i++)
            {
                arr[i] = rand.Next(1, 11);
                brr[i] = -1;
            }

            for (int i = 0; i < nr; i++)
            {
                ctr = 1;
                for (int j = i + 1; j < nr; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        ctr++;
                        brr[j] = 0;
                    }
                }

                if (brr[i] != 0)
                {
                    brr[i] = ctr;
                }
            }
            Console.Write("\nElementu pasikartojimo daznis: \n");
            for (int l = 0; l < nr; l++)
            {
                if (brr[l] != 0)
                {
                    Console.Write("{0} elementas kartojasi {1} kartus\n", arr[l], brr[l]);
                }
            }

        }
    }
}
