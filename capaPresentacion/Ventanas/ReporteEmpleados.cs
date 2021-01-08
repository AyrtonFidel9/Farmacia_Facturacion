using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using capaNegocio;
using capaEntidad;

namespace capaPresentacion.Ventanas
{
    public partial class ReporteEmpleados : Form
    {
        public ReporteEmpleados()
        {
            InitializeComponent();        }

        private void ReporteEmpleados_Load(object sender, EventArgs e)
        {
            N_ReporteEmpleado empleado = new N_ReporteEmpleado();
            List<E_Empleado> empleados = new List<E_Empleado>();

            //MessageBox.Show(empleado.reporteEmpleados().Rows.Count.ToString());
            foreach (DataRow item in empleado.reporteEmpleados().Rows)
            {
                empleados.Add(
                    new E_Empleado
                    {
                        idEmpleado = item[0].ToString(),
                        Cedula = item[4].ToString(),
                        Nombre = item[2].ToString(),
                        Apellido = item[3].ToString()
                    });
            }

            this.reportViewer1.LocalReport.ReportEmbeddedResource = "capaPresentacion.Reportes.repEmpleados.rdlc";
            ReportDataSource rds1 = new ReportDataSource("DataSet1", empleados);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds1);
            this.reportViewer1.RefreshReport();
        }
    }
}
