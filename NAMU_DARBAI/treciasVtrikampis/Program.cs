using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace treciasVtrikampis
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Programa7();

            //Console.WriteLine("Iveskite eile");
            //Programa4(Int32.Parse(Console.ReadLine()));

            //Console.WriteLine("Iveskite skaiciu ir eile");
            //Programa3(Int32.Parse(Console.ReadLine()), Int32.Parse(Console.ReadLine()));

            //Console.WriteLine("Iveskite skaiciu ir eile");
            //Programa5(Int32.Parse(Console.ReadLine()), Int32.Parse(Console.ReadLine()), Int32.Parse(Console.ReadLine()));

            //Console.WriteLine("Iveskite sakini");
            //Programa6(Console.ReadLine());


            Console.ReadKey();
        }
        static void Trikampis1(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < i+1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        static void Trikampis2(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 1; j < i + 2; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
        static void Trikampis3(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j < i + 1; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }
        static void Trikampis4(int n)
        {
            int a = 0;
            int temp = 0;
            for (int i = 1; i <= n; i++)
            {
                if (i == 3) { a = 1; }
                temp += a;

                for (int j = 0; j < i; j++)
                {
                    if (i == 3)
                    {
                        Console.Write($"{j + i + temp-1} ");
                    }
                    else if (i > 3)
                    {
                        Console.Write($"{j + i + temp} ");
                    }
                    else
                    {
                        Console.Write($"{j + i} ");
                    }
                }
                a++;
                Console.WriteLine();
            }
        }
        static void Trikampis5(int n)
        {
            n += 1;
            int a = 1;

            for (int i = 0; i < n; i++)
            {
                if (a != n)
                {
                    for (int j = 0; j < n - a; j++)
                    {
                        Console.Write(" ");
                    }
                }

                for (int k = 0; k < i + a; k++)
                {
                    if (k % 2 != 0)
                    {
                        Console.Write("*");
                    }
                    else if (k % 2 == 0)
                        Console.Write(" ");
                }

                Console.WriteLine();
                a++;
            }
        }
        static void Trikampis6(int n)
        {
            n += 1;
            int a = 1;
            int sk = 1;
            for (int i = 0; i < n; i++)
            {
                if (a != n)
                {
                    for (int j = 0; j < n - a; j++)
                    {
                        Console.Write(" ");
                    }
                }

                for (int k = 0; k < i + a; k++)
                {
                    if (k % 2 != 0)
                    {
                        Console.Write(sk);
                    }
                    else if (k % 2 == 0)
                        Console.Write(" ");

                    sk++;
                }

                Console.WriteLine();
                a++;
              
            }
        }
        static void Programa1(int n)
        {
            
            double suma = 0;
            for (int i = 1; i <= n; i++)
            {
                double sk = 0;
                for (int j = 0; j < i; j++)
                {
                    sk += Math.Pow(10, j);
                }
                suma += sk;
            }
            Console.WriteLine(suma);
        }

        static void Programa2(int n, int m)
        {

            double suma = 0;
            for (int i = 1; i <= n; i++)
            {
                double sk = 0;
                for (int j = 0; j < i; j++)
                {
                    sk += m*Math.Pow(10, j);
                }
                suma += sk;
            }
            Console.WriteLine(suma);
        }

        static void Programa3(int n, int m)
        {

            double suma = 0;
            double pow = 1;
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 != 0)
                    suma += Math.Pow(m, pow);
                else
                    suma -= Math.Pow(m, pow);

                pow += 2;
            }
            Console.WriteLine(suma);
        }
        static void Programa4(int n)
        {
            for (int i = 0; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write($"{i} ");
                }
                
            }
            
        }
        static void Programa5(int sk, int r1, int r2)
        {
            for (int i = r1; i <= r2; i++)
            {
                if (i % sk == 0)
                {
                    Console.Write($"{i} ");
                }
            }
        }

        static void Programa6(string sak)
        {
            char[] arr;
            arr = sak.ToCharArray();

            for (int i = arr.Length-1; i >= 0; i--)
            {
                Console.Write(arr[i]);
            }
        }

        static void Programa7()
        {
            Console.Clear();
            Console.WriteLine("Iveskite skaiciu, kurio daugybos lentele norite gauti");
            
            string a = null;
            while (true)
            {
                int skaicius = Int32.Parse(Console.ReadLine());

                for (int i = 0; i <= 10; i++)
                {
                    Console.WriteLine($"{skaicius} * {i} = {skaicius * i}");
                }
                Console.WriteLine("Ar norite baigti, jei taip iveskite y, jeigu ne tada iveskite n");
                a = Console.ReadLine();
                if (a == "y")
                {
                    break;
                }
                else if (a == "n")
                {
                    continue;
                }
            }
        }
        static void Programa8(int a, int b)
        {

        }
    }
}
