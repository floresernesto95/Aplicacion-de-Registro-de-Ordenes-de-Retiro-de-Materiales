using Solucion___Practica.Datos;
using Solucion___Practica.Dominio;

namespace Solucion___Practica.Servicios
{
    internal class Servicio : IServicio
    {
        private IDao dao;

        public Servicio()
        {
            dao = new Dao();
        }

        public List<Material> GetMateriales(List<Parameter> lPs)
        {
            return dao.GetMateriales(lPs);
        }

        public bool Save(OrdenRetiro ordenRetiro)
        {
            return dao.Save(ordenRetiro);
        }
    }
}