using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace treciasV
{
    class Program
    {
        static void Main(string[] args)
        {
            gaukSpalva();

            Console.ReadKey();
        }
        static void gaukSpalva()
        {
            Console.WriteLine("Iveskite skaiciu");
            int skaicus = Int32.Parse(Console.ReadLine());

            if (skaicus > 0 && skaicus < 400)
                Console.WriteLine($"Mokesciai: {0}, Alga i rankas: {skaicus}");
            else if (skaicus >= 400 && skaicus < 1000)
                Console.WriteLine($"Mokesciai: {skaicus*0.1}, Alga i rankas: {skaicus-(skaicus*0.1)}");
            else if (skaicus >= 1000 && skaicus < 3000)
                Console.WriteLine($"Mokesciai: {skaicus * 0.15}, Alga i rankas: {skaicus - (skaicus * 0.15)}");
            else if (skaicus >= 3000 && skaicus < 10000)
                Console.WriteLine($"Mokesciai: {skaicus * 0.2}, Alga i rankas: {skaicus - (skaicus * 0.2)}");
            else if (skaicus >= 10000)
                Console.WriteLine($"Mokesciai: {skaicus * 0.22}, Alga i rankas: {skaicus - (skaicus * 0.22)}");
            else
                Console.WriteLine("Ivestas neigiamas skaicius");

        }
    }
}
