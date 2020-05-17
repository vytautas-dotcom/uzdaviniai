using System;
using System.Data.SqlClient;

namespace OOP_A
{
    static class Program
    {        
        private static void Main(string[] args)
        {
            Console.Write("Iveskite pirma skaiciu: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Iveskite antra skaiciu: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Calculator skaiciuotuvas = new Calculator();
            Console.WriteLine("=====================================");
            Console.Write("Dvieju skaiciu sudetis\t=\t");
            skaiciuotuvas.Paskaiciuok = new Sudetis();            
            skaiciuotuvas.GautiReiksmes(a, b);
            Console.Write("Dvieju skaiciu atimtis\t=\t");
            skaiciuotuvas.Paskaiciuok = new Atimtis();
            skaiciuotuvas.GautiReiksmes(a, b);
            Console.Write("Dvieju skaiciu daugyba\t=\t");
            skaiciuotuvas.Paskaiciuok = new Daugyba();
            skaiciuotuvas.GautiReiksmes(a, b);
            Console.Write("Dvieju skaiciu dalyba\t=\t");
            skaiciuotuvas.Paskaiciuok = new Dalyba();
            skaiciuotuvas.GautiReiksmes(a, b);
            Console.ReadKey();
        }
    }
}