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

            Menesiai menesiai = new Menesiai();
            menesiai.Rasti();

            Console.ReadKey();

        }
    }
}
