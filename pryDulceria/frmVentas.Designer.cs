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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            lblTitulo = new Label();
            lblTotal = new Label();
            btnCobrar = new Button();
            btnCancelar = new Button();
            pbCarrito = new PictureBox();
            txtBuscar = new TextBox();
            btnEditar = new Button();
            dgvVentas = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pbCarrito).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(12, 13);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(149, 54);
            lblTitulo.TabIndex = 5;
            lblTitulo.Text = "Ventas";
            // 
            // lblTotal
            // 
            lblTotal.Anchor = AnchorStyles.Bottom;
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(300, 490);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(201, 28);
            lblTotal.TabIndex = 2;
            lblTotal.Text = "Total a Pagar: $0.00";
            // 
            // btnCobrar
            // 
            btnCobrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCobrar.BackColor = Color.FromArgb(255, 105, 180);
            btnCobrar.FlatStyle = FlatStyle.Flat;
            btnCobrar.ForeColor = Color.White;
            btnCobrar.Location = new Point(300, 530);
            btnCobrar.Name = "btnCobrar";
            btnCobrar.Size = new Size(150, 50);
            btnCobrar.TabIndex = 1;
            btnCobrar.Text = "Cobrar";
            btnCobrar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCancelar.BackColor = Color.FromArgb(240, 128, 128);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(620, 530);
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
            txtBuscar.Location = new Point(300, 33);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(600, 34);
            txtBuscar.TabIndex = 13;
            txtBuscar.Text = "Buscar Producto";
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEditar.BackColor = Color.FromArgb(255, 105, 180);
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.ForeColor = Color.White;
            btnEditar.Location = new Point(460, 530);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(150, 50);
            btnEditar.TabIndex = 15;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // dgvVentas
            // 
            dgvVentas.AllowUserToAddRows = false;
            dgvVentas.AllowUserToDeleteRows = false;
            dgvVentas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVentas.BackgroundColor = SystemColors.ActiveBorder;
            dgvVentas.BorderStyle = BorderStyle.None;
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVentas.Location = new Point(300, 80);
            dgvVentas.Margin = new Padding(3, 2, 3, 2);
            dgvVentas.Name = "dgvVentas";
            dgvVentas.ReadOnly = true;
            dgvVentas.RowHeadersVisible = false;
            dgvVentas.RowHeadersWidth = 51;
            dataGridViewCellStyle1.Padding = new Padding(3);
            dgvVentas.RowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVentas.Size = new Size(900, 400);
            dgvVentas.TabIndex = 30;
            // 
            // frmVentas
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 228, 225);
            ClientSize = new Size(1316, 603);
            ControlBox = false;
            Controls.Add(dgvVentas);
            Controls.Add(btnEditar);
            Controls.Add(txtBuscar);
            Controls.Add(pbCarrito);
            Controls.Add(btnCancelar);
            Controls.Add(btnCobrar);
            Controls.Add(lblTotal);
            Controls.Add(lblTitulo);
            Font = new Font("Segoe UI", 12F);
            Name = "frmVentas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Módulo de Facturación y Ventas";
            Load += frmVender_Load;
            ((System.ComponentModel.ISupportInitialize)pbCarrito).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnCobrar;
        private System.Windows.Forms.Button btnCancelar;
        private PictureBox pbCarrito;
        private TextBox txtBuscar;
        private Button btnEditar;
        private DataGridView dgvVentas;
    }
}