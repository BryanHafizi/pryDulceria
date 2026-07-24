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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            lblTitulo = new Label();
            lblTotal = new Label();
            btnCobrar = new Button();
            btnCancelar = new Button();
            pcbCarrito = new PictureBox();
            txtBuscar = new TextBox();
            btnEditar = new Button();
            dgvVentas = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pcbCarrito).BeginInit();
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
            lblTotal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(300, 490);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(180, 28);
            lblTotal.TabIndex = 2;
            lblTotal.Text = "Total a Pagar: $0.00";
            // 
            // btnCobrar
            // 
            btnCobrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCobrar.BackColor = Color.FromArgb(194, 24, 91);
            btnCobrar.FlatStyle = FlatStyle.Flat;
            btnCobrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
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
            btnCancelar.BackColor = Color.LightCoral;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(620, 530);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(150, 50);
            btnCancelar.TabIndex = 0;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // pcbCarrito
            // 
            pcbCarrito.Image = Properties.Resources.Code_Generated_Image;
            pcbCarrito.Location = new Point(167, 13);
            pcbCarrito.Name = "pcbCarrito";
            pcbCarrito.Size = new Size(100, 50);
            pcbCarrito.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbCarrito.TabIndex = 7;
            pcbCarrito.TabStop = false;
            // 
            // txtBuscar
            // 
            txtBuscar.BorderStyle = BorderStyle.FixedSingle;
            txtBuscar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscar.ForeColor = Color.FromArgb(30, 41, 59);
            txtBuscar.Location = new Point(300, 33);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(600, 34);
            txtBuscar.TabIndex = 13;
            txtBuscar.Text = "Buscar Producto";
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEditar.BackColor = Color.FromArgb(194, 24, 91);
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
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
            dgvVentas.BackgroundColor = Color.White;
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVentas.GridColor = SystemColors.WindowText;
            dgvVentas.Location = new Point(300, 80);
            dgvVentas.Margin = new Padding(3, 2, 3, 2);
            dgvVentas.Name = "dgvVentas";
            dgvVentas.ReadOnly = true;
            dgvVentas.RowHeadersVisible = false;
            dgvVentas.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Padding = new Padding(3);
            dgvVentas.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVentas.Size = new Size(900, 400);
            dgvVentas.TabIndex = 30;
            // 
            // frmVentas
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 242, 245);
            ClientSize = new Size(1316, 603);
            ControlBox = false;
            Controls.Add(dgvVentas);
            Controls.Add(btnEditar);
            Controls.Add(txtBuscar);
            Controls.Add(pcbCarrito);
            Controls.Add(btnCancelar);
            Controls.Add(btnCobrar);
            Controls.Add(lblTotal);
            Controls.Add(lblTitulo);
            Font = new Font("Segoe UI", 12F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmVentas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Módulo de Facturación y Ventas";
            ((System.ComponentModel.ISupportInitialize)pcbCarrito).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnCobrar;
        private System.Windows.Forms.Button btnCancelar;
        private PictureBox pcbCarrito;
        private TextBox txtBuscar;
        private Button btnEditar;
        private DataGridView dgvVentas;
    }
}