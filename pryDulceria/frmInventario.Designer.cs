namespace pryDulceria
{
    partial class frmInventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInventario));
            lblNombreProducto = new Label();
            btnGuardar = new Button();
            pbLogo = new PictureBox();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            lblCategoria = new Label();
            textBox3 = new TextBox();
            lblCodigo = new Label();
            textBox4 = new TextBox();
            lblPrecio = new Label();
            textBox5 = new TextBox();
            lblStock = new Label();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblNombreProducto
            // 
            lblNombreProducto.AutoSize = true;
            lblNombreProducto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombreProducto.Location = new Point(20, 110);
            lblNombreProducto.Name = "lblNombreProducto";
            lblNombreProducto.Size = new Size(207, 28);
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
            btnGuardar.Size = new Size(150, 40);
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // pbLogo
            // 
            pbLogo.Image = (Image)resources.GetObject("pbLogo.Image");
            pbLogo.Location = new Point(50, 40);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(150, 50);
            pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogo.TabIndex = 4;
            pbLogo.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(590, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(260, 110);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(300, 34);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(260, 160);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(300, 34);
            textBox2.TabIndex = 8;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCategoria.Location = new Point(20, 166);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(219, 28);
            lblCategoria.TabIndex = 7;
            lblCategoria.Text = "Categoria del Producto:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(260, 210);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(300, 34);
            textBox3.TabIndex = 10;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCodigo.Location = new Point(20, 216);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(199, 28);
            lblCodigo.TabIndex = 9;
            lblCodigo.Text = "Codigo del Producto:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(260, 260);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(300, 34);
            textBox4.TabIndex = 12;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrecio.Location = new Point(20, 266);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(188, 28);
            lblPrecio.TabIndex = 11;
            lblPrecio.Text = "Precio del Producto:";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(260, 310);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(300, 34);
            textBox5.TabIndex = 14;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStock.Location = new Point(20, 316);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(182, 28);
            lblStock.TabIndex = 13;
            lblStock.Text = "Stock del Producto:";
            // 
            // frmInventario
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 228, 225);
            ClientSize = new Size(782, 453);
            Controls.Add(textBox5);
            Controls.Add(lblStock);
            Controls.Add(textBox4);
            Controls.Add(lblPrecio);
            Controls.Add(textBox3);
            Controls.Add(lblCodigo);
            Controls.Add(textBox2);
            Controls.Add(lblCategoria);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Controls.Add(pbLogo);
            Controls.Add(btnGuardar);
            Controls.Add(lblNombreProducto);
            Font = new Font("Segoe UI", 12F);
            Name = "frmInventario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editar Inventario";
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private System.Windows.Forms.Label lblNombreProducto;
        private System.Windows.Forms.Button btnGuardar;
        private PictureBox pbLogo;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label lblCategoria;
        private TextBox textBox3;
        private Label lblCodigo;
        private TextBox textBox4;
        private Label lblPrecio;
        private TextBox textBox5;
        private Label lblStock;
    }
}