using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pirmasV
{
    class Manager : Employee
    {
        public string vardas;
        public string pavarde;
        public int id;
        public Manager(string vardas, string pavarde, int id) : base(vardas, pavarde, id) { }
        public override void DoWork()
        {
            Console.WriteLine($"Menedzeris {vardas} nieko naudingo neveikia.");
        }
    }
}
