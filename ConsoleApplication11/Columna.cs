using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11
{
    class Columna: Atributo
    {
        public override TipoEntidad crear()
        {
            return this;
        }
    }
}
