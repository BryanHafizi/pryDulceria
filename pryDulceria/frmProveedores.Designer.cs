namespace pryDulceria
{
    partial class frmProveedores
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dgvProvedores = new DataGridView();
            txtBuscar = new TextBox();
            pbProveedores = new PictureBox();
            btnEliminar = new Button();
            btnEditar = new Button();
            btnNuevo = new Button();
            lblTitulo = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProvedores).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbProveedores).BeginInit();
            SuspendLayout();
            // 
            // dgvProvedores
            // 
            dgvProvedores.AllowUserToAddRows = false;
            dgvProvedores.AllowUserToDeleteRows = false;
            dgvProvedores.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvProvedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProvedores.BackgroundColor = Color.White;
            dgvProvedores.BorderStyle = BorderStyle.Fixed3D;
            dgvProvedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProvedores.Location = new Point(380, 80);
            dgvProvedores.Name = "dgvProvedores";
            dgvProvedores.ReadOnly = true;
            dgvProvedores.RowHeadersVisible = false;
            dgvProvedores.RowHeadersWidth = 51;
            dataGridViewCellStyle1.Padding = new Padding(3);
            dgvProvedores.RowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvProvedores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProvedores.Size = new Size(900, 400);
            dgvProvedores.TabIndex = 4;
            // 
            // txtBuscar
            // 
            txtBuscar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscar.Location = new Point(380, 33);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Buscar Proveedor";
            txtBuscar.Size = new Size(600, 34);
            txtBuscar.TabIndex = 0;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // pbProveedores
            // 
            pbProveedores.AccessibleRole = AccessibleRole.None;
            pbProveedores.Image = Properties.Resources._1782681922009;
            pbProveedores.Location = new Point(265, 13);
            pbProveedores.Name = "pbProveedores";
            pbProveedores.Size = new Size(100, 50);
            pbProveedores.SizeMode = PictureBoxSizeMode.StretchImage;
            pbProveedores.TabIndex = 33;
            pbProveedores.TabStop = false;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEliminar.BackColor = Color.FromArgb(240, 128, 128);
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 12F);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(700, 500);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(150, 50);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEditar.BackColor = Color.HotPink;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Segoe UI", 12F);
            btnEditar.ForeColor = Color.White;
            btnEditar.Location = new Point(540, 500);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(150, 50);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnNuevo.BackColor = Color.HotPink;
            btnNuevo.FlatStyle = FlatStyle.Flat;
            btnNuevo.Font = new Font("Segoe UI", 12F);
            btnNuevo.ForeColor = Color.White;
            btnNuevo.Location = new Point(380, 500);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(150, 50);
            btnNuevo.TabIndex = 1;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = SystemColors.ControlText;
            lblTitulo.Location = new Point(12, 13);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(259, 54);
            lblTitulo.TabIndex = 32;
            lblTitulo.Text = "Proveedores";
            // 
            // frmProveedores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(1316, 603);
            Controls.Add(dgvProvedores);
            Controls.Add(txtBuscar);
            Controls.Add(pbProveedores);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnNuevo);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmProveedores";
            Text = "Modulo de Proveedores";
            ((System.ComponentModel.ISupportInitialize)dgvProvedores).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbProveedores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProvedores;
        private TextBox txtBuscar;
        private PictureBox pbProveedores;
        private Button btnEliminar;
        private Button btnEditar;
        private Button btnNuevo;
        private Label lblTitulo;
    }
}