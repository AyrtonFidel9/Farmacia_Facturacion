using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using capaEntidad;
using capaDatos;

namespace capaNegocio
{
    public class N_ReporteClientes
    {
        D_ReporteClientes clientes;
        public N_ReporteClientes() 
        {
            clientes = new D_ReporteClientes();
        }

        public DataTable reporteClientes ()
        {
            return clientes.reporteClientes();
        }
    }
}
