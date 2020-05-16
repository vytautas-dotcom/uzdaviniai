using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace treciasV
{
    class Program
    {
        enum leduPavadinimas
        {
            Nuostabieji_braskiu_skonio_raudoni = 1,
            Skanieji_metu_skonio_zali,
            Puikieji_pistaciju_skonio_geltoni
        }
        enum numeriuNumeracija
        {
            Pirmi_ledai = 1,
            Antri_ledai,
            Treti_ledai
        }

        struct Ledai
        {
            public void leduKaina(int rusis)
            {
                Console.WriteLine($"Jus pasirinkote {Enum.GetName(typeof(leduPavadinimas), rusis)} ledus, viso moketi: {Kaina(rusis - 1)} eur");
            }
            public void leduKaina2(int kiekis)
            {
                int[] numeriai = new int[kiekis];
                Console.WriteLine("Iveskites pasirinktu ledu numerius");
                for (int i = 0; i < numeriai.Length; i++)
                {
                    Console.WriteLine(Enum.GetName(typeof(numeriuNumeracija), i+1));
                    numeriai[i] = Int32.Parse(Console.ReadLine());
                }
                double kainaViso = 0;

                Console.WriteLine("Jusu pasirinkti ledai:\n");

                for (int i = 0; i < numeriai.Length; i++)
                {
                    leduKaina(numeriai[i]);
                    kainaViso += Kaina(i);
                }

                Console.WriteLine($"Moketi viso: {kainaViso}");
            }
            public double Kaina(int i)
            {
                double[] kainos = { 2.2, 2.5, 3.0 };
                return kainos[i];
            }
        }
        static void Main(string[] args)
        {
            Ledai ledai = new Ledai();

            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("--------------------------Visi ledai---------------------------");
            Console.WriteLine("---------------------------------------------------------------");
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine($"Ledu nr.{i}: {Enum.GetName(typeof(leduPavadinimas), i)}\t\t\t{ledai.Kaina(i - 1)}");
            }
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("Irasykite norimu ledu rusiu skaiciu: ");

            int nr = Int32.Parse(Console.ReadLine());
            ledai.leduKaina2(nr);

            Console.ReadKey();
        }
    }
}
