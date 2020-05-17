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

            Programa8();

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
            Console.WriteLine("Iveskite skaiciu, kurio daugybos lentele norite gauti");

            
            while (true)
            {
                string a = null;
                int n = Int32.Parse(Console.ReadLine());
                for (int i = 0; i <= 10; i++)
                {
                    Console.WriteLine($"{n} * {i} = {n * i}");
                }
                Console.WriteLine("Ar norite baigti, jei taip iveskite y, jeigu ne tada iveskite n");
                a = Console.ReadLine();
                if (a == "y")
                {
                    break;
                }
                else if (a == "n")
                    continue;
            }
            
        }
        static void Programa8()
        {
            ConsoleKeyInfo status;

            while (true)
            {
                Console.WriteLine("Iveskite du skaicius ir operacijos zenkla");
                int a = Int32.Parse(Console.ReadLine());
                int b = Int32.Parse(Console.ReadLine());
                string zenklas = Console.ReadLine();

                switch (zenklas)
                {
                    case "+":
                        Console.WriteLine(a + b);
                        break;
                    case "-":
                        Console.WriteLine(a - b);
                        break;
                    case "*":
                        Console.WriteLine(a * b);
                        break;
                    case "/":
                        Console.WriteLine((double)(a / b));
                        break;
                    default:
                        Console.WriteLine("Kazkas ne taip");
                        break;
                }
                Console.WriteLine("\n\n Norite iseiti? Jei taip, spauskite: (Y/y). Jei ne - (N/n)");
                status = Console.ReadKey();
                if (status.Key == ConsoleKey.Y)
                {
                    break;
                }
                //else if (status.Key == ConsoleKey.N)
                //    continue;
                Console.Clear();
            }
            
        }
        static void Ciklas1()
        {
            DateTime now = DateTime.Now;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(now);
            }  
        }
        static void Ciklas2()
        {
            DateTime now = DateTime.Now;
            object[] arr = {now,now,now};

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
        static void Ciklas3()
        {
            DateTime now = DateTime.Now;
            int i = 0;
            while (i != 3)
            {
                Console.WriteLine(now);
                i++;
            }  
        }
        static void Ciklas4()
        {
            DateTime now = DateTime.Now;
            int i = 0;

            do
            {
                Console.WriteLine(now);
                i++;
            } while (i != 3);
        }
    }
}
