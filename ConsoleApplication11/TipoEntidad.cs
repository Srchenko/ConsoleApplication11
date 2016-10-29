using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11
{
    abstract class TipoEntidad
    {
        protected string nombre;

        public abstract TipoEntidad crear();

    }
}
