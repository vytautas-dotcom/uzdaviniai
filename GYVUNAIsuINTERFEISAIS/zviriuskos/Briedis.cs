using System;
using System.Collections.Generic;
using System.Text;

namespace zviriuskos
{
    class Briedis : Zverelis
    {
        public override void Konkuruoja()
        {
            Console.WriteLine("Kaunasi su kitais");
        }

        public override void Saugosi()
        {
            Console.WriteLine("Bega");
        }
    }
}
