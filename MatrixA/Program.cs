using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixA
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                double firstValue, secondValue, thirdValue, fourthValue;
                try
                {
                    Console.Write("Iveskite pirma skaiciu: ");
                    firstValue = double.Parse(Console.ReadLine());

                    Console.Write("Iveskite antra skaiciu: ");
                    secondValue = double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Jusu ivesta reiksme ne skaicius. Prasome ivesti skaiciu.");
                    Console.ReadLine();
                    continue;
                }

                Console.WriteLine("Pasirinkite kokia operacija noretumete atlikti su siais skaiciais: 1. Sum (+);   2. Subtraction (-);   3. Divide (x);    4. Multiply (/);    5. Receipt of Balance (%);  6. Average (x/2); 7. Draw");
                ConsoleKey consoleKey = Console.ReadKey().Key;
                Console.WriteLine();

                Console.WriteLine($"Jus ivedete tokius skaicius: Pirmas skaicius = {firstValue}; Antras skaicius = {secondValue}");

                switch (consoleKey)
                {
                    case ConsoleKey.D1:
                        double sumResult = firstValue + secondValue;
                        Console.WriteLine($"Skaiciu sudetis: {sumResult}");
                        break;
                    case ConsoleKey.D2:
                        double subResult = firstValue - secondValue;
                        Console.WriteLine($"Skaiciu atimtis: {subResult}");
                        break;
                    case ConsoleKey.D3:
                        double divResult = firstValue * secondValue;
                        Console.WriteLine($"Skaiciu daugyba: {divResult}");
                        break;
                    case ConsoleKey.D4:
                        if (secondValue == 0)
                        {
                            Console.WriteLine("Dalyba is nulio negalima! Prasome ivesti kita skaiciu.");
                        }
                        else
                        {
                            double multResult = firstValue / secondValue;
                            Console.WriteLine($"Skaiciu dalyba: {multResult}");
                        }
                        break;
                    case ConsoleKey.D5:
                        double robResult = firstValue % secondValue;
                        Console.WriteLine($"Skaiciaus likutis: {robResult}");
                        break;
                    case ConsoleKey.D6:
                        Console.WriteLine("Prasome ivesti dar du skaicius: ");
                        try
                        {
                            Console.Write("Iveskite trecia skaiciu: ");
                            thirdValue = double.Parse(Console.ReadLine());

                            Console.Write("Iveskite ketvirta skaiciu: ");
                            fourthValue = double.Parse(Console.ReadLine());
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Jusu ivesta reiksme ne skaicius. Prasome ivesti skaiciu.");
                            Console.ReadLine();
                            continue;
                        }
                        double avgResult = (firstValue + secondValue + thirdValue + fourthValue) / 2;
                        Console.WriteLine($"Skaiciu vidurkis: {avgResult}");
                        break;
                    case ConsoleKey.NumPad1:
                        double sumResult2 = firstValue + secondValue;
                        Console.WriteLine($"Skaiciu sudetis: {sumResult2}");
                        break;
                    case ConsoleKey.NumPad2:
                        double subResult2 = firstValue - secondValue;
                        Console.WriteLine($"Skaiciu atimtis: {subResult2}");
                        break;
                    case ConsoleKey.NumPad3:
                        double divResult2 = firstValue * secondValue;
                        Console.WriteLine($"Skaiciu daugyba: {divResult2}");
                        break;
                    case ConsoleKey.NumPad4:
                        double multResult2 = firstValue / secondValue;
                        Console.WriteLine($"Skaiciu dalyba: {multResult2}");
                        break;
                    case ConsoleKey.NumPad5:
                        double robResult2 = firstValue % secondValue;
                        Console.WriteLine($"Skaiciaus likutis: {robResult2}");
                        break;
                    case ConsoleKey.NumPad6:
                        Console.WriteLine("Prasome ivesti dar du skaicius: ");
                        try
                        {
                            Console.Write("Iveskite trecia skaiciu: ");
                            thirdValue = double.Parse(Console.ReadLine());

                            Console.Write("Iveskite ketvirta skaiciu: ");
                            fourthValue = double.Parse(Console.ReadLine());
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Jusu ivesta reiksme ne skaicius. Prasome ivesti skaiciu.");
                            Console.ReadLine();
                            continue;
                        }
                        double avgResult2 = (firstValue + secondValue + thirdValue + fourthValue) / 2;
                        Console.WriteLine($"Skaiciu vidurkis: {avgResult2}");
                        break;
                    case ConsoleKey.NumPad7:
                        int height;
                        Console.WriteLine("Iveskite norima trikampio auksti: ");
                        try
                        {
                            height = int.Parse(Console.ReadLine());
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Jusu ivesta reiksme ne skaicius. Prasome ivesti skaiciu.");
                            Console.ReadLine();
                            continue;
                        }
                        // Didejantis trikampis
                        for (int i = 0; i < height; i++)
                        {
                            for (int j = 0; j <= i; j++)
                            {
                                Console.Write("*");
                            }
                            Console.WriteLine();
                        }
                        Console.WriteLine();
                        // Mazejantis trikampis
                        for (int i = 0; i < height; i++)
                        {
                            for (int j = height; j > i; j--)
                            {
                                Console.Write("*");
                            }
                            Console.WriteLine();
                        }
                        Console.WriteLine();
                        // Didejantis atvirksciai su tusciom vietom
                        for (int i = 0; i < height; i++)
                        {
                            for (int j = height - 1; j > i; j--)
                            // Neirasius height-1 bus iterptas tarpas tarp pirmo simbolio ir krasto
                            {
                                Console.Write(" ");
                            }
                            for (int j = 0; j <= i; j++)
                            {
                                Console.Write("*");
                            }
                            Console.WriteLine();
                        }
                        Console.WriteLine();
                        // Mazejantis atvirksciai su tusciom vietom
                        for (int i = 0; i < height; i++)
                        {
                            for (int j = 0; j < i; j++)
                            // Jei irasyti j <= 1 tada iterps tarpa vietoj pirmo simbolio nuo krasto
                            {
                                Console.Write(" ");
                            }
                            for (int j = height; j > i; j--)
                            {
                                Console.Write("*");
                            }
                            Console.WriteLine();
                        }

                        break;
                    default:
                        Console.WriteLine("Jusu pasirinktos funkcijos nera.");
                        break;
                }
                Console.ReadKey();
            }
        }
}
