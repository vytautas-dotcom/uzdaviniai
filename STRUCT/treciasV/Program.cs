using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace treciasV
{
    struct Studentas
    {
        static int count = 0;
        string[] Vardas;
        string[] Pavarde;
        int[] Pazymys;

        string vardas;
        string pavarde;
        int pazymys;
        

        public void setStudentas(string vardas, string pavarde, int pazymys)
        {
            this.vardas = vardas;
            this.pavarde = pavarde;
            this.pazymys = pazymys;

            saveStudentas(vardas, pavarde, pazymys, count);
            count++;
        }
        public void saveStudentas(string a, string b, int c, int d)
        {
            this.Vardas[d] = a;
            this.Pavarde[d] = b;
            this.Pazymys[d] = c;
        }
        public void getStudentas(int studentoNr)
        {
            Console.WriteLine($"Vardas: {Vardas[studentoNr]}, Pavarde: {Pavarde[studentoNr]}, Pazymys: {Pazymys[studentoNr]}");  
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Studentas studentas = new Studentas();
            studentas.setStudentas("Jonas", "Jonaitis", 10);
            studentas.setStudentas("Petras", "Petraitis", 10);
            studentas.setStudentas("Antanas", "Antanaitis", 10);

            studentas.getStudentas(3);

            Console.ReadKey();

        }
    }
}
