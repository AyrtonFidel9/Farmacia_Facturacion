using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaEntidad;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace capaDatos
{
    public class D_Empleado: Conexion
    {
        public DataTable D_listado ()
        {
            SqlCommand cmd = new SqlCommand("****", cn); //Aqui los Procedimientos almacenados
            //cmd.CommandText
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cn.Close(); // Cierro conexion con la BD
            return dt;
        }
    }
}
