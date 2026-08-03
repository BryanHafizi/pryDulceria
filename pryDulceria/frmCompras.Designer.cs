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
            dgvCompras = new DataGridView();
            txtBuscar = new TextBox();
            btnCancelar = new Button();
            btnComprar = new Button();
            lblTotal = new Label();
            lblProveedor = new Label();
            cmbProveedor = new ComboBox();
            IdProducto = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Costo = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Subtotal = new DataGridViewTextBoxColumn();
            Quitar = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)pcbCarrito).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbBuscar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCompras).BeginInit();
            SuspendLayout();
            // 
            // pcbCarrito
            // 
            pcbCarrito.Image = (Image)resources.GetObject("pcbCarrito.Image");
            pcbCarrito.Location = new Point(200, 13);
            pcbCarrito.Margin = new Padding(3, 4, 3, 4);
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
            pcbBuscar.Location = new Point(70, 180);
            pcbBuscar.Margin = new Padding(3, 4, 3, 4);
            pcbBuscar.Name = "pcbBuscar";
            pcbBuscar.Size = new Size(35, 35);
            pcbBuscar.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbBuscar.TabIndex = 45;
            pcbBuscar.TabStop = false;
            // 
            // lblIndicacion
            // 
            lblIndicacion.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblIndicacion.AutoSize = true;
            lblIndicacion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIndicacion.Location = new Point(70, 530);
            lblIndicacion.Name = "lblIndicacion";
            lblIndicacion.Size = new Size(312, 28);
            lblIndicacion.TabIndex = 44;
            lblIndicacion.Text = "Doble click para agregar producto";
            // 
            // lblAgregarProductos
            // 
            lblAgregarProductos.AutoSize = true;
            lblAgregarProductos.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAgregarProductos.Location = new Point(70, 130);
            lblAgregarProductos.Name = "lblAgregarProductos";
            lblAgregarProductos.Size = new Size(257, 38);
            lblAgregarProductos.TabIndex = 43;
            lblAgregarProductos.Text = "Agregar productos";
            // 
            // lblDetalleCompra
            // 
            lblDetalleCompra.AutoSize = true;
            lblDetalleCompra.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDetalleCompra.Location = new Point(600, 80);
            lblDetalleCompra.Name = "lblDetalleCompra";
            lblDetalleCompra.Size = new Size(285, 38);
            lblDetalleCompra.TabIndex = 42;
            lblDetalleCompra.Text = "Detalle de la Compra";
            // 
            // dgvProductos
            // 
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.AllowUserToDeleteRows = false;
            dgvProductos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductos.BackgroundColor = Color.White;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.GridColor = SystemColors.WindowText;
            dgvProductos.Location = new Point(70, 225);
            dgvProductos.Margin = new Padding(3, 2, 3, 2);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.RowHeadersVisible = false;
            dgvProductos.RowHeadersWidth = 51;
            dataGridViewCellStyle1.Padding = new Padding(3);
            dgvProductos.RowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductos.Size = new Size(500, 300);
            dgvProductos.TabIndex = 2;
            dgvProductos.CellDoubleClick += dgvProductos_CellDoubleClick;
            // 
            // dgvCompras
            // 
            dgvCompras.AllowUserToAddRows = false;
            dgvCompras.AllowUserToDeleteRows = false;
            dgvCompras.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvCompras.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCompras.BackgroundColor = Color.White;
            dgvCompras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCompras.Columns.AddRange(new DataGridViewColumn[] { IdProducto, Nombre, Costo, Cantidad, Subtotal, Quitar });
            dgvCompras.GridColor = SystemColors.WindowText;
            dgvCompras.Location = new Point(600, 125);
            dgvCompras.Margin = new Padding(3, 2, 3, 2);
            dgvCompras.Name = "dgvCompras";
            dgvCompras.RowHeadersVisible = false;
            dgvCompras.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Padding = new Padding(3);
            dgvCompras.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvCompras.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCompras.Size = new Size(650, 400);
            dgvCompras.TabIndex = 3;
            dgvCompras.CellContentClick += dgvCompras_CellContentClick;
            dgvCompras.CellValueChanged += dgvCompras_CellValueChanged;
            dgvCompras.EditingControlShowing += dgvCompras_EditingControlShowing;
            // 
            // txtBuscar
            // 
            txtBuscar.BorderStyle = BorderStyle.FixedSingle;
            txtBuscar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscar.ForeColor = Color.FromArgb(30, 41, 59);
            txtBuscar.Location = new Point(120, 180);
            txtBuscar.Margin = new Padding(3, 4, 3, 4);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Buscar Producto";
            txtBuscar.Size = new Size(450, 34);
            txtBuscar.TabIndex = 1;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.BackColor = Color.FromArgb(108, 117, 125);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(1100, 530);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(150, 50);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnComprar
            // 
            btnComprar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnComprar.BackColor = Color.FromArgb(30, 41, 59);
            btnComprar.FlatStyle = FlatStyle.Flat;
            btnComprar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnComprar.ForeColor = Color.White;
            btnComprar.Location = new Point(940, 530);
            btnComprar.Margin = new Padding(3, 4, 3, 4);
            btnComprar.Name = "btnComprar";
            btnComprar.Size = new Size(150, 50);
            btnComprar.TabIndex = 4;
            btnComprar.Text = "Comprar";
            btnComprar.UseVisualStyleBackColor = false;
            btnComprar.Click += btnComprar_Click;
            // 
            // lblTotal
            // 
            lblTotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(650, 530);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(268, 38);
            lblTotal.TabIndex = 38;
            lblTotal.Text = "Total a Pagar: $0.00";
            // 
            // lblProveedor
            // 
            lblProveedor.AutoSize = true;
            lblProveedor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProveedor.Location = new Point(70, 90);
            lblProveedor.Name = "lblProveedor";
            lblProveedor.Size = new Size(107, 28);
            lblProveedor.TabIndex = 46;
            lblProveedor.Text = "Proveedor:";
            // 
            // cmbProveedor
            // 
            cmbProveedor.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProveedor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbProveedor.FormattingEnabled = true;
            cmbProveedor.Location = new Point(200, 90);
            cmbProveedor.Margin = new Padding(3, 4, 3, 4);
            cmbProveedor.Name = "cmbProveedor";
            cmbProveedor.Size = new Size(260, 36);
            cmbProveedor.TabIndex = 0;
            // 
            // IdProducto
            // 
            IdProducto.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            IdProducto.HeaderText = "Id";
            IdProducto.MinimumWidth = 6;
            IdProducto.Name = "IdProducto";
            IdProducto.ReadOnly = true;
            IdProducto.Width = 51;
            // 
            // Nombre
            // 
            Nombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Nombre.HeaderText = "Producto";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Costo
            // 
            Costo.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Costo.HeaderText = "Costo";
            Costo.MinimumWidth = 6;
            Costo.Name = "Costo";
            Costo.Width = 76;
            // 
            // Cantidad
            // 
            Cantidad.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Cantidad.HeaderText = "Cantidad";
            Cantidad.MinimumWidth = 6;
            Cantidad.Name = "Cantidad";
            Cantidad.Width = 98;
            // 
            // Subtotal
            // 
            Subtotal.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Subtotal.HeaderText = "Subtotal";
            Subtotal.MinimumWidth = 6;
            Subtotal.Name = "Subtotal";
            Subtotal.ReadOnly = true;
            Subtotal.Width = 94;
            // 
            // Quitar
            // 
            Quitar.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Quitar.HeaderText = "";
            Quitar.MinimumWidth = 6;
            Quitar.Name = "Quitar";
            Quitar.Text = "X";
            Quitar.UseColumnTextForButtonValue = true;
            Quitar.Width = 6;
            // 
            // frmCompras
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(243, 244, 246);
            ClientSize = new Size(1316, 603);
            Controls.Add(cmbProveedor);
            Controls.Add(lblProveedor);
            Controls.Add(pcbBuscar);
            Controls.Add(lblIndicacion);
            Controls.Add(lblAgregarProductos);
            Controls.Add(lblDetalleCompra);
            Controls.Add(dgvProductos);
            Controls.Add(dgvCompras);
            Controls.Add(txtBuscar);
            Controls.Add(btnCancelar);
            Controls.Add(btnComprar);
            Controls.Add(lblTotal);
            Controls.Add(pcbCarrito);
            Controls.Add(lblTitulo);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmCompras";
            Text = "Módulo de Compras";
            ((System.ComponentModel.ISupportInitialize)pcbCarrito).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbBuscar).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCompras).EndInit();
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
        private DataGridView dgvCompras;
        private TextBox txtBuscar;
        private Button btnCancelar;
        private Button btnComprar;
        private Label lblTotal;
        private Label lblProveedor;
        private ComboBox cmbProveedor;
        private DataGridViewTextBoxColumn IdProducto;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Costo;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Subtotal;
        private DataGridViewButtonColumn Quitar;
    }
}