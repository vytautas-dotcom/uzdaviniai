using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pirmasV
{
    class Developer : Employee
    {
        public string vardas;
        public string pavarde;
        public int id;
        public Developer(string vardas, string pavarde, int id) : base(vardas, pavarde, id) { }
        public override void DoWork()
        {
            Manager manager = new Manager("Jonas", "Petraitis", 2);
            Console.WriteLine($"Skirtingai nuo {manager.vardas}, {vardas} plusa labai daug");
        }
    }
}
