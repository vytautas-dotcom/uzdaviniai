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
            List<Employee1> list = new List<Employee1>();
            list.Add(new Employee1() { Name = "Steve", Salary = 10000 });
            list.Add(new Employee1() { Name = "Janet", Salary = 10000 });
            list.Add(new Employee1() { Name = "Andrew", Salary = 10000 });
            list.Add(new Employee1() { Name = "Bill", Salary = 500000 });
            list.Add(new Employee1() { Name = "Lucy", Salary = 8000 });

            // Uses IComparable.CompareTo()
            list.Sort();

            // Uses Employee.ToString
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
