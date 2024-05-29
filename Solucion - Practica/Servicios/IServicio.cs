using Solucion___Practica.Datos;
using Solucion___Practica.Dominio;

namespace Solucion___Practica.Servicios
{
    public interface IServicio
    {
        List<Material> GetMateriales(List<Parameter> lPs);
        bool Save(OrdenRetiro ordenRetiro);
    }
}