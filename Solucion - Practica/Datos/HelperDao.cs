using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion___Practica.Datos
{
    internal class HelperDao
    {
        private SqlConnection cnn;
        private static HelperDao instance;

        private HelperDao() 
        {
            cnn = new SqlConnection("Data Source=LAPTOP-NG836ULB\\SQLEXPRESS;Initial Catalog=db_ordenes1;Integrated Security=True");
        }

        public static HelperDao GetInstance() 
        {
            if (instance == null)
                instance = new HelperDao();
            return instance;
        }

        public SqlConnection GetCnn()
        {
            return cnn;
        }

        public DataTable GetTable(string sp, List<Parameter> lPs)
        {
            cnn.Open();
            SqlCommand cmd = new SqlCommand(sp, cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Clear();

            foreach (Parameter p in lPs)
            {
                cmd.Parameters.AddWithValue(p.Nombre, p.Valor);
            }

            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            cnn.Close();
            return dt;
        }
    }
}
