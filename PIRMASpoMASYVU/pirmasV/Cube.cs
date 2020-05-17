using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pirmasV
{
    internal class Cube : Square
    {
        public int Krastine { get; set; }
        public Cube(int a) : base(a)
        {
            Krastine = a;
        }
        public void Plotas()
        {
            double plotas = Krastine * Krastine * 6;
            Console.WriteLine($"Kubo plotas: {plotas}");
        }
        public void Turis()
        {
            double turis = Math.Pow(Krastine, 3);
            Console.WriteLine($"Turis perimetras: {turis}");
        }
    }
}
