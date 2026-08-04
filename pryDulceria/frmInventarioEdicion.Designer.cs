namespace pryDulceria
{
    partial class frmInventarioEdicion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInventarioEdicion));
            lblNombre = new Label();
            btnGuardar = new Button();
            pcbEditar = new PictureBox();
            txtNombre = new TextBox();
            lblCategoria = new Label();
            txtPrecio = new TextBox();
            lblPrecio = new Label();
            txtStock = new TextBox();
            lblStock = new Label();
            lblTitulo = new Label();
            cmbCategoria = new ComboBox();
            txtMargenGanancia = new TextBox();
            lblMargenGanancia = new Label();
            txtPrecioVenta = new TextBox();
            lblPrecioVenta = new Label();
            txtCodigo = new TextBox();
            lblCodigo = new Label();
            ((System.ComponentModel.ISupportInitialize)pcbEditar).BeginInit();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombre.ForeColor = Color.Black;
            lblNombre.Location = new Point(27, 88);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(207, 28);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "Nombre del Producto:";
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(30, 41, 59);
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(298, 459);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(150, 50);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // pcbEditar
            // 
            pcbEditar.BackColor = Color.Transparent;
            pcbEditar.Image = (Image)resources.GetObject("pcbEditar.Image");
            pcbEditar.Location = new Point(440, 13);
            pcbEditar.Name = "pcbEditar";
            pcbEditar.Size = new Size(100, 50);
            pcbEditar.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbEditar.TabIndex = 5;
            pcbEditar.TabStop = false;
            // 
            // txtNombre
            // 
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.ForeColor = Color.Black;
            txtNombre.Location = new Point(267, 88);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(260, 34);
            txtNombre.TabIndex = 0;
            txtNombre.KeyPress += txtNombre_KeyPress;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCategoria.ForeColor = Color.Black;
            lblCategoria.Location = new Point(27, 138);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(219, 28);
            lblCategoria.TabIndex = 7;
            lblCategoria.Text = "Categoría del Producto:";
            // 
            // txtPrecio
            // 
            txtPrecio.BorderStyle = BorderStyle.FixedSingle;
            txtPrecio.ForeColor = Color.Black;
            txtPrecio.Location = new Point(267, 188);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(260, 34);
            txtPrecio.TabIndex = 2;
            txtPrecio.TextChanged += txtPrecio_TextChanged;
            txtPrecio.KeyPress += txtPrecio_KeyPress;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrecio.ForeColor = Color.Black;
            lblPrecio.Location = new Point(27, 188);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(188, 28);
            lblPrecio.TabIndex = 11;
            lblPrecio.Text = "Precio del Producto:";
            // 
            // txtStock
            // 
            txtStock.BorderStyle = BorderStyle.FixedSingle;
            txtStock.ForeColor = Color.Black;
            txtStock.Location = new Point(267, 338);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(260, 34);
            txtStock.TabIndex = 5;
            txtStock.KeyPress += txtStock_KeyPress;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStock.ForeColor = Color.Black;
            lblStock.Location = new Point(27, 338);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(182, 28);
            lblStock.TabIndex = 13;
            lblStock.Text = "Stock del Producto:";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.Black;
            lblTitulo.Location = new Point(12, 13);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(418, 54);
            lblTitulo.TabIndex = 15;
            lblTitulo.Text = "Edición de Productos";
            // 
            // cmbCategoria
            // 
            cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(267, 138);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(260, 36);
            cmbCategoria.TabIndex = 1;
            // 
            // txtMargenGanancia
            // 
            txtMargenGanancia.BorderStyle = BorderStyle.FixedSingle;
            txtMargenGanancia.ForeColor = Color.Black;
            txtMargenGanancia.Location = new Point(267, 238);
            txtMargenGanancia.Name = "txtMargenGanancia";
            txtMargenGanancia.Size = new Size(260, 34);
            txtMargenGanancia.TabIndex = 3;
            txtMargenGanancia.TextChanged += txtMargenGanancia_TextChanged;
            txtMargenGanancia.KeyPress += txtMargenGanancia_KeyPress;
            // 
            // lblMargenGanancia
            // 
            lblMargenGanancia.AutoSize = true;
            lblMargenGanancia.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMargenGanancia.ForeColor = Color.Black;
            lblMargenGanancia.Location = new Point(27, 238);
            lblMargenGanancia.Name = "lblMargenGanancia";
            lblMargenGanancia.Size = new Size(194, 28);
            lblMargenGanancia.TabIndex = 18;
            lblMargenGanancia.Text = "Margen de ganancia:";
            // 
            // txtPrecioVenta
            // 
            txtPrecioVenta.BorderStyle = BorderStyle.FixedSingle;
            txtPrecioVenta.ForeColor = Color.Black;
            txtPrecioVenta.Location = new Point(267, 288);
            txtPrecioVenta.Name = "txtPrecioVenta";
            txtPrecioVenta.Size = new Size(260, 34);
            txtPrecioVenta.TabIndex = 4;
            txtPrecioVenta.TextChanged += txtPrecioVenta_TextChanged;
            txtPrecioVenta.KeyPress += txtPrecioVenta_KeyPress;
            // 
            // lblPrecioVenta
            // 
            lblPrecioVenta.AutoSize = true;
            lblPrecioVenta.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrecioVenta.ForeColor = Color.Black;
            lblPrecioVenta.Location = new Point(27, 288);
            lblPrecioVenta.Name = "lblPrecioVenta";
            lblPrecioVenta.Size = new Size(150, 28);
            lblPrecioVenta.TabIndex = 20;
            lblPrecioVenta.Text = "Precio de venta:";
            // 
            // txtCodigo
            // 
            txtCodigo.BorderStyle = BorderStyle.FixedSingle;
            txtCodigo.ForeColor = Color.Black;
            txtCodigo.Location = new Point(267, 388);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(260, 34);
            txtCodigo.TabIndex = 21;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCodigo.ForeColor = Color.Black;
            lblCodigo.Location = new Point(27, 388);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(182, 28);
            lblCodigo.TabIndex = 22;
            lblCodigo.Text = "Stock del Producto:";
            // 
            // frmInventarioEdicion
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 246, 249);
            ClientSize = new Size(632, 553);
            Controls.Add(txtCodigo);
            Controls.Add(lblCodigo);
            Controls.Add(lblPrecioVenta);
            Controls.Add(txtPrecioVenta);
            Controls.Add(lblMargenGanancia);
            Controls.Add(txtMargenGanancia);
            Controls.Add(cmbCategoria);
            Controls.Add(lblTitulo);
            Controls.Add(txtStock);
            Controls.Add(lblStock);
            Controls.Add(txtPrecio);
            Controls.Add(lblPrecio);
            Controls.Add(lblCategoria);
            Controls.Add(txtNombre);
            Controls.Add(pcbEditar);
            Controls.Add(btnGuardar);
            Controls.Add(lblNombre);
            Font = new Font("Segoe UI", 12F);
            Name = "frmInventarioEdicion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editar Inventario";
            ((System.ComponentModel.ISupportInitialize)pcbEditar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnGuardar;
        private PictureBox pcbEditar;
        private TextBox txtNombre;
        private Label lblCategoria;
        private TextBox txtPrecio;
        private Label lblPrecio;
        private TextBox txtStock;
        private Label lblStock;
        private Label lblTitulo;
        private ComboBox cmbCategoria;
        private TextBox txtMargenGanancia;
        private Label lblMargenGanancia;
        private TextBox txtPrecioVenta;
        private Label lblPrecioVenta;
        private TextBox txtCodigo;
        private Label lblCodigo;
    }
}