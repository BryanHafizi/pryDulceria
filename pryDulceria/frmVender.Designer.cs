namespace pryDulceria

{
    partial class frmVender
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtBuscarProducto = new System.Windows.Forms.TextBox();
            this.dgyVenta = new System.Windows.Forms.DataGridView();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnCobrar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgyVenta)).BeginInit();
            this.SuspendLayout();

            // lblTitulo
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(30, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(182, 37);
            this.lblTitulo.Text = "Nueva Venta";

            // lblBuscar
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(30, 85);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(129, 21);
            this.lblBuscar.Text = "Buscar producto:";

            // txtBuscarProducto
            this.txtBuscarProducto.Location = new System.Drawing.Point(170, 82);
            this.txtBuscarProducto.Name = "txtBuscarProducto";
            this.txtBuscarProducto.Size = new System.Drawing.Size(400, 29);

            // dgyVenta
            this.dgyVenta.BackgroundColor = System.Drawing.Color.White;
            this.dgyVenta.GridColor = System.Drawing.Color.FromArgb(224, 176, 255);
            this.dgyVenta.Location = new System.Drawing.Point(30, 130);
            this.dgyVenta.Name = "dgyVenta";
            this.dgyVenta.Size = new System.Drawing.Size(950, 420);
            this.dgyVenta.TabIndex = 2;

            // lblTotal
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTotal.Location = new System.Drawing.Point(730, 570);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(233, 30);
            this.lblTotal.Text = "Total a Pagar: $0.00";

            // btnCobrar
            this.btnCobrar.BackColor = System.Drawing.Color.FromArgb(255, 105, 180);
            this.btnCobrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCobrar.ForeColor = System.Drawing.Color.White;
            this.btnCobrar.Location = new System.Drawing.Point(860, 630);
            this.btnCobrar.Name = "btnCobrar";
            this.btnCobrar.Size = new System.Drawing.Size(120, 40);
            this.btnCobrar.Text = "Cobrar";
            this.btnCobrar.UseVisualStyleBackColor = false;

            // btnCancelar
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(240, 128, 128);
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(740, 632);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 35);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;

            // frmVender
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(255, 228, 225);
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCobrar);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.dgyVenta);
            this.Controls.Add(this.txtBuscarProducto);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular);
            this.Name = "frmVender";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Módulo de Facturación y Ventas";
            ((System.ComponentModel.ISupportInitialize)(this.dgyVenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBuscarProducto;
        private System.Windows.Forms.DataGridView dgyVenta;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnCobrar;
        private System.Windows.Forms.Button btnCancelar;
    }
}