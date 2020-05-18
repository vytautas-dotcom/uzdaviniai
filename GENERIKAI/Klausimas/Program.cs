using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klausimas
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Viktorina
            //Viktorina viktorina = new Viktorina();
            //viktorina.Testas();
            #endregion

            #region Menesiai
            //Menesiai menesiai = new Menesiai();
            //menesiai.Rasti();
            #endregion


            Person person = new Person() { Vardas = "Tom", Pavarde = "Mot" };
            Person person1 = new Person() { Vardas = "Bob", Pavarde = "Bbo" };

            Knyga knyga = new Knyga();
            knyga.Irasas();
            //knyga.Paieska();
            knyga.Trynimas();



            Console.ReadKey();

        }
    }
}
