using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace capaDatos
{
    public class D_ReporteClientes: Conexion
    {
        public D_ReporteClientes() { }

        public DataTable reporteClientes()
        {
            DataTable tabla = new DataTable();
            conectar(); // se conecta a la base de datos
            string consulta = "SELECT * FROM dbo.reporteGeneralClientes";
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(consulta, cn);
                adapter.Fill(tabla);
            }
            catch
            {
                return null;
            }
            cerrar(); //se desconecta de la base de datos
            return tabla;
        }
    }
}
