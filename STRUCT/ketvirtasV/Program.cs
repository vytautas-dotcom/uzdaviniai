using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ketvirtasV
{
    class Program
    {
        struct Miestai
        {
            public string Pavadinimas;
            public int Gyventojai;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu, kiek is viso yra miestu");
            int viso = Int32.Parse(Console.ReadLine());
            Console.Write("\n\nVeskite duomenis apie miestus :\n");
            Console.Write("---------------------------------------------\n");
            Miestai[] miest = new Miestai[viso];

            for (int i = 0; i < viso; i++)
            {
                Console.WriteLine($"-----Miestas nr. {i + 1}-----");
                Console.Write("Miesto pavadinimas : ");
                string pav = Console.ReadLine();
                miest[i].Pavadinimas = pav;

                Console.Write("Gyventoju skaicius : ");
                int skaic = Convert.ToInt32(Console.ReadLine());
                miest[i].Gyventojai = skaic;
            }
            Console.Write("---------------------------------------------\n");
            Console.WriteLine("Duomenys apie miestus issaugoti:");

            Console.WriteLine("Miestai: ");
            int visoGyventoju = 0;
            int count = 0;
            for (int i = 0; i < miest.Length; i++)
            {
                Console.WriteLine($"\t{miest[i].Pavadinimas}");
                visoGyventoju += miest[i].Gyventojai;
                count++;
            }
            Console.WriteLine($"Vidutinis gyventoju skaicius miestuose: {(double)visoGyventoju/count}");

            Console.ReadKey();

        }
    }
}
