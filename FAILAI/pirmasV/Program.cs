using System;
using System.IO;

namespace pirmasV
{
    class Program
    {
        static void Main(string[] args)
        {
            //Reikia tik savo kompe konkrecia vieta nurodyt ir ten but sukurus txt
            VardasPavarde();

            Console.ReadKey();
        }
        static void VardasPavarde()
        {
            Console.WriteLine("Iveskite savo varda ir pavarde");
            string vardas = Console.ReadLine();
            string pavarde = Console.ReadLine();

            string failoVieta = @"C:\Users\tumas\source\failas.txt";
            string tekstasFailui = vardas + " " + pavarde;

            try
            {
                using (StreamWriter sw = new StreamWriter(failoVieta, false, System.Text.Encoding.Default))
                {
                    sw.WriteLine(tekstasFailui);
                }

                using (StreamWriter sw = new StreamWriter(failoVieta, true, System.Text.Encoding.Default))
                {
                    sw.WriteLine("kjfgukfxnhgd");
                    sw.Write(1000000000);
                }
                Console.WriteLine("Pavyko!");
                FileInfo fi = new FileInfo(failoVieta);
                Console.WriteLine($"Failo dydis: {fi.Length}");
                Console.WriteLine($"Failas yra: {failoVieta}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
