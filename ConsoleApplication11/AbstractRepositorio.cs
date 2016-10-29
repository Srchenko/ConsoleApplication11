using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11
{
    abstract class AbstractRepositorio : Object, Collection
    {
        public abstract bool add(Object objeto);
        public abstract bool remove(Object objeto);
    }
}
