using System;
using System.Collections.Generic;
using System.Text;

namespace zviriuskos
{
    class Vilkas : Zverelis
    {
        public override void Konkuruoja()
        {
            throw new NotImplementedException("Zymi teritorija");
        }

        public override void Saugosi()
        {
            Console.WriteLine("Slepiasi krumuose");
        }
    }
}
