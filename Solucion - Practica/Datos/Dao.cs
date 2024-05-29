using Solucion___Practica.Dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion___Practica.Datos
{
    internal class Dao : IDao
    {
        public List<Material> GetMateriales(List<Parameter> lPs)
        {
            DataTable dt = HelperDao.GetInstance().GetTable("SP_CONSULTAR_MATERIALES", lPs);
            List<Material> lMs = new List<Material>();

            foreach (DataRow r in dt.Rows)
            {
                Material m = new Material();
                m.Codigo = Convert.ToInt32(r["codigo"].ToString());
                m.Nombre = r["nombre"].ToString();
                m.Stock = Convert.ToDouble(r["stock"].ToString());
                lMs.Add(m);
            }

            return lMs;
        }

        public bool Save(OrdenRetiro ordenRetiro)
        {
            SqlConnection cnn = HelperDao.GetInstance().GetCnn();
            SqlTransaction txn = null;
            bool rst = true;

            try
            {
                cnn.Open();
                txn = cnn.BeginTransaction();
                SqlCommand cmd1 = new SqlCommand("SP_INSERTAR_ORDEN", cnn, txn);
                cmd1.CommandType = CommandType.StoredProcedure;
                cmd1.Parameters.AddWithValue("@responsable", ordenRetiro.Responsable);

                SqlParameter p = new SqlParameter("@nro", SqlDbType.Int);
                p.Direction = ParameterDirection.Output;
                cmd1.Parameters.Add(p);

                cmd1.ExecuteNonQuery();
                int nro = (int)p.Value;
                int nroDet = 0;

                foreach (DetalleOrden d in ordenRetiro.lDetalles)
                {
                    SqlCommand cmd2 = new SqlCommand("SP_INSERTAR_DETALLES", cnn, txn);
                    cmd2.CommandType = CommandType.StoredProcedure;

                    cmd2.Parameters.AddWithValue("@nro_orden", nro);
                    cmd2.Parameters.AddWithValue("@detalle", ++nroDet);
                    cmd2.Parameters.AddWithValue("@codigo", d.Material.Codigo);
                    cmd2.Parameters.AddWithValue("@cantidad", d.Cantidad);

                    cmd2.ExecuteNonQuery();
                }

                txn.Commit();
            }

            catch
            {
                txn.Rollback();
                rst = false;
            }

            finally
            {
                cnn.Close();
            }

            return rst;
        }
    }
}
