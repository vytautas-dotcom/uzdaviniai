using System;
using System.Collections.Generic;
using System.Text;

namespace zviriuskos
{
    abstract class Zverelis : IGyvunas
    {
        public virtual void Eda()
        {

        }

        public abstract void Konkuruoja();

        public abstract void Saugosi();
    }
}
