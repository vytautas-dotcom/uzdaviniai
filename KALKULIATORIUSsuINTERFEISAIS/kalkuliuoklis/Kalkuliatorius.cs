using System;
using System.Collections.Generic;
using System.Text;

namespace kalkuliuoklis
{
    class Kalkuliatorius
    {
        public IPaprastasVeiksmas KVeiksmas { get; set; }

        public void DarykVeiksma(int a, int b)
        {
            KVeiksmas.Veiksmas(a, b);
        }
    }
}
