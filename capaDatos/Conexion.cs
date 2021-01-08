using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace capaDatos
{
    public class Conexion
    {
        public SqlConnection cn =
            new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconex"].ConnectionString);

        public void conectar ()
        {
            cn.Open();
        }

        public void cerrar ()
        {
            cn.Close();
        }
    }
}
