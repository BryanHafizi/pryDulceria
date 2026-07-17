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
            lblCategoriaProducto = new Label();
            lblStock = new Label();
            lblPrecioProducto = new Label();
            lblCodigoProducto = new Label();
            lblTitulo = new Label();
            btnGuardar = new Button();
            txtCategoriaProducto = new TextBox();
            SuspendLayout();
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Font = new Font("Segoe UI", 12F);
            txtNombreProducto.Location = new Point(300, 100);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(260, 34);
            txtNombreProducto.TabIndex = 0;
            // 
            // txtPrecioProducto
            // 
            txtPrecioProducto.Font = new Font("Segoe UI", 12F);
            txtPrecioProducto.Location = new Point(300, 280);
            txtPrecioProducto.Name = "txtPrecioProducto";
            txtPrecioProducto.Size = new Size(260, 34);
            txtPrecioProducto.TabIndex = 1;
            // 
            // txtCodigoProducto
            // 
            txtCodigoProducto.Font = new Font("Segoe UI", 12F);
            txtCodigoProducto.Location = new Point(300, 220);
            txtCodigoProducto.Name = "txtCodigoProducto";
            txtCodigoProducto.Size = new Size(260, 34);
            txtCodigoProducto.TabIndex = 2;
            // 
            // txtStock
            // 
            txtStock.Font = new Font("Segoe UI", 12F);
            txtStock.Location = new Point(300, 340);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(260, 34);
            txtStock.TabIndex = 3;
            // 
            // lblNombreProducto
            // 
            lblNombreProducto.AutoSize = true;
            lblNombreProducto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombreProducto.ForeColor = Color.Black;
            lblNombreProducto.Location = new Point(50, 100);
            lblNombreProducto.Name = "lblNombreProducto";
            lblNombreProducto.Size = new Size(207, 28);
            lblNombreProducto.TabIndex = 5;
            lblNombreProducto.Text = "Nombre del Producto:";
            // 
            // lblCategoriaProducto
            // 
            lblCategoriaProducto.AutoSize = true;
            lblCategoriaProducto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCategoriaProducto.ForeColor = Color.Black;
            lblCategoriaProducto.Location = new Point(50, 160);
            lblCategoriaProducto.Name = "lblCategoriaProducto";
            lblCategoriaProducto.Size = new Size(219, 28);
            lblCategoriaProducto.TabIndex = 8;
            lblCategoriaProducto.Text = "Categoria del Producto:";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStock.ForeColor = Color.Black;
            lblStock.Location = new Point(50, 340);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(182, 28);
            lblStock.TabIndex = 14;
            lblStock.Text = "Stock del Producto:";
            // 
            // lblPrecioProducto
            // 
            lblPrecioProducto.AutoSize = true;
            lblPrecioProducto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrecioProducto.ForeColor = Color.Black;
            lblPrecioProducto.Location = new Point(50, 280);
            lblPrecioProducto.Name = "lblPrecioProducto";
            lblPrecioProducto.Size = new Size(188, 28);
            lblPrecioProducto.TabIndex = 15;
            lblPrecioProducto.Text = "Precio del Producto:";
            // 
            // lblCodigoProducto
            // 
            lblCodigoProducto.AutoSize = true;
            lblCodigoProducto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCodigoProducto.ForeColor = Color.Black;
            lblCodigoProducto.Location = new Point(50, 220);
            lblCodigoProducto.Name = "lblCodigoProducto";
            lblCodigoProducto.Size = new Size(199, 28);
            lblCodigoProducto.TabIndex = 16;
            lblCodigoProducto.Text = "Codigo del Producto:";
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
            btnGuardar.BackColor = Color.HotPink;
            btnGuardar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = SystemColors.ControlLightLight;
            btnGuardar.Location = new Point(360, 400);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(150, 50);
            btnGuardar.TabIndex = 18;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtCategoriaProducto
            // 
            txtCategoriaProducto.Font = new Font("Segoe UI", 12F);
            txtCategoriaProducto.Location = new Point(300, 160);
            txtCategoriaProducto.Name = "txtCategoriaProducto";
            txtCategoriaProducto.Size = new Size(260, 34);
            txtCategoriaProducto.TabIndex = 19;
            // 
            // frmNuevoProducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(782, 553);
            Controls.Add(txtCategoriaProducto);
            Controls.Add(btnGuardar);
            Controls.Add(lblTitulo);
            Controls.Add(lblCodigoProducto);
            Controls.Add(lblPrecioProducto);
            Controls.Add(lblStock);
            Controls.Add(lblCategoriaProducto);
            Controls.Add(lblNombreProducto);
            Controls.Add(txtStock);
            Controls.Add(txtCodigoProducto);
            Controls.Add(txtPrecioProducto);
            Controls.Add(txtNombreProducto);
            Name = "frmNuevoProducto";
            Text = "Módulo para Agregar Productos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombreProducto;
        private TextBox txtPrecioProducto;
        private TextBox txtCodigoProducto;
        private TextBox txtStock;
        private Label lblNombreProducto;
        private Label lblCategoriaProducto;
        private Label lblStock;
        private Label lblPrecioProducto;
        private Label lblCodigoProducto;
        private Label lblTitulo;
        private Button btnGuardar;
        private TextBox txtCategoriaProducto;
    }
}