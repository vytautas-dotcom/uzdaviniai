using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pirmasV
{
    class Figura
    {
        static int count = 0;

        public string Pavadinimas { get; set; }
        public string Spalva { get; set; }
        public Figura()
        {
            count++;
        }
        public void getFiguruSkaicu()
        {
            Console.WriteLine($"Is viso sukurta {count} figuros");
        }
    }
}
