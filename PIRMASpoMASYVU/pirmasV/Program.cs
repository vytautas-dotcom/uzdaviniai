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
            #region PirmasAntras
            //Person person = new Person()
            //{
            //    Vardas = "Jonas",
            //    Pavarde = "Petraitis",
            //    Data = new DateTime(1995, 02, 01)
            //};

            ////person.getData();
            //Console.WriteLine(person.ToString()); 

            #endregion

            #region Kalkuliatoriu
            //Kalkuliatorius kalkuliatorius = new Kalkuliatorius()
            //{
            //    a = 5,
            //    b = 2
            //};

            //Kalkuliatorius.Sudek(kalkuliatorius.a, kalkuliatorius.b);
            //Kalkuliatorius.Atimk(kalkuliatorius.a, kalkuliatorius.b);
            //Kalkuliatorius.Daugink(kalkuliatorius.a, kalkuliatorius.b);
            //Kalkuliatorius.Dalink(kalkuliatorius.a, kalkuliatorius.b);
            #endregion

            #region KalkuliatoriusIsKitoProjekto
            //projektasKalkuliatoriausKlasesIskelimui.Kalkuliatorius1 kalkuliatorius1 = new projektasKalkuliatoriausKlasesIskelimui.Kalkuliatorius1()
            //{
            //    a = 12,
            //    b = 6
            //};

            //projektasKalkuliatoriausKlasesIskelimui.Kalkuliatorius1.Sudek(kalkuliatorius1.a, kalkuliatorius1.b);
            //projektasKalkuliatoriausKlasesIskelimui.Kalkuliatorius1.Atimk(kalkuliatorius1.a, kalkuliatorius1.b);
            //projektasKalkuliatoriausKlasesIskelimui.Kalkuliatorius1.Daugink(kalkuliatorius1.a, kalkuliatorius1.b);
            //projektasKalkuliatoriausKlasesIskelimui.Kalkuliatorius1.Dalink(kalkuliatorius1.a, kalkuliatorius1.b);
            #endregion

            #region Koordinates spausdinimas
            //Koordinates koordinates = new Koordinates()
            //{
            //    koordX = 1,
            //    koordY = 2,
            //    Spalva = "green"
            //};

            //Console.WriteLine($"{koordinates.Spalva} - ({koordinates.koordX}, {koordinates.koordY})");
            #endregion

            #region Inicializavimas tusciam konstruktoriuj
            //Koordinates koordinates = new Koordinates();
            //Console.WriteLine($"{koordinates.Spalva} - ({koordinates.koordX}, {koordinates.koordY})");
            #endregion

            #region Metodo kvietimas atstumo skaiciavimui
            //Koordinates koordinates = new Koordinates();
            //koordinates.Atstumas();
            #endregion

            #region Ketvirtis, bet reikia teisingai sudeti this tarp konstruktoriu, dabar ima pagal nutylejima is tuscio
            //Koordinates koordinates = new Koordinates(-2, -1);
            //koordinates.Ketvirtis();
            #endregion

            #region Figuru skaiciavimas
            //Figura figura = new Figura()
            //{
            //    Pavadinimas = "kvadratas",
            //    Spalva = "melynas"
            //};
            //Figura figura1 = new Figura()
            //{
            //    Pavadinimas = "trikampis",
            //    Spalva = "zalias"
            //};
            //figura.getFiguruSkaicu();
            //figura1.getFiguruSkaicu();
            #endregion

            #region Apskritimo plotas perimetras
            //Circle circle = new Circle(10);
            //circle.Plotas();
            //circle.Perimetras();
            #endregion

            #region Cilindras
            //Cylinder cylinder = new Cylinder(2, 10);
            //cylinder.pagrinduPlotas();
            //cylinder.soninisPlotas();
            //cylinder.visasPlotas();
            //cylinder.Perimetras();
            //cylinder.Turis();
            #endregion

            #region Kvadratas
            //Square square = new Square(5);
            //square.Perimetras();
            //square.Plotas();
            #endregion

            #region Kubas
            //Cube cube = new Cube(3);
            //cube.Plotas();
            //cube.Turis();
            #endregion

            Console.ReadKey();
        }


    }
   
}

