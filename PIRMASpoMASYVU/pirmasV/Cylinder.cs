using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pirmasV
{
    class Cylinder : Figura
    {
        public int Spindulys { get; set; }
        public int Aukstis { get; set; }
        public Cylinder(int r, int h)
        {
            Spindulys = r;
            Aukstis = h;
        }
        public double pagrinduPlotas()
        {
            double plotas = Math.PI * Math.Pow(Spindulys, 2) * 2;
            Console.WriteLine($"Cilindro pagrindu plotas: {plotas}");
            return plotas;
        }
        public double soninisPlotas()
        {
            double plotas = Math.PI * Spindulys * 2 * Aukstis;
            Console.WriteLine($"Cilindro soninis plotas: {plotas}");
            return plotas;
        }
        public void visasPlotas()
        {
            double plotas = (Math.PI * Math.Pow(Spindulys, 2) * 2) + (Math.PI * Spindulys * 2 * Aukstis);
            Console.WriteLine($"Cilindro visas plotas: {plotas}");
        }
        public void Perimetras()
        {
            double perimetras = Math.PI * Spindulys * 2 * 2;
            Console.WriteLine($"Apskritimu perimetras: {perimetras}");
        }
        public void Turis()
        {
            double turis = ((Math.PI * Math.Pow(Spindulys, 2) * 2)) / 2 * Aukstis;
            Console.WriteLine($"Turis: {turis}");
        }
    }
}
