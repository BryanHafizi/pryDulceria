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
            dgvProvedores.Anchor = AnchorStyles.Bottom;
            dgvProvedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProvedores.BackgroundColor = SystemColors.ActiveBorder;
            dgvProvedores.BorderStyle = BorderStyle.None;
            dgvProvedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProvedores.Location = new Point(201, 84);
            dgvProvedores.Margin = new Padding(3, 2, 3, 2);
            dgvProvedores.Name = "dgvProvedores";
            dgvProvedores.ReadOnly = true;
            dgvProvedores.RowHeadersVisible = false;
            dgvProvedores.RowHeadersWidth = 51;
            dataGridViewCellStyle1.Padding = new Padding(3);
            dgvProvedores.RowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvProvedores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProvedores.Size = new Size(708, 471);
            dgvProvedores.TabIndex = 35;
            // 
            // txtBuscar
            // 
            txtBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtBuscar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscar.Location = new Point(201, 51);
            txtBuscar.Margin = new Padding(3, 2, 3, 2);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Buscar Proveedores";
            txtBuscar.Size = new Size(709, 29);
            txtBuscar.TabIndex = 34;
            // 
            // pbProveedores
            // 
            pbProveedores.AccessibleRole = AccessibleRole.None;
            pbProveedores.Image = Properties.Resources.Code_Generated_Image__1_;
            pbProveedores.Location = new Point(224, 0);
            pbProveedores.Margin = new Padding(3, 2, 3, 2);
            pbProveedores.Name = "pbProveedores";
            pbProveedores.Size = new Size(88, 47);
            pbProveedores.SizeMode = PictureBoxSizeMode.StretchImage;
            pbProveedores.TabIndex = 33;
            pbProveedores.TabStop = false;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnEliminar.BackColor = Color.FromArgb(240, 128, 128);
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(703, 559);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(131, 38);
            btnEliminar.TabIndex = 29;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Bottom;
            btnEditar.BackColor = Color.HotPink;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.ForeColor = Color.White;
            btnEditar.Location = new Point(498, 559);
            btnEditar.Margin = new Padding(3, 2, 3, 2);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(131, 38);
            btnEditar.TabIndex = 30;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnNuevo
            // 
            btnNuevo.Anchor = AnchorStyles.Bottom;
            btnNuevo.BackColor = Color.HotPink;
            btnNuevo.FlatStyle = FlatStyle.Flat;
            btnNuevo.ForeColor = Color.White;
            btnNuevo.Location = new Point(268, 559);
            btnNuevo.Margin = new Padding(3, 2, 3, 2);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(131, 38);
            btnNuevo.TabIndex = 31;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = SystemColors.ControlText;
            lblTitulo.Location = new Point(22, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(208, 45);
            lblTitulo.TabIndex = 32;
            lblTitulo.Text = "Proveedores";
            // 
            // frmProveedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(1086, 574);
            Controls.Add(dgvProvedores);
            Controls.Add(txtBuscar);
            Controls.Add(pbProveedores);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnNuevo);
            Controls.Add(lblTitulo);
            Name = "frmProveedores";
            Text = "frmProveedores";
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