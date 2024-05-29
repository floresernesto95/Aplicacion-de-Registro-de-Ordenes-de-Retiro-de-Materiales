using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion___Practica.Servicios
{
    internal class FactoryServiceImp : FactoryService
    {
        public override IServicio GetServicio()
        {
            return new Servicio();
        }
    }
}
