using System;
using System.Collections.Generic;
using System.Text;

namespace zviriuskos
{
    class Lape : Zverelis
    {
        public override void Konkuruoja()
        {
            Console.WriteLine("Kanda");
        }

        public override void Saugosi()
        {
            Console.WriteLine("Lenda i ola");
        }
    }
}
