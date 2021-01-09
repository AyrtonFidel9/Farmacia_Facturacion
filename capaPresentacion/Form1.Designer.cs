
namespace capaPresentacion
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnInicio = new XanderUI.XUIButton();
            this.btnClientes = new XanderUI.XUIButton();
            this.btnEmpleados = new XanderUI.XUIButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnlNavegacion = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.btnEmpleados);
            this.panel1.Controls.Add(this.btnClientes);
            this.panel1.Controls.Add(this.btnInicio);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(216, 578);
            this.panel1.TabIndex = 0;
            // 
            // btnInicio
            // 
            this.btnInicio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInicio.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnInicio.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnInicio.ButtonImage")));
            this.btnInicio.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnInicio.ButtonText = "Inicio";
            this.btnInicio.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnInicio.ClickTextColor = System.Drawing.Color.White;
            this.btnInicio.CornerRadius = 5;
            this.btnInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnInicio.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(14)))), ((int)(((byte)(22)))));
            this.btnInicio.HoverTextColor = System.Drawing.Color.White;
            this.btnInicio.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnInicio.Location = new System.Drawing.Point(0, 73);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(216, 64);
            this.btnInicio.TabIndex = 1;
            this.btnInicio.TextColor = System.Drawing.Color.Black;
            this.btnInicio.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClientes.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnClientes.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnClientes.ButtonImage")));
            this.btnClientes.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnClientes.ButtonText = "Clientes";
            this.btnClientes.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnClientes.ClickTextColor = System.Drawing.Color.White;
            this.btnClientes.CornerRadius = 5;
            this.btnClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnClientes.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(14)))), ((int)(((byte)(22)))));
            this.btnClientes.HoverTextColor = System.Drawing.Color.White;
            this.btnClientes.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnClientes.Location = new System.Drawing.Point(-1, 161);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(217, 61);
            this.btnClientes.TabIndex = 2;
            this.btnClientes.TextColor = System.Drawing.Color.Black;
            this.btnClientes.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEmpleados.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnEmpleados.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnEmpleados.ButtonImage")));
            this.btnEmpleados.ButtonStyle = XanderUI.XUIButton.Style.MaterialRounded;
            this.btnEmpleados.ButtonText = "Empleados";
            this.btnEmpleados.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnEmpleados.ClickTextColor = System.Drawing.Color.White;
            this.btnEmpleados.CornerRadius = 5;
            this.btnEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleados.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnEmpleados.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(14)))), ((int)(((byte)(22)))));
            this.btnEmpleados.HoverTextColor = System.Drawing.Color.White;
            this.btnEmpleados.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.btnEmpleados.Location = new System.Drawing.Point(3, 247);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(213, 59);
            this.btnEmpleados.TabIndex = 3;
            this.btnEmpleados.TextColor = System.Drawing.Color.Black;
            this.btnEmpleados.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(214, 58);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pnlNavegacion
            // 
            this.pnlNavegacion.Location = new System.Drawing.Point(213, -1);
            this.pnlNavegacion.Name = "pnlNavegacion";
            this.pnlNavegacion.Size = new System.Drawing.Size(672, 578);
            this.pnlNavegacion.TabIndex = 1;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 577);
            this.Controls.Add(this.pnlNavegacion);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pharmacy\'s";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroPanel Opciones;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroButton metroButton4;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.Panel panel1;
        private XanderUI.XUIButton btnEmpleados;
        private XanderUI.XUIButton btnClientes;
        private XanderUI.XUIButton btnInicio;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel pnlNavegacion;
    }
}

