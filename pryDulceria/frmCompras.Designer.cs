namespace pryDulceria
{
    partial class frmCompras
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCompras));
            dgvCompras = new DataGridView();
            btnEditar = new Button();
            txtBuscar = new TextBox();
            pcbCarrito = new PictureBox();
            btnCancelar = new Button();
            btnComprar = new Button();
            lblTotal = new Label();
            lblTitulo = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCompras).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbCarrito).BeginInit();
            SuspendLayout();
            // 
            // dgvCompras
            // 
            dgvCompras.AllowUserToAddRows = false;
            dgvCompras.AllowUserToDeleteRows = false;
            dgvCompras.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvCompras.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCompras.BackgroundColor = Color.White;
            dgvCompras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCompras.GridColor = SystemColors.WindowText;
            dgvCompras.Location = new Point(320, 80);
            dgvCompras.Margin = new Padding(3, 2, 3, 2);
            dgvCompras.Name = "dgvCompras";
            dgvCompras.ReadOnly = true;
            dgvCompras.RowHeadersVisible = false;
            dgvCompras.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Padding = new Padding(3);
            dgvCompras.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvCompras.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCompras.Size = new Size(900, 400);
            dgvCompras.TabIndex = 38;
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEditar.BackColor = Color.FromArgb(194, 24, 91);
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnEditar.ForeColor = Color.White;
            btnEditar.Location = new Point(480, 525);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(150, 50);
            btnEditar.TabIndex = 37;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // txtBuscar
            // 
            txtBuscar.BorderStyle = BorderStyle.FixedSingle;
            txtBuscar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscar.ForeColor = Color.FromArgb(30, 41, 59);
            txtBuscar.Location = new Point(320, 33);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(600, 34);
            txtBuscar.TabIndex = 36;
            txtBuscar.Text = "Buscar Producto";
            // 
            // pcbCarrito
            // 
            pcbCarrito.Image = (Image)resources.GetObject("pcbCarrito.Image");
            pcbCarrito.Location = new Point(200, 13);
            pcbCarrito.Name = "pcbCarrito";
            pcbCarrito.Size = new Size(100, 50);
            pcbCarrito.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbCarrito.TabIndex = 35;
            pcbCarrito.TabStop = false;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCancelar.BackColor = Color.LightCoral;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(640, 525);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(150, 50);
            btnCancelar.TabIndex = 31;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnComprar
            // 
            btnComprar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnComprar.BackColor = Color.FromArgb(194, 24, 91);
            btnComprar.FlatStyle = FlatStyle.Flat;
            btnComprar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnComprar.ForeColor = Color.White;
            btnComprar.Location = new Point(320, 525);
            btnComprar.Name = "btnComprar";
            btnComprar.Size = new Size(150, 50);
            btnComprar.TabIndex = 32;
            btnComprar.Text = "Comprar";
            btnComprar.UseVisualStyleBackColor = false;
            // 
            // lblTotal
            // 
            lblTotal.Anchor = AnchorStyles.Bottom;
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(320, 490);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(180, 28);
            lblTotal.TabIndex = 33;
            lblTotal.Text = "Total a Pagar: $0.00";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(12, 13);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(190, 54);
            lblTitulo.TabIndex = 34;
            lblTitulo.Text = "Compras";
            // 
            // frmCompras
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 242, 245);
            ClientSize = new Size(1316, 603);
            Controls.Add(dgvCompras);
            Controls.Add(btnEditar);
            Controls.Add(txtBuscar);
            Controls.Add(pcbCarrito);
            Controls.Add(btnCancelar);
            Controls.Add(btnComprar);
            Controls.Add(lblTotal);
            Controls.Add(lblTitulo);
            Name = "frmCompras";
            Text = "frmCompras";
            ((System.ComponentModel.ISupportInitialize)dgvCompras).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbCarrito).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCompras;
        private Button btnEditar;
        private TextBox txtBuscar;
        private PictureBox pcbCarrito;
        private Button btnCancelar;
        private Button btnComprar;
        private Label lblTotal;
        private Label lblTitulo;
    }
}