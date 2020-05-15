using System;

namespace pirmas
{
    class Program
    {
        static void Main(string[] args)
        {            
            Tikrink();

            Console.ReadKey();
        }
        static void Tikrink()
        {
            Console.Title = "Switch Color";
            Console.WriteLine("Iveskite savo varda");
            string vardas = Console.ReadLine();
            Console.WriteLine("Pasirinkite spalva: 1. Red 2. Green 3. Blue");
            
            //            Console.ForegroundColor = ConsoleColor.DarkGray;
            //            Console.BackgroundColor = ConsoleColor.Yellow;
            //            const string raudona = @"
            //***********************************
            //*                                 *
            //*     1. Raudona                  *
            //*                                 *
            //***********************************
            //";
            //            Console.WriteLine(raudona);

            //            Console.ForegroundColor = ConsoleColor.DarkGray;
            //            Console.BackgroundColor = ConsoleColor.Green;
            //            const string zalia = @"
            //***********************************
            //*                                 *
            //*     2. Zalia                    *
            //*                                 *
            //***********************************
            //";
            //            Console.WriteLine(zalia);


            //            Console.ForegroundColor = ConsoleColor.DarkGray;
            //            Console.BackgroundColor = ConsoleColor.Blue;
            //            const string melyna = @"
            //***********************************
            //*                                 *
            //*     3. Melyna                   *
            //*                                 *
            //***********************************
            //";
            //            Console.WriteLine(melyna);
            //            Console.ResetColor();

            ConsoleKey consoleKey = Console.ReadKey().Key;
            Console.WriteLine();

            switch (consoleKey)
            {
                case ConsoleKey.D1:
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine(vardas);
                    Console.ResetColor();
                    break;
                case ConsoleKey.D2:
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine(vardas);
                    Console.ResetColor();
                    break;
                case ConsoleKey.D3:
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.WriteLine(vardas);
                    Console.ResetColor();
                    break;
                default:
                    Console.WriteLine("Jusu pasirinktos funkcijos nera.");
                    break;
            }                  
        }        
    }
}
