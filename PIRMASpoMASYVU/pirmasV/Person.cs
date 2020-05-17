using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pirmasV
{
    class Person
    {
        public string Vardas { get; set; }
        public string Pavarde { get; set; }
        public DateTime Data { get; set; }
        public int getData()
        {
            DateTime laikasDabar = DateTime.Today;
            int amzius = laikasDabar.Year - Data.Year;
            Console.WriteLine($"Vardas: {Vardas}\nPavarde: {Pavarde}\nGimimo data: {Data}\nAmzius: {amzius} metu");
            return amzius;
        }
        public string ToString()
        {
            return Vardas + " " + Pavarde + ", " + getData();
        }
    }
}
