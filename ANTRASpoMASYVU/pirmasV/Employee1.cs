using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pirmasV
{
    class Employee1 : IComparable<Employee1>
    {
        public int Salary { get; set; }
        public string Name { get; set; }

        public int CompareTo(Employee1 e)
        {
            //jei vienodi salary, tai tada pagal varda
            //if (this.Salary == e.Salary)
            //{
                return this.Name.CompareTo(e.Name);
            //}
            //return e.Salary.CompareTo(this.Salary);
        }

        public override string ToString()
        {
            return this.Salary.ToString() + ",\t" + this.Name;
        }
    }
}
