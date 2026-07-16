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
            lblNombreProducto = new Label();
            btnGuardar = new Button();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            lblCategoria = new Label();
            textBox3 = new TextBox();
            lblCodigo = new Label();
            textBox4 = new TextBox();
            lblPrecio = new Label();
            textBox5 = new TextBox();
            lblStock = new Label();
            lblTitulo = new Label();
            comboBox1 = new ComboBox();
            pcbEditarCategoria = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbEditarCategoria).BeginInit();
            SuspendLayout();
            // 
            // lblNombreProducto
            // 
            lblNombreProducto.AutoSize = true;
            lblNombreProducto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombreProducto.ForeColor = Color.Black;
            lblNombreProducto.Location = new Point(20, 110);
            lblNombreProducto.Name = "lblNombreProducto";
            lblNombreProducto.Size = new Size(163, 21);
            lblNombreProducto.TabIndex = 3;
            lblNombreProducto.Text = "Nombre del Producto:";
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(240, 128, 128);
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(350, 380);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(150, 50);
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(440, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.ForeColor = Color.Black;
            textBox1.Location = new Point(260, 110);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(300, 29);
            textBox1.TabIndex = 6;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCategoria.ForeColor = Color.Black;
            lblCategoria.Location = new Point(20, 160);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(172, 21);
            lblCategoria.TabIndex = 7;
            lblCategoria.Text = "Categoria del Producto:";
            // 
            // textBox3
            // 
            textBox3.ForeColor = Color.Black;
            textBox3.Location = new Point(260, 210);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(300, 29);
            textBox3.TabIndex = 10;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCodigo.ForeColor = Color.Black;
            lblCodigo.Location = new Point(20, 210);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(155, 21);
            lblCodigo.TabIndex = 9;
            lblCodigo.Text = "Codigo del Producto:";
            // 
            // textBox4
            // 
            textBox4.ForeColor = Color.Black;
            textBox4.Location = new Point(260, 260);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(300, 29);
            textBox4.TabIndex = 12;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrecio.ForeColor = Color.Black;
            lblPrecio.Location = new Point(20, 260);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(148, 21);
            lblPrecio.TabIndex = 11;
            lblPrecio.Text = "Precio del Producto:";
            // 
            // textBox5
            // 
            textBox5.ForeColor = Color.Black;
            textBox5.Location = new Point(260, 310);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(300, 29);
            textBox5.TabIndex = 14;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStock.ForeColor = Color.Black;
            lblStock.Location = new Point(20, 310);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(142, 21);
            lblStock.TabIndex = 13;
            lblStock.Text = "Stock del Producto:";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.Black;
            lblTitulo.Location = new Point(12, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(337, 45);
            lblTitulo.TabIndex = 15;
            lblTitulo.Text = "Edición de Productos";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(260, 157);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(259, 29);
            comboBox1.TabIndex = 16;
            // 
            // pcbEditarCategoria
            // 
            pcbEditarCategoria.Image = (Image)resources.GetObject("pcbEditarCategoria.Image");
            pcbEditarCategoria.Location = new Point(525, 157);
            pcbEditarCategoria.Name = "pcbEditarCategoria";
            pcbEditarCategoria.Size = new Size(35, 29);
            pcbEditarCategoria.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbEditarCategoria.TabIndex = 17;
            pcbEditarCategoria.TabStop = false;
            pcbEditarCategoria.Click += pcbNuevaCategoria_Click;
            // 
            // frmEditarInventario
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 228, 225);
            ClientSize = new Size(632, 453);
            Controls.Add(pcbEditarCategoria);
            Controls.Add(comboBox1);
            Controls.Add(lblTitulo);
            Controls.Add(textBox5);
            Controls.Add(lblStock);
            Controls.Add(textBox4);
            Controls.Add(lblPrecio);
            Controls.Add(textBox3);
            Controls.Add(lblCodigo);
            Controls.Add(lblCategoria);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Controls.Add(btnGuardar);
            Controls.Add(lblNombreProducto);
            Font = new Font("Segoe UI", 12F);
            Name = "frmEditarInventario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editar Inventario";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbEditarCategoria).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private System.Windows.Forms.Label lblNombreProducto;
        private System.Windows.Forms.Button btnGuardar;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private Label lblCategoria;
        private TextBox textBox3;
        private Label lblCodigo;
        private TextBox textBox4;
        private Label lblPrecio;
        private TextBox textBox5;
        private Label lblStock;
        private Label lblTitulo;
        private ComboBox comboBox1;
        private PictureBox pcbEditarCategoria;
    }
}