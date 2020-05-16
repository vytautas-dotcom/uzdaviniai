using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace pirmasV
{
    class Program
    {
        enum Pazymiai
        {
            nepatekinamai,
            silpnai = 5,
            patenkinamai = 6,
            vidutiniškai = 7,
            gerai = 8,
            labai_gerai = 9,
            puikiai = 10
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite pazymi desimtbaleje sistemoje\n\n");
            int pazymys = Int32.Parse(Console.ReadLine());


            if (pazymys >= 0 && pazymys <= 4)
            {

                pazymys = 0;
            }


            Console.WriteLine($"Ivertinimas: {Enum.GetName(typeof(Pazymiai), pazymys)}");

            Console.ReadKey();
        }

    }
}
