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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVentas));
            lblTitulo = new Label();
            dgvVentas = new DataGridView();
            clmCantidad = new DataGridViewTextBoxColumn();
            clmProducto = new DataGridViewTextBoxColumn();
            clmPrecioUni = new DataGridViewTextBoxColumn();
            clmSubtotal = new DataGridViewTextBoxColumn();
            lblTotal = new Label();
            btnCobrar = new Button();
            btnCancelar = new Button();
            pbLogo = new PictureBox();
            pbCarrito = new PictureBox();
            pbBuscar = new PictureBox();
            txtBuscar = new TextBox();
            btnEditar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbCarrito).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbBuscar).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(225, 40);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(149, 54);
            lblTitulo.TabIndex = 5;
            lblTitulo.Text = "Ventas";
            // 
            // dgvVentas
            // 
            dgvVentas.BackgroundColor = Color.White;
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVentas.Columns.AddRange(new DataGridViewColumn[] { clmCantidad, clmProducto, clmPrecioUni, clmSubtotal });
            dgvVentas.GridColor = Color.FromArgb(224, 176, 255);
            dgvVentas.Location = new Point(320, 180);
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
            lblTotal.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(320, 604);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(334, 46);
            lblTotal.TabIndex = 2;
            lblTotal.Text = "Total a Pagar: $0.00";
            // 
            // btnCobrar
            // 
            btnCobrar.BackColor = Color.FromArgb(255, 105, 180);
            btnCobrar.FlatStyle = FlatStyle.Flat;
            btnCobrar.ForeColor = Color.White;
            btnCobrar.Location = new Point(320, 669);
            btnCobrar.Name = "btnCobrar";
            btnCobrar.Size = new Size(120, 40);
            btnCobrar.TabIndex = 1;
            btnCobrar.Text = "Cobrar";
            btnCobrar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(240, 128, 128);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(620, 669);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(120, 40);
            btnCancelar.TabIndex = 0;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // pbLogo
            // 
            pbLogo.Image = (Image)resources.GetObject("pbLogo.Image");
            pbLogo.Location = new Point(50, 40);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(150, 50);
            pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogo.TabIndex = 6;
            pbLogo.TabStop = false;
            // 
            // pbCarrito
            // 
            pbCarrito.Image = Properties.Resources.Code_Generated_Image;
            pbCarrito.Location = new Point(870, 40);
            pbCarrito.Name = "pbCarrito";
            pbCarrito.Size = new Size(100, 60);
            pbCarrito.SizeMode = PictureBoxSizeMode.StretchImage;
            pbCarrito.TabIndex = 7;
            pbCarrito.TabStop = false;
            pbCarrito.Click += pictureBox2_Click;
            // 
            // pbBuscar
            // 
            pbBuscar.BackColor = Color.White;
            pbBuscar.Image = Properties.Resources._1782681978865;
            pbBuscar.Location = new Point(790, 112);
            pbBuscar.Name = "pbBuscar";
            pbBuscar.Size = new Size(30, 30);
            pbBuscar.SizeMode = PictureBoxSizeMode.StretchImage;
            pbBuscar.TabIndex = 14;
            pbBuscar.TabStop = false;
            // 
            // txtBuscar
            // 
            txtBuscar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscar.Location = new Point(380, 110);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(450, 34);
            txtBuscar.TabIndex = 13;
            txtBuscar.Text = "Buscar";
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(255, 105, 180);
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.ForeColor = Color.White;
            btnEditar.Location = new Point(470, 669);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(120, 40);
            btnEditar.TabIndex = 15;
            btnEditar.Text = "Cobrar";
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // frmVentas
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 228, 225);
            ClientSize = new Size(1006, 721);
            Controls.Add(btnEditar);
            Controls.Add(pbBuscar);
            Controls.Add(txtBuscar);
            Controls.Add(pbCarrito);
            Controls.Add(pbLogo);
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
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbCarrito).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbBuscar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnCobrar;
        private System.Windows.Forms.Button btnCancelar;
        private PictureBox pbLogo;
        private DataGridViewTextBoxColumn clmCantidad;
        private DataGridViewTextBoxColumn clmProducto;
        private DataGridViewTextBoxColumn clmPrecioUni;
        private DataGridViewTextBoxColumn clmSubtotal;
        private PictureBox pbCarrito;
        private PictureBox pbBuscar;
        private TextBox txtBuscar;
        private Button btnEditar;
    }
}