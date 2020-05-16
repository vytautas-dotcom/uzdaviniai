using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace antrasV
{
    class Program
    {
        enum leduPavadinimas
        {
            Nuostabieji_braskiu_skonio_raudoni = 1,
            Skanieji_metu_skonio_zali,
            Puikieji_pistaciju_skonio_geltoni
        }
        
        struct Ledai
        {
            public void leduKaina(int rusis)
            {
                Console.WriteLine($"Jus pasirinkote {Enum.GetName(typeof(leduPavadinimas), rusis)} ledus, viso moketi: {Kaina(rusis-1)} eur");
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
                Console.WriteLine($"Ledu nr.{i}: {Enum.GetName(typeof(leduPavadinimas), i)}\t\t\t{ledai.Kaina(i-1)}");
            }
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("Isirinkite ledus is saraso ivesdami numeri");
            
            int nr = Int32.Parse(Console.ReadLine());
            ledai.leduKaina(nr);

            Console.ReadKey();
        }
    }
}
