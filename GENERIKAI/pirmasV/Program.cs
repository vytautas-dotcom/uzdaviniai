using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace pirmasV
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Swap iskvietimas
            //char x = '2';
            //char y = '3';

            //Console.WriteLine($"Pries Swap\nx: {x}\ny: {y}");
            //Swap(ref x, ref y);
            //Console.WriteLine($"Po Swap\nx: {x}\ny: {y}");
            #endregion

            //Skaiciai<int>();





            Console.ReadLine();
        }
        #region Paprastas Swap
        //static void Swap(ref int x, ref int y)
        //{
        //    x -= y;
        //    y += x;
        //    x = y - x;
        //}
        #endregion
        #region Generik tipo Swap
        //static void Swap<T>(ref T x, ref T y)
        //{
        //    T temp = x;
        //    x = y;
        //    y = temp; 
        //}
        #endregion
        #region Listas su suma ir vidurkiu
        //static void Skaiciai<T>()
        //{
        //    int count = 0;
        //    List<int> listas = new List<int>();
        //    while (true)
        //    {
        //        Console.WriteLine("Veskite skaiciu");
        //        string value = Console.ReadLine();
        //        if (!Int32.TryParse(value, out int value1))
        //        {
        //            break;
        //        }
        //        listas.Add(value1);
        //        count++;
        //    }
        //    int suma = 0;
        //    foreach (var item in listas)
        //    {
        //        suma += item;
        //    }

        //    Console.WriteLine($"Suma: {suma}, Vidurkis: {(double)suma/count}");
        //}
        #endregion
    }
}
