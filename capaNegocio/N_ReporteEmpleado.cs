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
    public class N_ReporteEmpleado
    {
        D_ReporteEmpleado empleado;
        public N_ReporteEmpleado ()
        {
            empleado = new D_ReporteEmpleado();
        }

        public DataTable reporteEmpleados ()
        {
            return empleado.reporteEmpleados();
        }
        
    }
}
