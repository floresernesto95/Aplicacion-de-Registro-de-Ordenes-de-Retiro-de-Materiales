using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion___Practica.Servicios
{
    internal abstract class FactoryService
    {
        public abstract IServicio GetServicio();
    }
}
