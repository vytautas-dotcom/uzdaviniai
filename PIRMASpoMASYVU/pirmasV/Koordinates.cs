using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pirmasV
{
    class Koordinates
    {
        public int koordX { get; set; }
        public int koordY { get; set; }
        public string Spalva { get; set; }
        public Koordinates()
        {
            koordX = 1;
            koordY = 3;
            Spalva = "yellow";
        }
        public Koordinates(int x, int y)
        {
            koordX = 1;
            koordY = 3;
            Spalva = "purple";
        }
        public Koordinates(int x, int y, string spalva)
        {
            koordX = x;
            koordY = y;
            Spalva = spalva;
        }
        public Koordinates(string spalva)
        {
            koordX = 2;
            koordY = 2;
            Spalva = spalva;
        }
        #region Atstumas
        public void Atstumas()
        {
            Console.WriteLine("Iveskite x ir y koordinates. Atstumas bus skaiciuojamas tarp sio tasko ir tasko \nkoordinaciu, kurios suvestos tusciame klases Koordinates konstruktoriuje");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());

            double atstumas = 0;

            atstumas = Math.Sqrt(Math.Pow((koordX - x), 2) + Math.Pow((koordY - y), 2));

            Console.WriteLine($"Atstumas tarp siu tasku lygus: {atstumas}");
        }
        #endregion

        #region Ketvirtis
        public void Ketvirtis()
        {
            if (koordX > 0 && koordY > 0)
                Console.WriteLine("Pirmas");
            else if (koordX > 0 && koordY < 0)
                Console.WriteLine("Antras");
            else if (koordX < 0 && koordY < 0)
                Console.WriteLine("Trecias");
            else if (koordX < 0 && koordY > 0)
                Console.WriteLine("Ketvirtas");
        }
        #endregion

    }
}
