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
            getName(setName());

            Console.ReadKey();
        }
        static string setName()
        {
            Console.WriteLine("Iveskite savo varda");
            string name = Console.ReadLine();
            return name;
        }
        static void getName(string name)
        {
            Console.WriteLine("Jusu vardas:");
            Console.WriteLine(name);
        }
    }
}
