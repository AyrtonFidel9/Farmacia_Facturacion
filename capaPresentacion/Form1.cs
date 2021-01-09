using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capaPresentacion.Ventanas;
using capaPresentacion.Controles;

namespace capaPresentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReporteEmpleados reporte = new ReporteEmpleados();
            reporte.Show();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            if(pnlNavegacion.Contains(inicio) == false)
            {
                pnlNavegacion.Controls.Add(inicio);
                inicio.Dock = DockStyle.Fill;
                inicio.BringToFront();
            }
            else
            {
                inicio.BringToFront();
            }
        }
    }
}
