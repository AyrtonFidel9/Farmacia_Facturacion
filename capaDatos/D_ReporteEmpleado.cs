using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace capaDatos
{
    public class D_ReporteEmpleado: Conexion
    {
        public D_ReporteEmpleado ()
        {
            
        }

        public DataTable reporteEmpleados()
        {
            DataTable tablita = new DataTable();
            conectar(); // se conecta a la base de datos
            string consulta = "SELECT * FROM dbo.reporteGeneralEmpleados";
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(consulta, cn);
                adapter.Fill(tablita);
            }
            catch
            {
                return null;
            }
            cerrar(); //se desconecta de la base de datos
            return tablita;
        }
    }
}
