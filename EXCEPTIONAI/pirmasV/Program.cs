using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pirmasV
{
    class Program
    {
        static void Main(string[] args)
        {
            //Masyvas();

            try
            {
                Login();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Klaida: {e.Message}");
            }

            Console.ReadKey();
        }
        #region Masyvas
        //static void Masyvas()
        //{
        //    try
        //    {
        //        Console.WriteLine("Iveskite masyvo dydi");
        //        int n = Convert.ToInt32(Console.ReadLine());
        //        int[] arr = new int[n];
        //        for (int i = 0; i < arr.Length; i++)
        //        {
        //            Console.WriteLine($"Iveskite masyvo nari nr. {i + 1}");
        //            arr[i] = Convert.ToInt32(Console.ReadLine());
        //        }
        //        Console.WriteLine("Iveskite norimo masyvo nario indeksa");
        //        int m = Convert.ToInt32(Console.ReadLine());
        //        Console.WriteLine($"{m}-asis narys lygus {arr[m - 1]}");
        //    }
        //    catch (OverflowException e)
        //    {
        //        Console.WriteLine($"Netinkamai nurodytas masyvo dydis, uzfiksuota {e.Message} klaida");
        //    }
        //    catch (IndexOutOfRangeException e)
        //    {
        //        Console.WriteLine($"Nurodytas neegzistuojantis masyvo indeksas, uzfiksuota {e.Message} klaida");
        //    }
        //    catch (FormatException e)
        //    {
        //        Console.WriteLine($"Neteisingai įversti duomenys, uzfiksuota {e.Message} klaida");
        //    }
        //}
        #endregion

        static void Login()
        {
            string vardas1 = "aaa";
            int slaptazodis1 = 111;
            
            Console.WriteLine("Iveskite vartotojo varda");
            string vardas = Console.ReadLine();
            Console.WriteLine("Iveskite slaptazodi");
            string slaptazodis = Console.ReadLine();
            int a;
            if (!int.TryParse(slaptazodis, out a))
            {
                throw new Exception($"Slaptazodis turi buti sudarytas tik is skaitmenu");
            }

            if (vardas1 == vardas && slaptazodis1 == a)
            {
                Console.WriteLine("Sveiki prisijuge");
            }
            else
                Console.WriteLine("Neteisingas slaptazodis arba prisijungimo vardas");
        }
    }
}
