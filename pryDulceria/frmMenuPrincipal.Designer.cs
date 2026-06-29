namespace pryDulceria
{
    partial class frmMenuAdmin
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) { components.Dispose(); }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.pnlContenedorMenu = new System.Windows.Forms.Panel();
            this.btnVentas = new System.Windows.Forms.Button();
            this.btnInventario = new System.Windows.Forms.Button();
            this.btnProveedores = new System.Windows.Forms.Button();
            this.lblResumen = new System.Windows.Forms.Label();
            this.pnlContenedorMenu.SuspendLayout();
            this.SuspendLayout();

            // lblBienvenida
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblBienvenida.ForeColor = System.Drawing.Color.FromArgb(51, 51, 51);
            this.lblBienvenida.Location = new System.Drawing.Point(30, 30);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(466, 37);
            this.lblBienvenida.Text = "Panel de Control - Dulcería Marlyn";

            // pnlContenedorMenu
            this.pnlContenedorMenu.BackColor = System.Drawing.Color.FromArgb(255, 192, 203);
            this.pnlContenedorMenu.Controls.Add(this.btnProveedores);
            this.pnlContenedorMenu.Controls.Add(this.btnInventario);
            this.pnlContenedorMenu.Controls.Add(this.btnVentas);
            this.pnlContenedorMenu.Location = new System.Drawing.Point(30, 100);
            this.pnlContenedorMenu.Name = "pnlContenedorMenu";
            this.pnlContenedorMenu.Size = new System.Drawing.Size(950, 400);

            // btnVentas
            this.btnVentas.BackColor = System.Drawing.Color.FromArgb(255, 105, 180);
            this.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentas.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnVentas.ForeColor = System.Drawing.Color.White;
            this.btnVentas.Location = new System.Drawing.Point(50, 120);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(200, 150);
            this.btnVentas.Text = "Módulo de Ventas";
            this.btnVentas.UseVisualStyleBackColor = false;

            // btnInventario
            this.btnInventario.BackColor = System.Drawing.Color.FromArgb(255, 105, 180);
            this.btnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventario.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnInventario.ForeColor = System.Drawing.Color.White;
            this.btnInventario.Location = new System.Drawing.Point(370, 120);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(200, 150);
            this.btnInventario.Text = "Inventario";
            this.btnInventario.UseVisualStyleBackColor = false;

            // btnProveedores
            this.btnProveedores.BackColor = System.Drawing.Color.FromArgb(255, 105, 180);
            this.btnProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProveedores.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnProveedores.ForeColor = System.Drawing.Color.White;
            this.btnProveedores.Location = new System.Drawing.Point(690, 120);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Size = new System.Drawing.Size(200, 150);
            this.btnProveedores.Text = "Proveedores";
            this.btnProveedores.UseVisualStyleBackColor = false;

            // lblResumen
            this.lblResumen.AutoSize = true;
            this.lblResumen.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Italic);
            this.lblResumen.ForeColor = System.Drawing.Color.FromArgb(51, 51, 51);
            this.lblResumen.Location = new System.Drawing.Point(30, 540);
            this.lblResumen.Name = "lblResumen";
            this.lblResumen.Size = new System.Drawing.Size(186, 75);
            this.lblResumen.Text = "Resumen del día:\n• Ventas totales: Activas\n• Alertas de Stock: 0";

            // frmMenuAdmin
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(255, 228, 225);
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.lblResumen);
            this.Controls.Add(this.pnlContenedorMenu);
            this.Controls.Add(this.lblBienvenida);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular);
            this.Name = "frmMenuAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú Principal - Administrador";
            this.pnlContenedorMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion

        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.Panel pnlContenedorMenu;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.Button btnProveedores;
        private System.Windows.Forms.Label lblResumen;
    }
}