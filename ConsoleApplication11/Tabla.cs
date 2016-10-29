using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11
{
    class Tabla: TipoEntidad
    {
        
        Tabla() { }
        public override TipoEntidad crear()
        {
            return this;
        }
    }
}
