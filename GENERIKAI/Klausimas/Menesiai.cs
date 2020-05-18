using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klausimas
{
    class Menesiai
    {
        List<(string, int, int)> darboPoilsioDienos = new List<(string, int, int)>()
        {("Sausis", 22, 9), 
            ("Vasaris", 20, 8), 
            ("Kovas", 21, 10), 
            ("Balandis", 21, 9), 
            ("Geguze", 20, 11),
            ("Birzelis", 21, 9), 
            ("Liepa", 22, 9), 
            ("Rugpjutis", 21, 9), 
            ("Rugsejis", 22, 8), 
            ("Spalis", 22, 9), 
            ("Lapkritis", 20, 10), 
            ("Gruodis", 21, 10)};

        
        public void Rasti()
        {
                Console.WriteLine("Iveskite menesi: ");
                string men = Console.ReadLine();

            for (int i = 0; i < darboPoilsioDienos.Count; i++)
            {
                if (darboPoilsioDienos[i].Item1 == men)
                {
                    Console.WriteLine($"{darboPoilsioDienos[i].Item1} turi {darboPoilsioDienos[i].Item2} darbo ir " +
                        $"{darboPoilsioDienos[i].Item3} poilsio dienas.");
                    break;
                }
            }
        }
    }
}
