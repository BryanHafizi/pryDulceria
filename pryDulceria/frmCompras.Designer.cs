namespace pryDulceria
{
    partial class frmCompras
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCompras));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            pcbCarrito = new PictureBox();
            lblTitulo = new Label();
            pcbBuscar = new PictureBox();
            lblIndicacion = new Label();
            lblAgregarProductos = new Label();
            lblDetalleCompra = new Label();
            dgvProductos = new DataGridView();
            dgvCarrito = new DataGridView();
            txtBuscar = new TextBox();
            btnCancelar = new Button();
            btnComprar = new Button();
            lblTotal = new Label();
            lblProveedor = new Label();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pcbCarrito).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbBuscar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).BeginInit();
            SuspendLayout();
            // 
            // pcbCarrito
            // 
            pcbCarrito.Image = (Image)resources.GetObject("pcbCarrito.Image");
            pcbCarrito.Location = new Point(200, 13);
            pcbCarrito.Name = "pcbCarrito";
            pcbCarrito.Size = new Size(100, 50);
            pcbCarrito.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbCarrito.TabIndex = 35;
            pcbCarrito.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(12, 13);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(190, 54);
            lblTitulo.TabIndex = 34;
            lblTitulo.Text = "Compras";
            // 
            // pcbBuscar
            // 
            pcbBuscar.Image = Properties.Resources.buscar;
            pcbBuscar.Location = new Point(65, 177);
            pcbBuscar.Name = "pcbBuscar";
            pcbBuscar.Size = new Size(30, 34);
            pcbBuscar.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbBuscar.TabIndex = 45;
            pcbBuscar.TabStop = false;
            // 
            // lblIndicacion
            // 
            lblIndicacion.AutoSize = true;
            lblIndicacion.Font = new Font("Segoe UI Light", 12F);
            lblIndicacion.Location = new Point(162, 501);
            lblIndicacion.Name = "lblIndicacion";
            lblIndicacion.Size = new Size(297, 28);
            lblIndicacion.TabIndex = 44;
            lblIndicacion.Text = "Doble click para agregar producto";
            // 
            // lblAgregarProductos
            // 
            lblAgregarProductos.AutoSize = true;
            lblAgregarProductos.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAgregarProductos.Location = new Point(65, 144);
            lblAgregarProductos.Name = "lblAgregarProductos";
            lblAgregarProductos.Size = new Size(189, 28);
            lblAgregarProductos.TabIndex = 43;
            lblAgregarProductos.Text = "Agregar productos";
            // 
            // lblDetalleCompra
            // 
            lblDetalleCompra.AutoSize = true;
            lblDetalleCompra.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDetalleCompra.Location = new Point(604, 92);
            lblDetalleCompra.Name = "lblDetalleCompra";
            lblDetalleCompra.Size = new Size(211, 28);
            lblDetalleCompra.TabIndex = 42;
            lblDetalleCompra.Text = "Detalle de la Compra";
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
            dgvProductos.Location = new Point(65, 216);
            dgvProductos.Margin = new Padding(3, 2, 3, 2);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.RowHeadersVisible = false;
            dgvProductos.RowHeadersWidth = 51;
            dataGridViewCellStyle1.Padding = new Padding(3);
            dgvProductos.RowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductos.Size = new Size(489, 271);
            dgvProductos.TabIndex = 41;
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
            dgvCarrito.Location = new Point(604, 126);
            dgvCarrito.Margin = new Padding(3, 2, 3, 2);
            dgvCarrito.Name = "dgvCarrito";
            dgvCarrito.ReadOnly = true;
            dgvCarrito.RowHeadersVisible = false;
            dgvCarrito.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Padding = new Padding(3);
            dgvCarrito.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvCarrito.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCarrito.Size = new Size(648, 361);
            dgvCarrito.TabIndex = 40;
            // 
            // txtBuscar
            // 
            txtBuscar.BorderStyle = BorderStyle.FixedSingle;
            txtBuscar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscar.ForeColor = Color.FromArgb(30, 41, 59);
            txtBuscar.Location = new Point(101, 177);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Buscar Producto";
            txtBuscar.Size = new Size(453, 34);
            txtBuscar.TabIndex = 39;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCancelar.BackColor = Color.LightCoral;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(1102, 501);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(150, 50);
            btnCancelar.TabIndex = 36;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnComprar
            // 
            btnComprar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnComprar.BackColor = Color.FromArgb(194, 24, 91);
            btnComprar.FlatStyle = FlatStyle.Flat;
            btnComprar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnComprar.ForeColor = Color.White;
            btnComprar.Location = new Point(934, 501);
            btnComprar.Name = "btnComprar";
            btnComprar.Size = new Size(150, 50);
            btnComprar.TabIndex = 37;
            btnComprar.Text = "Comprar";
            btnComprar.UseVisualStyleBackColor = false;
            // 
            // lblTotal
            // 
            lblTotal.Anchor = AnchorStyles.Bottom;
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(694, 512);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(201, 28);
            lblTotal.TabIndex = 38;
            lblTotal.Text = "Total a Pagar: $0.00";
            // 
            // lblProveedor
            // 
            lblProveedor.AutoSize = true;
            lblProveedor.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProveedor.Location = new Point(65, 92);
            lblProveedor.Name = "lblProveedor";
            lblProveedor.Size = new Size(109, 28);
            lblProveedor.TabIndex = 46;
            lblProveedor.Text = "Proveedor";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(66, 122);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(488, 28);
            comboBox1.TabIndex = 47;
            // 
            // frmCompras
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 242, 245);
            ClientSize = new Size(1316, 603);
            Controls.Add(comboBox1);
            Controls.Add(lblProveedor);
            Controls.Add(pcbBuscar);
            Controls.Add(lblIndicacion);
            Controls.Add(lblAgregarProductos);
            Controls.Add(lblDetalleCompra);
            Controls.Add(dgvProductos);
            Controls.Add(dgvCarrito);
            Controls.Add(txtBuscar);
            Controls.Add(btnCancelar);
            Controls.Add(btnComprar);
            Controls.Add(lblTotal);
            Controls.Add(pcbCarrito);
            Controls.Add(lblTitulo);
            Name = "frmCompras";
            Text = "frmCompras";
            ((System.ComponentModel.ISupportInitialize)pcbCarrito).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbBuscar).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pcbCarrito;
        private Label lblTitulo;
        private PictureBox pcbBuscar;
        private Label lblIndicacion;
        private Label lblAgregarProductos;
        private Label lblDetalleCompra;
        private DataGridView dgvProductos;
        private DataGridView dgvCarrito;
        private TextBox txtBuscar;
        private Button btnCancelar;
        private Button btnComprar;
        private Label lblTotal;
        private Label lblProveedor;
        private ComboBox comboBox1;
    }
}