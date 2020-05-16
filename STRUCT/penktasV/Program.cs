using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace penktasV
{
    class Program
    {
        enum savaitesDienos
        {
            pirmadieni = 1,
            antradieni,
            treciadieni,
            ketvirtadieni,
            penktadieni,
            sestadieni,
            sekmadieni
        }
        struct Vartotojas
        {
            public string Vardas;
            public GimimoData Date;
        }
        struct GimimoData
        {
            public int Day;
            public int Month;
            public int Year;
        }
        static void Main(string[] args)
        {
            int dd = 0, mm = 0, yy = 0;
            Console.Write("\n\nIveskite savo varda ir gimimo data :\n");
            Console.Write("-------------------------------------------------------\n");
            Vartotojas vart = new Vartotojas();


                Console.Write("Vardas : ");
                string vard = Console.ReadLine();
                vart.Vardas = vard;

                Console.Write("Gimimo diena : ");
                dd = Convert.ToInt32(Console.ReadLine());
                vart.Date.Day = dd;

                Console.Write("Menuo : ");
                mm = Convert.ToInt32(Console.ReadLine());
                vart.Date.Month = mm;

                Console.Write("Metai : ");
                yy = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                vart.Date.Year = yy;

            string gimimoData = $"{vart.Date.Day}/{vart.Date.Month}/{vart.Date.Year}";

            DateTime oDate = Convert.ToDateTime(gimimoData);

            
            Console.WriteLine($"{vart.Vardas}, jusu gimtadienis buvo {Enum.GetName(typeof(savaitesDienos), (int)oDate.DayOfWeek)}");

            Console.ReadKey();

        }
    }
}
