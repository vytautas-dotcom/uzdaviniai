using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace treciasV
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
            int n = Int32.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                arr[i] = rand.Next(1, 11);
            }


            int min = arr.Min();
            int max = arr.Max();
            Array.Sort(arr);
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Jusu surusiuotas masyvas");
            Console.WriteLine("------------------------------------------");
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"\n\n Max: {max} \n Min: {min}");
        }
    }
}
