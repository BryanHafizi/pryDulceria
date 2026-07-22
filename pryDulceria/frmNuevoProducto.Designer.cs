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
            txtNombreProducto = new TextBox();
            txtPrecioProducto = new TextBox();
            txtCodigoProducto = new TextBox();
            txtStock = new TextBox();
            lblNombreProducto = new Label();
            lblCategoria = new Label();
            lblStock = new Label();
            lblPrecio = new Label();
            label1 = new Label();
            lblTitulo = new Label();
            btnGuardar = new Button();
            txtCategoriaProducto = new TextBox();
            SuspendLayout();
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.BorderStyle = BorderStyle.FixedSingle;
            txtNombreProducto.Font = new Font("Segoe UI", 12F);
            txtNombreProducto.Location = new Point(283, 107);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(260, 34);
            txtNombreProducto.TabIndex = 0;
            // 
            // txtPrecioProducto
            // 
            txtPrecioProducto.BorderStyle = BorderStyle.FixedSingle;
            txtPrecioProducto.Font = new Font("Segoe UI", 12F);
            txtPrecioProducto.Location = new Point(283, 242);
            txtPrecioProducto.Name = "txtPrecioProducto";
            txtPrecioProducto.Size = new Size(260, 34);
            txtPrecioProducto.TabIndex = 1;
            // 
            // txtCodigoProducto
            // 
            txtCodigoProducto.BorderStyle = BorderStyle.FixedSingle;
            txtCodigoProducto.Font = new Font("Segoe UI", 12F);
            txtCodigoProducto.Location = new Point(283, 197);
            txtCodigoProducto.Name = "txtCodigoProducto";
            txtCodigoProducto.Size = new Size(260, 34);
            txtCodigoProducto.TabIndex = 2;
            // 
            // txtStock
            // 
            txtStock.BorderStyle = BorderStyle.FixedSingle;
            txtStock.Font = new Font("Segoe UI", 12F);
            txtStock.Location = new Point(283, 296);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(260, 34);
            txtStock.TabIndex = 3;
            // 
            // lblNombreProducto
            // 
            lblNombreProducto.AutoSize = true;
            lblNombreProducto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombreProducto.ForeColor = Color.Black;
            lblNombreProducto.Location = new Point(36, 106);
            lblNombreProducto.Name = "lblNombreProducto";
            lblNombreProducto.Size = new Size(207, 28);
            lblNombreProducto.TabIndex = 5;
            lblNombreProducto.Text = "Nombre del Producto:";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCategoria.ForeColor = Color.Black;
            lblCategoria.Location = new Point(36, 152);
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
            lblStock.Location = new Point(36, 296);
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
            lblPrecio.Location = new Point(36, 241);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(188, 28);
            lblPrecio.TabIndex = 15;
            lblPrecio.Text = "Precio del Producto:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(36, 196);
            label1.Name = "label1";
            label1.Size = new Size(199, 28);
            label1.TabIndex = 16;
            label1.Text = "Codigo del Producto:";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.Black;
            lblTitulo.Location = new Point(12, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(524, 54);
            lblTitulo.TabIndex = 17;
            lblTitulo.Text = "Agregar nuevos productos";
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(29, 53, 87);
            btnGuardar.Font = new Font("Segoe UI", 12F);
            btnGuardar.ForeColor = SystemColors.ControlLightLight;
            btnGuardar.Location = new Point(376, 353);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(150, 50);
            btnGuardar.TabIndex = 18;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtCategoriaProducto
            // 
            txtCategoriaProducto.BorderStyle = BorderStyle.FixedSingle;
            txtCategoriaProducto.Font = new Font("Segoe UI", 12F);
            txtCategoriaProducto.Location = new Point(283, 153);
            txtCategoriaProducto.Name = "txtCategoriaProducto";
            txtCategoriaProducto.Size = new Size(260, 34);
            txtCategoriaProducto.TabIndex = 19;
            // 
            // frmNuevoProducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 250, 252);
            ClientSize = new Size(782, 553);
            Controls.Add(txtCategoriaProducto);
            Controls.Add(btnGuardar);
            Controls.Add(lblTitulo);
            Controls.Add(label1);
            Controls.Add(lblPrecio);
            Controls.Add(lblStock);
            Controls.Add(lblCategoria);
            Controls.Add(lblNombreProducto);
            Controls.Add(txtStock);
            Controls.Add(txtCodigoProducto);
            Controls.Add(txtPrecioProducto);
            Controls.Add(txtNombreProducto);
            Name = "frmNuevoProducto";
            Text = "frmNuevoProducto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombreProducto;
        private TextBox txtPrecioProducto;
        private TextBox txtCodigoProducto;
        private TextBox txtStock;
        private Label lblNombreProducto;
        private Label lblCategoria;
        private Label lblStock;
        private Label lblPrecio;
        private Label label1;
        private Label lblTitulo;
        private Button btnGuardar;
        private TextBox txtCategoriaProducto;
    }
}