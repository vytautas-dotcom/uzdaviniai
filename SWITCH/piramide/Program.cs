using System;

namespace piramide
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                int height;
                try
                {
                    Console.WriteLine("Iveskite norima trikampio auksti: ");
                    height = int.Parse(Console.ReadLine());

                    Console.WriteLine();

                    Console.WriteLine($"Jus ivedete toki skaiciu: {height}");

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

                    // Pilnas trikampis
                    for (int i = 0; i < height; i++)
                    {
                        for (int j = height - 1; j > i; j--)
                        {
                            Console.Write("-");
                        }
                        for (int j = 0; j <= 2 * i; j++)
                        {
                            if (j % 2 != 0)
                            {
                                Console.Write("-");
                            }
                            else if (j % 2 == 0)
                            {
                                Console.Write("*");
                            }
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                }
                catch (Exception)
                {
                    Console.WriteLine("Jusu ivesta reiksme ne skaicius. Prasome ivesti skaiciu.");
                    Console.ReadLine();
                    continue;
                }
                Console.ReadKey();
            }
        }
    }
}