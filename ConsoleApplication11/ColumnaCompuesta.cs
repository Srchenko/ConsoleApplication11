using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11
{
    class ColumnaCompuesta: Atributo
    {
        TipoEntidad[] vector = new TipoEntidad[10];
        int cont = 0;

        public ColumnaCompuesta()
        {
            
        }
        public override TipoEntidad crear()
        {
            if (cont < 10)
            {
                vector[cont] = new Columna();
                cont++;
            }
                
            return vector[cont];
        }
    }
}
