using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace treciasV
{
    
    class Program
    {
        struct Studentai
        {
            public string Vardas;
            public string Pavarde;
            public int Pazymys;
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite skaiciu, kiek is viso yra studentu");
            int viso = Int32.Parse(Console.ReadLine());
            Console.Write("\n\nVeskite studentu duomenis :\n");
            Console.Write("---------------------------------------------\n");
            Studentai[] stud = new Studentai[viso];

            for (int i = 0; i < viso; i++)
            {
                Console.WriteLine($"-----Studentas nr. {i+1}-----");
                Console.Write("Studento vardas : ");
                string vard = Console.ReadLine();
                stud[i].Vardas = vard;

                Console.Write("Studento pavarde : ");
                string pav = Console.ReadLine();
                stud[i].Pavarde = pav;

                Console.Write("Pazymys : ");
                int paz = Convert.ToInt32(Console.ReadLine());
                stud[i].Pazymys = paz;
            }
            Console.Write("---------------------------------------------\n");
            Console.WriteLine("Duomenys apie studentus issaugoti:");

            for (int i = 0; i < stud.Length; i++)
            {
                Console.WriteLine($"Vardas: {stud[i].Vardas}, Pavarde: {stud[i].Pavarde}, Pazymys: {stud[i].Pazymys}");
            }

            Console.ReadKey();

        }
    }
}
