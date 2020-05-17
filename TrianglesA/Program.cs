using System;

namespace TrianglesA
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

                    // 1. Didejantis trikampis
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

                    // 2. Didejantis trikampis su skaiciais

                    for (int i = 0; i < height; i++)
                    {
                        for (int j = 0; j <= i; j++)
                        {
                            Console.Write(j + 1);
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();

                    // 3. Didejantis trikampis su skaiciais

                    for (int i = 0; i < height; i++)
                    {
                        for (int j = 0; j <= i; j++)
                        {
                            Console.Write(i + 1);
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();

                    // 4. Didejantis trikampis su skaiciais ir tarpais
                    int skaicius = 1;
                    for (int i = 1; i <= height; i++)
                    {
                        for (int j = 1; j < i + 1; j++)
                        {
                            Console.Write($"{skaicius} ");
                            skaicius++;
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();

                    // 5. Pilnas trikampis su tarpais
                    for (int i = 0; i < height; i++)
                    {
                        for (int j = height - 1; j > i; j--)
                        {
                            Console.Write(" ");
                        }
                        for (int j = 0; j <= 2 * i; j++)
                        {
                            if (j % 2 != 0)
                            {
                                Console.Write(" ");
                            }
                            else if (j % 2 == 0)
                            {
                                Console.Write("*");
                            }
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();

                    // 6A. Pilnas trikampis su skaiciais ir tarpais
                    int sk = 1;
                    for (int i = 0; i < height; i++)
                    {
                        for (int j = height - 1; j > i; j--)
                        {
                            Console.Write(" ");
                        }
                        for (int j = 0; j <= 2 * i; j++)
                        {
                            if (j % 2 != 0)
                            {
                                Console.Write(" ");
                            }
                            else if (j % 2 == 0)
                            {
                                Console.Write($"{sk}");
                                sk++;
                            }
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();

                    // 6B. Pilnas trikampis su skaiciais ir tarpais
                    int number = 1;
                    for (int i = 0; i < height; i++)
                    {
                        for (int j = 0; j < height - i; j++)
                        {
                            Console.Write(" ");
                        }
                        for (int k = 0; k <= 2 * i; k++)
                        {
                            if (k % 2 != 0)
                            {
                                Console.Write(" ");
                            }
                            else if (k % 2 == 0)
                            {
                                Console.Write($"{number}");
                                number++;
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