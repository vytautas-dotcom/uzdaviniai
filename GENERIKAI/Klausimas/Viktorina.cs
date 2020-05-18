using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klausimas
{
    class Viktorina
    {
        private static int count = 0;

        List<string> Klausimai = new List<string>()
        { " 1. Ar A?\n", " 2. Ar B?\n", " 1. Ar C?\n", " 1. Ar D?\n"};

        List<(string, string, string, string)> Atsakymai = new List<(string, string, string, string)>()
            {(" AA", " AB", " AC", " AD"), 
             (" BA", " BB", " BC", " BD"), 
             (" CA", " CB", " CC", " CD"), 
             (" DA", " DB", " DC", " DD")};

        List<string> Teisingi = new List<string>()
        {"AA", "BB", "CC", "DD"};

        List<string> atsakymai = new List<string>();
        public void Testas()
        {
            for (int i = 0; i < Klausimai.Count; i++)
            {
                Console.WriteLine(Klausimai[i]);
                Console.WriteLine("-----------------------");
                Console.WriteLine("Atsakymu variantai:");
                Console.WriteLine(Atsakymai[i]);
                Console.WriteLine("-----------------------");
                Console.WriteLine("Atsakymas: ");
                string ats = Console.ReadLine();
                if (ats == Teisingi[i])
                {
                    atsakymai.Add("Teisingas " + ats);
                    count++;
                }
                else
                    atsakymai.Add("Neteisingas " + ats);

            }
            Console.WriteLine("\n-----------------------------");
            Console.WriteLine($"Atsakyta teisingai: {count}");
            Console.WriteLine("-----------------------------\n");
            Console.WriteLine("Teisingi neteisingi atsakymai");
            for (int i = 0; i < atsakymai.Count; i++)
            {
                Console.WriteLine(atsakymai[i]);
            }
        }

        
    }
}