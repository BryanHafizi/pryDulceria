namespace pryDulceria

{
    partial class frmVentas
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            lblTitulo = new Label();
            lblTotal = new Label();
            btnCobrar = new Button();
            btnCancelar = new Button();
            pcbCarrito = new PictureBox();
            txtBuscar = new TextBox();
            dgvCarrito = new DataGridView();
            dgvProductos = new DataGridView();
            lblDetalleVenta = new Label();
            lblAgregarProducto = new Label();
            lblIndicacion = new Label();
            pcbBuscar = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pcbCarrito).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbBuscar).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(12, 13);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(149, 54);
            lblTitulo.TabIndex = 5;
            lblTitulo.Text = "Ventas";
            // 
            // lblTotal
            // 
            lblTotal.Anchor = AnchorStyles.Bottom;
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(650, 530);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(268, 38);
            lblTotal.TabIndex = 2;
            lblTotal.Text = "Total a Pagar: $0.00";
            // 
            // btnCobrar
            // 
            btnCobrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCobrar.BackColor = Color.FromArgb(30, 41, 59);
            btnCobrar.FlatStyle = FlatStyle.Flat;
            btnCobrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCobrar.ForeColor = Color.White;
            btnCobrar.Location = new Point(940, 530);
            btnCobrar.Name = "btnCobrar";
            btnCobrar.Size = new Size(150, 50);
            btnCobrar.TabIndex = 1;
            btnCobrar.Text = "Cobrar";
            btnCobrar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCancelar.BackColor = Color.FromArgb(108, 117, 125);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(1100, 530);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(150, 50);
            btnCancelar.TabIndex = 0;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // pcbCarrito
            // 
            pcbCarrito.BackColor = Color.Transparent;
            pcbCarrito.Image = Properties.Resources.Code_Generated_Image;
            pcbCarrito.Location = new Point(167, 13);
            pcbCarrito.Name = "pcbCarrito";
            pcbCarrito.Size = new Size(100, 50);
            pcbCarrito.SizeMode = PictureBoxSizeMode.Zoom;
            pcbCarrito.TabIndex = 7;
            pcbCarrito.TabStop = false;
            // 
            // txtBuscar
            // 
            txtBuscar.BorderStyle = BorderStyle.FixedSingle;
            txtBuscar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscar.ForeColor = Color.FromArgb(30, 41, 59);
            txtBuscar.Location = new Point(120, 125);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Buscar Producto";
            txtBuscar.Size = new Size(450, 34);
            txtBuscar.TabIndex = 13;
            // 
            // dgvCarrito
            // 
            dgvCarrito.AllowUserToAddRows = false;
            dgvCarrito.AllowUserToDeleteRows = false;
            dgvCarrito.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvCarrito.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCarrito.BackgroundColor = Color.White;
            dgvCarrito.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarrito.GridColor = SystemColors.WindowText;
            dgvCarrito.Location = new Point(600, 125);
            dgvCarrito.Margin = new Padding(3, 2, 3, 2);
            dgvCarrito.Name = "dgvCarrito";
            dgvCarrito.ReadOnly = true;
            dgvCarrito.RowHeadersVisible = false;
            dgvCarrito.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Padding = new Padding(3);
            dgvCarrito.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvCarrito.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCarrito.Size = new Size(650, 400);
            dgvCarrito.TabIndex = 30;
            // 
            // dgvProductos
            // 
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.AllowUserToDeleteRows = false;
            dgvProductos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductos.BackgroundColor = Color.White;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.GridColor = SystemColors.WindowText;
            dgvProductos.Location = new Point(70, 175);
            dgvProductos.Margin = new Padding(3, 2, 3, 2);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.RowHeadersVisible = false;
            dgvProductos.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Padding = new Padding(3);
            dgvProductos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductos.Size = new Size(500, 350);
            dgvProductos.TabIndex = 31;
            dgvProductos.CellContentClick += dgvProductos_CellContentClick;
            // 
            // lblDetalleVenta
            // 
            lblDetalleVenta.AutoSize = true;
            lblDetalleVenta.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDetalleVenta.Location = new Point(600, 80);
            lblDetalleVenta.Name = "lblDetalleVenta";
            lblDetalleVenta.Size = new Size(256, 38);
            lblDetalleVenta.TabIndex = 32;
            lblDetalleVenta.Text = "Detalle de la Venta";
            // 
            // lblAgregarProducto
            // 
            lblAgregarProducto.AutoSize = true;
            lblAgregarProducto.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAgregarProducto.Location = new Point(70, 80);
            lblAgregarProducto.Name = "lblAgregarProducto";
            lblAgregarProducto.Size = new Size(257, 38);
            lblAgregarProducto.TabIndex = 33;
            lblAgregarProducto.Text = "Agregar productos";
            // 
            // lblIndicacion
            // 
            lblIndicacion.AutoSize = true;
            lblIndicacion.BackColor = Color.Transparent;
            lblIndicacion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIndicacion.ForeColor = Color.Black;
            lblIndicacion.Location = new Point(70, 530);
            lblIndicacion.Name = "lblIndicacion";
            lblIndicacion.Size = new Size(312, 28);
            lblIndicacion.TabIndex = 34;
            lblIndicacion.Text = "Doble click para agregar producto";
            // 
            // pcbBuscar
            // 
            pcbBuscar.Image = Properties.Resources.buscar;
            pcbBuscar.Location = new Point(70, 125);
            pcbBuscar.Name = "pcbBuscar";
            pcbBuscar.Size = new Size(35, 35);
            pcbBuscar.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbBuscar.TabIndex = 35;
            pcbBuscar.TabStop = false;
            // 
            // frmVentas
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 244, 246);
            ClientSize = new Size(1316, 603);
            ControlBox = false;
            Controls.Add(pcbBuscar);
            Controls.Add(lblIndicacion);
            Controls.Add(lblAgregarProducto);
            Controls.Add(lblDetalleVenta);
            Controls.Add(dgvProductos);
            Controls.Add(dgvCarrito);
            Controls.Add(txtBuscar);
            Controls.Add(pcbCarrito);
            Controls.Add(btnCancelar);
            Controls.Add(btnCobrar);
            Controls.Add(lblTotal);
            Controls.Add(lblTitulo);
            Font = new Font("Segoe UI", 12F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmVentas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Módulo de Facturación y Ventas";
            ((System.ComponentModel.ISupportInitialize)pcbCarrito).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbBuscar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnCobrar;
        private System.Windows.Forms.Button btnCancelar;
        private PictureBox pcbCarrito;
        private TextBox txtBuscar;
        private DataGridView dgvCarrito;
        private DataGridView dgvProductos;
        private Label lblDetalleVenta;
        private Label lblAgregarProducto;
        private Label lblIndicacion;
        private PictureBox pcbBuscar;
    }
}