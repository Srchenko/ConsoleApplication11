using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11
{
    class BaseDeDatos : AbstractRepositorio
    {
        string nombre;
        static string llave;

        void setNombre(string nombre)
        {
            this.nombre = nombre;
        }

        string getNombre()
        {
            return this.nombre;
        }

        override public bool add(Object objeto)
        {
            return false;
        }

        override public bool remove(Object objeto)
        {
            return false;
        }

        BaseDeDatos() { }
    }
}
