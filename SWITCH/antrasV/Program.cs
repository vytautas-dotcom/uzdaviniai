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
            gaukPrognoze();

            Console.ReadKey();
        }
        static void gaukPrognoze()
        {
            Console.WriteLine("Iveskite temperatura");
            int temperatura = Int32.Parse(Console.ReadLine());

            if (temperatura < 0)
                Console.WriteLine("Šalta");
            else if (temperatura >= 0 && temperatura < 10)
                Console.WriteLine("Vėsu");
            else if (temperatura >= 10 && temperatura < 20)
                Console.WriteLine("Šilta");
            else if (temperatura >= 20 && temperatura < 30)
                Console.WriteLine("Karsta");
            else
                Console.WriteLine("Ivesta temperatura nepapuola nei i viena aprasyta rezi");


            //bool isTrue = true;

            //switch (isTrue)
            //{
            //    case (temperatura < 0):
            //        Console.WriteLine("Šalta");
            //        break;
            //    case (temperatura >= 0 && temperatura < 10):
            //        Console.WriteLine("Vėsu");
            //        break;
            //    case (temperatura >= 10 && temperatura < 20):
            //        Console.WriteLine("Šilta");
            //        break;
            //    case (temperatura >= 20 && temperatura < 30):
            //        Console.WriteLine("Karsta");
            //        break;
            //    default:
            //        Console.WriteLine("Ivesta temperatura nepapuola nei i viena aprasyta rezi");
            //        break;
            //}
        }
    }
}
