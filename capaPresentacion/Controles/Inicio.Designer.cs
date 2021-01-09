namespace capaPresentacion.Controles
{
    partial class Inicio
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.xuiGauge1 = new XanderUI.XUIGauge();
            this.SuspendLayout();
            // 
            // xuiGauge1
            // 
            this.xuiGauge1.DialColor = System.Drawing.Color.Gray;
            this.xuiGauge1.DialThickness = 5;
            this.xuiGauge1.FilledColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(162)))), ((int)(((byte)(250)))));
            this.xuiGauge1.GaugeStyle = XanderUI.XUIGauge.Style.Material;
            this.xuiGauge1.Location = new System.Drawing.Point(338, 3);
            this.xuiGauge1.Name = "xuiGauge1";
            this.xuiGauge1.Percentage = 75;
            this.xuiGauge1.Size = new System.Drawing.Size(258, 109);
            this.xuiGauge1.TabIndex = 0;
            this.xuiGauge1.Text = "xuiGauge1";
            this.xuiGauge1.Thickness = 8;
            this.xuiGauge1.UnfilledColor = System.Drawing.Color.Gray;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.xuiGauge1);
            this.Name = "Inicio";
            this.Size = new System.Drawing.Size(613, 486);
            this.ResumeLayout(false);

        }

        #endregion

        private XanderUI.XUIGauge xuiGauge1;
    }
}
