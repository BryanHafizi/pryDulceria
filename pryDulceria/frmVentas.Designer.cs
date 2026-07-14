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
            lblTitulo = new Label();
            dgvVentas = new DataGridView();
            clmCantidad = new DataGridViewTextBoxColumn();
            clmProducto = new DataGridViewTextBoxColumn();
            clmPrecioUni = new DataGridViewTextBoxColumn();
            clmSubtotal = new DataGridViewTextBoxColumn();
            lblTotal = new Label();
            btnCobrar = new Button();
            btnCancelar = new Button();
            pbCarrito = new PictureBox();
            txtBuscar = new TextBox();
            btnEditar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbCarrito).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(12, 13);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(118, 45);
            lblTitulo.TabIndex = 5;
            lblTitulo.Text = "Ventas";
            // 
            // dgvVentas
            // 
            dgvVentas.BackgroundColor = Color.White;
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVentas.Columns.AddRange(new DataGridViewColumn[] { clmCantidad, clmProducto, clmPrecioUni, clmSubtotal });
            dgvVentas.GridColor = Color.FromArgb(224, 176, 255);
            dgvVentas.Location = new Point(300, 90);
            dgvVentas.Name = "dgvVentas";
            dgvVentas.RowHeadersWidth = 51;
            dgvVentas.Size = new Size(550, 400);
            dgvVentas.TabIndex = 2;
            // 
            // clmCantidad
            // 
            clmCantidad.HeaderText = "Cantidad";
            clmCantidad.MinimumWidth = 6;
            clmCantidad.Name = "clmCantidad";
            clmCantidad.Width = 125;
            // 
            // clmProducto
            // 
            clmProducto.HeaderText = "producto";
            clmProducto.MinimumWidth = 6;
            clmProducto.Name = "clmProducto";
            clmProducto.Width = 125;
            // 
            // clmPrecioUni
            // 
            clmPrecioUni.HeaderText = "Precio uni.";
            clmPrecioUni.MinimumWidth = 6;
            clmPrecioUni.Name = "clmPrecioUni";
            clmPrecioUni.Width = 125;
            // 
            // clmSubtotal
            // 
            clmSubtotal.HeaderText = "Subtotal";
            clmSubtotal.MinimumWidth = 6;
            clmSubtotal.Name = "clmSubtotal";
            clmSubtotal.Width = 125;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(300, 500);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(158, 21);
            lblTotal.TabIndex = 2;
            lblTotal.Text = "Total a Pagar: $0.00";
            // 
            // btnCobrar
            // 
            btnCobrar.BackColor = Color.FromArgb(255, 105, 180);
            btnCobrar.FlatStyle = FlatStyle.Flat;
            btnCobrar.ForeColor = Color.White;
            btnCobrar.Location = new Point(300, 535);
            btnCobrar.Name = "btnCobrar";
            btnCobrar.Size = new Size(150, 50);
            btnCobrar.TabIndex = 1;
            btnCobrar.Text = "Cobrar";
            btnCobrar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(240, 128, 128);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(620, 535);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(150, 50);
            btnCancelar.TabIndex = 0;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // pbCarrito
            // 
            pbCarrito.Image = Properties.Resources.Code_Generated_Image;
            pbCarrito.Location = new Point(167, 13);
            pbCarrito.Name = "pbCarrito";
            pbCarrito.Size = new Size(100, 50);
            pbCarrito.SizeMode = PictureBoxSizeMode.StretchImage;
            pbCarrito.TabIndex = 7;
            pbCarrito.TabStop = false;
            pbCarrito.Click += pictureBox2_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscar.Location = new Point(300, 50);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(550, 29);
            txtBuscar.TabIndex = 13;
            txtBuscar.Text = "Buscar Producto";
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(255, 105, 180);
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.ForeColor = Color.White;
            btnEditar.Location = new Point(460, 535);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(150, 50);
            btnEditar.TabIndex = 15;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // frmVentas
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 228, 225);
            ClientSize = new Size(982, 603);
            ControlBox = false;
            Controls.Add(btnEditar);
            Controls.Add(txtBuscar);
            Controls.Add(pbCarrito);
            Controls.Add(btnCancelar);
            Controls.Add(btnCobrar);
            Controls.Add(lblTotal);
            Controls.Add(dgvVentas);
            Controls.Add(lblTitulo);
            Font = new Font("Segoe UI", 12F);
            Name = "frmVentas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Módulo de Facturación y Ventas";
            Load += frmVender_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbCarrito).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnCobrar;
        private System.Windows.Forms.Button btnCancelar;
        private DataGridViewTextBoxColumn clmCantidad;
        private DataGridViewTextBoxColumn clmProducto;
        private DataGridViewTextBoxColumn clmPrecioUni;
        private DataGridViewTextBoxColumn clmSubtotal;
        private PictureBox pbCarrito;
        private TextBox txtBuscar;
        private Button btnEditar;
    }
}