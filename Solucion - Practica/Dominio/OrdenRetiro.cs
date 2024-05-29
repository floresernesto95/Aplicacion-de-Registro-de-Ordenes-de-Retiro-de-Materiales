using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion___Practica.Dominio
{
    public class OrdenRetiro
    {
        public int NroOrden { get; set; }
        public DateTime Fecha { get; set; }
        public string Responsable { get; set; }
        public List<DetalleOrden> lDetalles { get; set; }

        public OrdenRetiro()
        {
            lDetalles = new List<DetalleOrden>();
        }

        public void AddDetalles(DetalleOrden d)
        {
            lDetalles.Add(d);
        }

        public void RemoveDetalles(int i)
        {
            lDetalles.RemoveAt(i);
        }

    }
}
