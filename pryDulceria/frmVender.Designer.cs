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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVender));
            lblTitulo = new Label();
            lblBuscar = new Label();
            txtBuscarProducto = new TextBox();
            dgyVenta = new DataGridView();
            lblTotal = new Label();
            btnCobrar = new Button();
            btnCancelar = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgyVenta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitulo.Location = new Point(204, 23);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(102, 37);
            lblTitulo.TabIndex = 5;
            lblTitulo.Text = "Ventas";
            lblTitulo.Click += lblTitulo_Click;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Location = new Point(448, 82);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(126, 21);
            lblBuscar.TabIndex = 4;
            lblBuscar.Text = "Buscar producto:";
            // 
            // txtBuscarProducto
            // 
            txtBuscarProducto.Location = new Point(580, 82);
            txtBuscarProducto.Name = "txtBuscarProducto";
            txtBuscarProducto.Size = new Size(400, 29);
            txtBuscarProducto.TabIndex = 3;
            // 
            // dgyVenta
            // 
            dgyVenta.BackgroundColor = Color.White;
            dgyVenta.GridColor = Color.FromArgb(224, 176, 255);
            dgyVenta.Location = new Point(30, 130);
            dgyVenta.Name = "dgyVenta";
            dgyVenta.Size = new Size(950, 420);
            dgyVenta.TabIndex = 2;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTotal.Location = new Point(730, 570);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(219, 30);
            lblTotal.TabIndex = 2;
            lblTotal.Text = "Total a Pagar: $0.00";
            // 
            // btnCobrar
            // 
            btnCobrar.BackColor = Color.FromArgb(255, 105, 180);
            btnCobrar.FlatStyle = FlatStyle.Flat;
            btnCobrar.ForeColor = Color.White;
            btnCobrar.Location = new Point(860, 630);
            btnCobrar.Name = "btnCobrar";
            btnCobrar.Size = new Size(120, 40);
            btnCobrar.TabIndex = 1;
            btnCobrar.Text = "Cobrar";
            btnCobrar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(240, 128, 128);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(740, 632);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(100, 35);
            btnCancelar.TabIndex = 0;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(30, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(159, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // frmVender
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 228, 225);
            ClientSize = new Size(1024, 768);
            Controls.Add(pictureBox1);
            Controls.Add(btnCancelar);
            Controls.Add(btnCobrar);
            Controls.Add(lblTotal);
            Controls.Add(dgyVenta);
            Controls.Add(txtBuscarProducto);
            Controls.Add(lblBuscar);
            Controls.Add(lblTitulo);
            Font = new Font("Segoe UI", 12F);
            Name = "frmVender";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Módulo de Facturación y Ventas";
            ((System.ComponentModel.ISupportInitialize)dgyVenta).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBuscarProducto;
        private System.Windows.Forms.DataGridView dgyVenta;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnCobrar;
        private System.Windows.Forms.Button btnCancelar;
        private PictureBox pictureBox1;
    }
}