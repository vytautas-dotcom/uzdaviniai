using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace pirmasV
{
    class Aparatas
    {
        public int pienas = 500;
        public int vanduo = 2000;
        public int pupeles = 1000;

        public int count = 0;
        public int pasirinkimas;

        public void Uzsakyti()
        {
            JuodaKava juodaKava = new JuodaKava();
            Latte latte = new Latte();
            Espresso espresso = new Espresso();
            if (count == 10)
                Console.WriteLine("Reikia valyti aparata");
            else
            {
                Console.WriteLine("Pasirinkite kava:\n\n" +
                    "1. Juoda kava\n" +
                    "2. Latte\n" +
                    "3. Espresso");
                pasirinkimas = Convert.ToInt32(Console.ReadLine());
                if(pasirinkimas == 1)
                {
                    pienas += juodaKava.pienasJk;
                    vanduo += juodaKava.vanduoJk;
                    pupeles += juodaKava.pupelesJk;
                    count++;
                }
                else if(pasirinkimas == 2)
                {
                    pienas += latte.pienasLa;
                    vanduo += latte.vanduoLa;
                    pupeles += latte.pupelesLa;
                    count++;
                }
                else if(pasirinkimas == 3)
                {
                    pienas += espresso.pienasEs;
                    vanduo += espresso.vanduoEs;
                    pupeles += espresso.pupelesEs;
                    count++;
                }
            }
        }

        public void Valyti()
        {
            Console.WriteLine($"Aparatas valomas, dar buvo {10 - count} kartai iki valymo");
            count = 0;
        }

        public void Pildyti()
        {
            Console.WriteLine($"Pieno like: {pienas}\n" +
                $"Vandens like: {vanduo}\n" +
                $"Pupeliu like: {pupeles}");
            if (pienas < 150 || vanduo < 500 || pupeles < 90)
            {

            Console.WriteLine("Pilkite piena");
            int pienoPildymas = Convert.ToInt32(Console.ReadLine());
            if (pienoPildymas > (500 - pienas))
            {
                Console.WriteLine($"Pilate per daug pieno. Is viso truksta {500 - pienas}");
            }
            else
                pienas += pienoPildymas;

            Console.WriteLine("Pilkite vandeni");
            int vandensPildymas = Convert.ToInt32(Console.ReadLine());
            if (vandensPildymas > (2000 - vanduo))
            {
                Console.WriteLine($"Pilate per daug pieno. Is viso truksta {2000 - vanduo}");
            }
            else
                vanduo += vandensPildymas;

            Console.WriteLine("Pilkite pupeles");
            int pupeliuPildymas = Convert.ToInt32(Console.ReadLine());
            if (pupeliuPildymas > (1000 - pupeles))
            {
                Console.WriteLine($"Pilate per daug pieno. Is viso truksta {1000 - pupeles}");
            }
            else
                pupeles += pupeliuPildymas;
  
            }
            else
                Console.WriteLine("Dar galima pasidaryti bent po puodeli visu kovos rusiu! :)");
        }
        public void Statusas()
        {
            Console.WriteLine($"Pieno like: {pienas}\n" +
                $"Vandens like: {vanduo}\n" +
                $"Pupeliu like: {pupeles}");

            Console.WriteLine($"Is viso padaryta {count} puodeliu po paskutinio valymo");
            Console.WriteLine($"Dar like {10 - count} kartai iki valymo");
        }
    }
}
