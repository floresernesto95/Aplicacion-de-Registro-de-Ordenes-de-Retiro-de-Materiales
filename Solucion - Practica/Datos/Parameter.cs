using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion___Practica.Datos
{
    public class Parameter
    {
        public string Nombre { get; set; }
        public object Valor { get; set; }
        
        public Parameter(string nombre, object valor)
        {
            Nombre = nombre;
            Valor = valor;
        }
    }
}
