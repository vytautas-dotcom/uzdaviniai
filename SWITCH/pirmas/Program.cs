using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pirmas
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
            Console.WriteLine("Iveskite varda ir Spalva (red, green arba blue)");
            string vardas = Console.ReadLine();
            string spalva = Console.ReadLine();

            switch (spalva)
            {
                case "red":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine(vardas);
                    Console.ResetColor();
                    break;
                case "green":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine(vardas);
                    Console.ResetColor();
                    break;
                case "blue":
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.WriteLine(vardas);
                    Console.ResetColor();
                    break;
                default:
                    break;
            }
        }
    }
}
