using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pirmasV
{
    class Ekranas
    {
        public int a;
        public int RodykEkrana()
        {
            ConsoleKeyInfo status;

            while (true)
            {
                Aparatas aparatas = new Aparatas();

                Console.WriteLine("1. Užsisakyti kavą");
                Console.WriteLine("2. Valyti");
                Console.WriteLine("3. Papildyti produktus");
                Console.WriteLine("4. Rodyti aparato informaciją");
                Console.WriteLine("5. Baigti programą");

                ConsoleKey consoleKey = Console.ReadKey().Key;
                Console.WriteLine();

                switch (consoleKey)
                {
                    case ConsoleKey.D1:
                        Console.Clear();
                        Console.WriteLine("Pasirinkote: 1. Užsisakyti kavą");
                        return a = 1;

                    case ConsoleKey.D2:
                        Console.Clear();
                        Console.WriteLine("Pasirinkote: 2. Valyti");
                        return a = 2;

                    case ConsoleKey.D3:
                        Console.Clear();
                        Console.WriteLine("Pasirinkote: 3. Papildyti produktus");
                        return a = 3;

                    case ConsoleKey.D4:
                        Console.Clear();
                        Console.WriteLine("Pasirinkote: 4. Rodyti aparato informaciją");
                        return a = 4;

                    case ConsoleKey.D5:
                        Console.Clear();
                        Console.WriteLine("Pasirinkote: 5. Baigti programą");
                        return a = 5;

                    case ConsoleKey.NumPad1:
                        Console.Clear();
                        Console.WriteLine("Pasirinkote: 1. Užsisakyti kavą");
                        return a = 1;

                    case ConsoleKey.NumPad2:
                        Console.Clear();
                        Console.WriteLine("Pasirinkote: 2. Valyti");
                        return a = 2;

                    case ConsoleKey.NumPad3:
                        Console.Clear();
                        Console.WriteLine("Pasirinkote: 3. Papildyti produktus");
                        return a = 3;

                    case ConsoleKey.NumPad4:
                        Console.Clear();
                        Console.WriteLine("Pasirinkote: 4. Rodyti aparato informaciją");
                        return a = 4;

                    case ConsoleKey.NumPad5:
                        Console.Clear();
                        Console.WriteLine("Pasirinkote: 5. Baigti programą");
                        return a = 5;
                    default:
                        Console.WriteLine("Jusu pasirinktos funkcijos nera.");
                        break;
                }

                Console.WriteLine("\n\n Baigti: (Y/y). Testi: (N/n)");
                status = Console.ReadKey();
                if (status.Key == ConsoleKey.Y)
                {
                    break;
                }
                else if (status.Key == ConsoleKey.N)
                    continue;
            }
            return 0;
        }
    }
}
