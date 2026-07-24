namespace pryDulceria
{
    partial class frmNuevoProducto
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
            txtNombre = new TextBox();
            txtPrecio = new TextBox();
            txtCodigo = new TextBox();
            txtStock = new TextBox();
            lblNombre = new Label();
            lblCategoria = new Label();
            lblStock = new Label();
            lblPrecio = new Label();
            lblCodigo = new Label();
            lblTitulo = new Label();
            btnGuardar = new Button();
            txtCategoria = new TextBox();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Font = new Font("Segoe UI", 12F);
            txtNombre.Location = new Point(300, 100);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(260, 34);
            txtNombre.TabIndex = 0;
            // 
            // txtPrecio
            // 
            txtPrecio.BorderStyle = BorderStyle.FixedSingle;
            txtPrecio.Font = new Font("Segoe UI", 12F);
            txtPrecio.Location = new Point(300, 200);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(260, 34);
            txtPrecio.TabIndex = 1;
            // 
            // txtCodigo
            // 
            txtCodigo.BorderStyle = BorderStyle.FixedSingle;
            txtCodigo.Font = new Font("Segoe UI", 12F);
            txtCodigo.Location = new Point(300, 250);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(260, 34);
            txtCodigo.TabIndex = 2;
            // 
            // txtStock
            // 
            txtStock.BorderStyle = BorderStyle.FixedSingle;
            txtStock.Font = new Font("Segoe UI", 12F);
            txtStock.Location = new Point(300, 300);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(260, 34);
            txtStock.TabIndex = 3;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombre.ForeColor = Color.Black;
            lblNombre.Location = new Point(50, 100);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(207, 28);
            lblNombre.TabIndex = 5;
            lblNombre.Text = "Nombre del Producto:";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCategoria.ForeColor = Color.Black;
            lblCategoria.Location = new Point(50, 150);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(219, 28);
            lblCategoria.TabIndex = 8;
            lblCategoria.Text = "Categoria del Producto:";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStock.ForeColor = Color.Black;
            lblStock.Location = new Point(50, 300);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(182, 28);
            lblStock.TabIndex = 14;
            lblStock.Text = "Stock del Producto:";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrecio.ForeColor = Color.Black;
            lblPrecio.Location = new Point(50, 250);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(188, 28);
            lblPrecio.TabIndex = 15;
            lblPrecio.Text = "Precio del Producto:";
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCodigo.ForeColor = Color.Black;
            lblCodigo.Location = new Point(50, 200);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(199, 28);
            lblCodigo.TabIndex = 16;
            lblCodigo.Text = "Codigo del Producto:";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.Black;
            lblTitulo.Location = new Point(12, 13);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(524, 54);
            lblTitulo.TabIndex = 17;
            lblTitulo.Text = "Agregar nuevos productos";
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(194, 24, 91);
            btnGuardar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = SystemColors.ControlLightLight;
            btnGuardar.Location = new Point(350, 350);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(150, 50);
            btnGuardar.TabIndex = 18;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtCategoria
            // 
            txtCategoria.BorderStyle = BorderStyle.FixedSingle;
            txtCategoria.Font = new Font("Segoe UI", 12F);
            txtCategoria.Location = new Point(300, 150);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(260, 34);
            txtCategoria.TabIndex = 19;
            // 
            // frmNuevoProducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 242, 245);
            ClientSize = new Size(632, 453);
            Controls.Add(txtCategoria);
            Controls.Add(btnGuardar);
            Controls.Add(lblTitulo);
            Controls.Add(lblCodigo);
            Controls.Add(lblPrecio);
            Controls.Add(lblStock);
            Controls.Add(lblCategoria);
            Controls.Add(lblNombre);
            Controls.Add(txtStock);
            Controls.Add(txtCodigo);
            Controls.Add(txtPrecio);
            Controls.Add(txtNombre);
            Name = "frmNuevoProducto";
            Text = "frmNuevoProducto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtPrecio;
        private TextBox txtCodigo;
        private TextBox txtStock;
        private Label lblNombre;
        private Label lblCategoria;
        private Label lblStock;
        private Label lblPrecio;
        private Label lblCodigo;
        private Label lblTitulo;
        private Button btnGuardar;
        private TextBox txtCategoria;
    }
}