using System;
using System.Collections.Generic;
using System.Text;

namespace kalkuliuoklis
{
    class Dalink : IPaprastasVeiksmas
    {
        public void Veiksmas(int a, int b)
        {
            Console.WriteLine(a / b);
        }
    }
}
