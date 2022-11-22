namespace SP02_Ferro_Luna
{
    partial class FrmMain
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
            this.mrcCosto = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblPrecioKm = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtPrecioKm = new System.Windows.Forms.TextBox();
            this.lblDistancia = new System.Windows.Forms.Label();
            this.lblDias = new System.Windows.Forms.Label();
            this.txtDistancia = new System.Windows.Forms.TextBox();
            this.nudDias = new System.Windows.Forms.NumericUpDown();
            this.mrcCosto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDias)).BeginInit();
            this.SuspendLayout();
            // 
            // mrcCosto
            // 
            this.mrcCosto.Controls.Add(this.lblTotal);
            this.mrcCosto.Controls.Add(this.lblPrecioKm);
            this.mrcCosto.Controls.Add(this.txtTotal);
            this.mrcCosto.Controls.Add(this.txtPrecioKm);
            this.mrcCosto.Location = new System.Drawing.Point(24, 130);
            this.mrcCosto.Name = "mrcCosto";
            this.mrcCosto.Size = new System.Drawing.Size(264, 106);
            this.mrcCosto.TabIndex = 11;
            this.mrcCosto.TabStop = false;
            this.mrcCosto.Text = "Costo";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(72, 54);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 13);
            this.lblTotal.TabIndex = 9;
            this.lblTotal.Text = "Total";
            // 
            // lblPrecioKm
            // 
            this.lblPrecioKm.AutoSize = true;
            this.lblPrecioKm.Location = new System.Drawing.Point(66, 28);
            this.lblPrecioKm.Name = "lblPrecioKm";
            this.lblPrecioKm.Size = new System.Drawing.Size(37, 13);
            this.lblPrecioKm.TabIndex = 7;
            this.lblPrecioKm.Text = "Precio";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(109, 51);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(70, 20);
            this.txtTotal.TabIndex = 8;
            // 
            // txtPrecioKm
            // 
            this.txtPrecioKm.Location = new System.Drawing.Point(109, 25);
            this.txtPrecioKm.Name = "txtPrecioKm";
            this.txtPrecioKm.Size = new System.Drawing.Size(70, 20);
            this.txtPrecioKm.TabIndex = 6;
            // 
            // lblDistancia
            // 
            this.lblDistancia.AutoSize = true;
            this.lblDistancia.Location = new System.Drawing.Point(25, 75);
            this.lblDistancia.Name = "lblDistancia";
            this.lblDistancia.Size = new System.Drawing.Size(51, 13);
            this.lblDistancia.TabIndex = 9;
            this.lblDistancia.Text = "Distancia";
            // 
            // lblDias
            // 
            this.lblDias.AutoSize = true;
            this.lblDias.Location = new System.Drawing.Point(46, 39);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(30, 13);
            this.lblDias.TabIndex = 8;
            this.lblDias.Text = "Días";
            // 
            // txtDistancia
            // 
            this.txtDistancia.Location = new System.Drawing.Point(82, 72);
            this.txtDistancia.Name = "txtDistancia";
            this.txtDistancia.Size = new System.Drawing.Size(70, 20);
            this.txtDistancia.TabIndex = 7;
            this.txtDistancia.TextChanged += new System.EventHandler(this.txtDistancia_TextChanged);
            // 
            // nudDias
            // 
            this.nudDias.Location = new System.Drawing.Point(82, 37);
            this.nudDias.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudDias.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDias.Name = "nudDias";
            this.nudDias.Size = new System.Drawing.Size(52, 20);
            this.nudDias.TabIndex = 6;
            this.nudDias.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDias.ValueChanged += new System.EventHandler(this.nudDias_ValueChanged);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 274);
            this.Controls.Add(this.mrcCosto);
            this.Controls.Add(this.lblDistancia);
            this.Controls.Add(this.lblDias);
            this.Controls.Add(this.txtDistancia);
            this.Controls.Add(this.nudDias);
            this.Name = "FrmMain";
            this.Text = "Ferrocarriles Argentinos";
            this.mrcCosto.ResumeLayout(false);
            this.mrcCosto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox mrcCosto;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblPrecioKm;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtPrecioKm;
        private System.Windows.Forms.Label lblDistancia;
        private System.Windows.Forms.Label lblDias;
        private System.Windows.Forms.TextBox txtDistancia;
        private System.Windows.Forms.NumericUpDown nudDias;
    }
}

