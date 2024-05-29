namespace Solucion___Practica.Dominio
{
    public class DetalleOrden
    {
        public Material Material { get; set; }
        public int Cantidad { get; set; }

        public DetalleOrden(Material material, int cantidad)
        {
            Material = material;
            Cantidad = cantidad;
        }

        public DetalleOrden()
        {
            
        }        
    }
}