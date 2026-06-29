namespace pryDulceria

{
    partial class frmVender
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVender));
            lblTitulo = new Label();
            lblBuscar = new Label();
            dgyVenta = new DataGridView();
            clmCantidad = new DataGridViewTextBoxColumn();
            clmProducto = new DataGridViewTextBoxColumn();
            clmPrecioUni = new DataGridViewTextBoxColumn();
            clmSubtotal = new DataGridViewTextBoxColumn();
            lblTotal = new Label();
            btnCobrar = new Button();
            btnCancelar = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            txtBuscar = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgyVenta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitulo.Location = new Point(215, 36);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(102, 37);
            lblTitulo.TabIndex = 5;
            lblTitulo.Text = "Ventas";
            lblTitulo.Click += lblTitulo_Click;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Location = new Point(204, 85);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(126, 21);
            lblBuscar.TabIndex = 4;
            lblBuscar.Text = "Buscar producto:";
            // 
            // dgyVenta
            // 
            dgyVenta.BackgroundColor = Color.White;
            dgyVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgyVenta.Columns.AddRange(new DataGridViewColumn[] { clmCantidad, clmProducto, clmPrecioUni, clmSubtotal });
            dgyVenta.GridColor = Color.FromArgb(224, 176, 255);
            dgyVenta.Location = new Point(347, 117);
            dgyVenta.Name = "dgyVenta";
            dgyVenta.Size = new Size(443, 319);
            dgyVenta.TabIndex = 2;
            dgyVenta.CellContentClick += dgyVenta_CellContentClick;
            // 
            // clmCantidad
            // 
            clmCantidad.HeaderText = "Cantidad";
            clmCantidad.Name = "clmCantidad";
            // 
            // clmProducto
            // 
            clmProducto.HeaderText = "producto";
            clmProducto.Name = "clmProducto";
            // 
            // clmPrecioUni
            // 
            clmPrecioUni.HeaderText = "Precio uni.";
            clmPrecioUni.Name = "clmPrecioUni";
            // 
            // clmSubtotal
            // 
            clmSubtotal.HeaderText = "Subtotal";
            clmSubtotal.Name = "clmSubtotal";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTotal.Location = new Point(347, 453);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(219, 30);
            lblTotal.TabIndex = 2;
            lblTotal.Text = "Total a Pagar: $0.00";
            // 
            // btnCobrar
            // 
            btnCobrar.BackColor = Color.FromArgb(255, 105, 180);
            btnCobrar.FlatStyle = FlatStyle.Flat;
            btnCobrar.ForeColor = Color.White;
            btnCobrar.Location = new Point(483, 495);
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
            btnCancelar.Location = new Point(347, 498);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(100, 35);
            btnCancelar.TabIndex = 0;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(39, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(159, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Code_Generated_Image;
            pictureBox2.Location = new Point(901, 23);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(92, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.White;
            pictureBox3.Image = Properties.Resources._1782681978865;
            pictureBox3.Location = new Point(744, 82);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(44, 29);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 14;
            pictureBox3.TabStop = false;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(347, 82);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(443, 29);
            txtBuscar.TabIndex = 13;
            txtBuscar.Text = "Buscar";
            // 
            // frmVender
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 228, 225);
            ClientSize = new Size(1024, 749);
            Controls.Add(pictureBox3);
            Controls.Add(txtBuscar);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnCancelar);
            Controls.Add(btnCobrar);
            Controls.Add(lblTotal);
            Controls.Add(dgyVenta);
            Controls.Add(lblBuscar);
            Controls.Add(lblTitulo);
            Font = new Font("Segoe UI", 12F);
            Name = "frmVender";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Módulo de Facturación y Ventas";
            Load += frmVender_Load;
            ((System.ComponentModel.ISupportInitialize)dgyVenta).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.DataGridView dgyVenta;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnCobrar;
        private System.Windows.Forms.Button btnCancelar;
        private PictureBox pictureBox1;
        private DataGridViewTextBoxColumn clmCantidad;
        private DataGridViewTextBoxColumn clmProducto;
        private DataGridViewTextBoxColumn clmPrecioUni;
        private DataGridViewTextBoxColumn clmSubtotal;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private TextBox txtBuscar;
    }
}