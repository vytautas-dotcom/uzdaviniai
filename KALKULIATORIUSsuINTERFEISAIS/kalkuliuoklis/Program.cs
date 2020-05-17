using System;

namespace kalkuliuoklis
{
    class Program
    {
        static void Main(string[] args)
        {
            Kalkuliatorius kalkuliatorius = new Kalkuliatorius();

            kalkuliatorius.KVeiksmas = new Sudek();
            kalkuliatorius.DarykVeiksma(6, 4);
            kalkuliatorius.KVeiksmas = new Atimk();
            kalkuliatorius.DarykVeiksma(6, 4);
            kalkuliatorius.KVeiksmas = new Daugink();
            kalkuliatorius.DarykVeiksma(6, 4);
            kalkuliatorius.KVeiksmas = new Dalink();
            kalkuliatorius.DarykVeiksma(6, 4);
        }
    }
}
