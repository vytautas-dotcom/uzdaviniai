using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ketvirtasV
{
    enum Spalvos
    {
        red = 1,
        green,
        blue
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Spek spalva");
            string spalva = Console.ReadLine();

            foreach (string colorName in Enum.GetNames(typeof(Spalvos)))
            {

                if(colorName == spalva)
                {
                    spekSpalvele((int)Enum.Parse(typeof(Spalvos), colorName));
                }
            }

            Console.ReadKey();

        }
        static void spekSpalvele(int sk)
        {

            switch (sk)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Pasiseke tai pasiseke");
                    Console.ResetColor();
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Atspejai");
                    Console.ResetColor();
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Atspejai");
                    Console.ResetColor();
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Ech..");
                    Console.ResetColor();
                    break;
            }
        }
    }
}
