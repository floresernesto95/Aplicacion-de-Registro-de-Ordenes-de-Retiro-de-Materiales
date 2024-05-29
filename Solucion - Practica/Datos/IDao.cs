using Solucion___Practica.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion___Practica.Datos
{
    internal interface IDao
    {
        List<Material> GetMateriales(List<Parameter> lPs);
        bool Save(OrdenRetiro ordenRetiro);
    }
}
