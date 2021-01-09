using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capaNegocio;
using capaEntidad;
using Microsoft.Reporting.WinForms;

namespace capaPresentacion.Ventanas
{
    public partial class ReporteClientes : Form
    {
        N_ReporteClientes clientes;
        public ReporteClientes()
        {
            InitializeComponent();
            clientes = new N_ReporteClientes();
        }

        private void ReporteClientes_Load(object sender, EventArgs e)
        {
            List<E_Cliente> e_Clientes = new List<E_Cliente>();
            if(clientes.reporteClientes() != null)
            {
                try
                {
                    foreach (DataRow item in clientes.reporteClientes().Rows)
                    {
                        e_Clientes.Add(new E_Cliente
                        {
                            Cedula = item[0].ToString(),
                            Nombre = item[1].ToString(),
                            Apellido = item[2].ToString(),
                            Direccion = item[3].ToString(),
                            Telefono = item[4].ToString(),
                            Email = item[5].ToString()
                        });
                    }

                    this.reportViewer1.LocalReport.ReportEmbeddedResource
                        = "capaPresentacion.Reportes.rptClientes.rdlc";
                    ReportDataSource reporte = new ReportDataSource("dtClientes",e_Clientes);
                    this.reportViewer1.LocalReport.DataSources.Clear();
                    this.reportViewer1.LocalReport.DataSources.Add(reporte);
                    this.reportViewer1.RefreshReport();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
            else
            {
                MessageBox.Show("La tabla CLIENTES no existe en la base de datos","Error");
            }
        }
    }
}
