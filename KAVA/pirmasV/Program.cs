using System;

namespace pirmasV
{
    class Program
    {
        
        private static void Main(string[] args)
        {
            Ekranas ekranas = new Ekranas();
            Aparatas aparatas = new Aparatas();
            int b = ekranas.RodykEkrana();
            if (b == 1)
            {
                aparatas.Uzsakyti();
            }
            else if (b == 2)
            {
                aparatas.Valyti();
                b = ekranas.RodykEkrana();
            }
            else if (b == 3)
            {
                aparatas.Pildyti();
                b = ekranas.RodykEkrana();
            }
            else if (b == 4)
            {
                aparatas.Statusas();
                b = ekranas.RodykEkrana();
            }


            Console.ReadKey();
        }
    }
}
