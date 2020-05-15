using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pirmasAA
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
            Console.WriteLine("Pasirinkite spalva: ");

            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Yellow;
            const string raudona = @"
***********************************
*                                 *
*     1. Raudona                  *
*                                 *
***********************************
";
            Console.WriteLine(raudona);
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Green;
            const string zalia = @"
***********************************
*                                 *
*     2. Zalia                    *
*                                 *
***********************************
";
            Console.WriteLine(zalia);
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Blue;
            const string melyna = @"
***********************************
*                                 *
*     3. Melyna                   *
*                                 *
***********************************
";
            Console.WriteLine(melyna);
            Console.ResetColor();

            ConsoleKey consoleKey = Console.ReadKey().Key;
            Console.WriteLine();

            switch (consoleKey)
            {
                case ConsoleKey.D1:
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.BackgroundColor = ConsoleColor.Red;                    
                    Console.WriteLine($"   {vardas}   ");
                    Console.ResetColor();
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine($"   {vardas}   ");
                    Console.ResetColor();
                    break;
                case ConsoleKey.D3:
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.BackgroundColor = ConsoleColor.Blue;                    
                    Console.WriteLine($"   {vardas}   ");
                    Console.ResetColor();
                    break;
                case ConsoleKey.NumPad1:
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine($"   {vardas}   ");
                    Console.ResetColor();
                    break;
                case ConsoleKey.NumPad2:
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine($"   {vardas}   ");
                    Console.ResetColor();
                    break;
                case ConsoleKey.NumPad3:
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"   {vardas}   ");
                    Console.ResetColor();
                    break;
                default:
                    Console.WriteLine("Jusu pasirinktos funkcijos nera.");
                    break;
            }
        }
    }
}
