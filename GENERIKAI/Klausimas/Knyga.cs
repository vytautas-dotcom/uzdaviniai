using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klausimas
{
    class Knyga
    {
        Dictionary<int, Person> knyga = new Dictionary<int, Person>();
        ConsoleKeyInfo status;
        bool isTrue = true;
        
        public void Irasas()
        {
            while (isTrue)
            {

                Console.WriteLine("\nIveskite varda");
                string vardas = Console.ReadLine();
                Console.WriteLine("\nIveskite pavarde");
                string pavarde = Console.ReadLine();
                Console.WriteLine("\nIveskite tel.nr.formatu(0000)");
                int tel = Convert.ToInt32(Console.ReadLine());
                knyga.Add(tel, new Person() { Vardas = vardas, Pavarde = pavarde});

                Console.WriteLine("\n\n Baigti? (Y/y)\t\t Testi(N/n)\n");
                status = Console.ReadKey();
                if (status.Key == ConsoleKey.Y)
                {
                    isTrue = false;
                }
                else if (status.Key == ConsoleKey.N)
                    isTrue = true;
            }
            
        }
        public void Paieska()
        {
            Console.WriteLine("\nIveskite varda arba pavarde arba dali is kazkurio is ju\n");
            string paieska = Console.ReadLine();
                

            foreach (KeyValuePair<int, Person> keyValue in knyga)
            {
                if (keyValue.Value.Vardas.IndexOf(paieska) >= 0 || keyValue.Value.Pavarde.IndexOf(paieska) >= 0)
                {
                    Console.WriteLine(keyValue.Value.Vardas + " " + keyValue.Value.Pavarde + " - " + keyValue.Key);
                }
                    
            }
        }
        public void Trynimas()
        {
            foreach (KeyValuePair<int, Person> keyValue in knyga)
            {
                Console.WriteLine(keyValue.Value.Vardas + " " + keyValue.Value.Pavarde + " - " + keyValue.Key);
            }
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("\nIveskite tel. nr. pagal kuri norite istrinti irasa\n");
            int trintNr = Convert.ToInt32(Console.ReadLine());


            foreach (KeyValuePair<int, Person> keyValue in knyga)
            {
                if (keyValue.Key == trintNr)
                {
                    knyga.Remove(trintNr);
                    break;
                }

            }

            foreach (KeyValuePair<int, Person> keyValue in knyga)
            {
                Console.WriteLine(keyValue.Value.Vardas + " " + keyValue.Value.Pavarde + " - " + keyValue.Key);
            }
        }
    }

}
