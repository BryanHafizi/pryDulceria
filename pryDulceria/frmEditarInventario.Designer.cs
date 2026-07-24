namespace pryDulceria
{
    partial class frmEditarInventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditarInventario));
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
            ((System.ComponentModel.ISupportInitialize)pcbEditar).BeginInit();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombre.ForeColor = Color.Black;
            lblNombre.Location = new Point(20, 110);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(207, 28);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "Nombre del Producto:";
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(194, 24, 91);
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(300, 330);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(150, 50);
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // pcbEditar
            // 
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
            txtNombre.Location = new Point(260, 110);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(260, 34);
            txtNombre.TabIndex = 6;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCategoria.ForeColor = Color.Black;
            lblCategoria.Location = new Point(20, 160);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(219, 28);
            lblCategoria.TabIndex = 7;
            lblCategoria.Text = "Categoría del Producto:";
            // 
            // txtPrecio
            // 
            txtPrecio.BorderStyle = BorderStyle.FixedSingle;
            txtPrecio.ForeColor = Color.Black;
            txtPrecio.Location = new Point(260, 210);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(260, 34);
            txtPrecio.TabIndex = 12;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrecio.ForeColor = Color.Black;
            lblPrecio.Location = new Point(20, 210);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(188, 28);
            lblPrecio.TabIndex = 11;
            lblPrecio.Text = "Precio del Producto:";
            // 
            // txtStock
            // 
            txtStock.BorderStyle = BorderStyle.FixedSingle;
            txtStock.ForeColor = Color.Black;
            txtStock.Location = new Point(260, 260);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(260, 34);
            txtStock.TabIndex = 14;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStock.ForeColor = Color.Black;
            lblStock.Location = new Point(20, 260);
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
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(260, 160);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(260, 36);
            cmbCategoria.TabIndex = 16;
            // 
            // frmEditarInventario
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 242, 245);
            ClientSize = new Size(632, 453);
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
            Name = "frmEditarInventario";
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
    }
}