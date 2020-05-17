using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pirmasV
{
    abstract class Employee
    {
        public string vardas;
        public string pavarde;
        public int id;
        public Employee(string vardas, string pavarde, int id)
        {
            this.vardas = vardas;
            this.pavarde = pavarde;
            this.id = id;
        }
        

        public abstract void DoWork();

        
    }
}
