namespace pryDulceria
{
    partial class frmUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuarios));
            dgvUsuarios = new DataGridView();
            txtBuscar = new TextBox();
            pcbUsuarios = new PictureBox();
            btnEliminar = new Button();
            btnEditar = new Button();
            btnNuevo = new Button();
            lblTitulo = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbUsuarios).BeginInit();
            SuspendLayout();
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.AllowUserToAddRows = false;
            dgvUsuarios.AllowUserToDeleteRows = false;
            dgvUsuarios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsuarios.BackgroundColor = Color.White;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new Point(350, 80);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.RowHeadersVisible = false;
            dgvUsuarios.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Padding = new Padding(3);
            dgvUsuarios.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuarios.Size = new Size(900, 400);
            dgvUsuarios.TabIndex = 4;
            // 
            // txtBuscar
            // 
            txtBuscar.BorderStyle = BorderStyle.FixedSingle;
            txtBuscar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscar.Location = new Point(350, 33);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Buscar usuario";
            txtBuscar.Size = new Size(600, 34);
            txtBuscar.TabIndex = 0;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // pcbUsuarios
            // 
            pcbUsuarios.AccessibleRole = AccessibleRole.None;
            pcbUsuarios.Image = (Image)resources.GetObject("pcbUsuarios.Image");
            pcbUsuarios.Location = new Point(200, 13);
            pcbUsuarios.Name = "pcbUsuarios";
            pcbUsuarios.Size = new Size(101, 51);
            pcbUsuarios.SizeMode = PictureBoxSizeMode.Zoom;
            pcbUsuarios.TabIndex = 26;
            pcbUsuarios.TabStop = false;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEliminar.BackColor = Color.LightCoral;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(670, 500);
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
            btnEditar.BackColor = Color.FromArgb(194, 24, 91);
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnEditar.ForeColor = Color.White;
            btnEditar.Location = new Point(510, 500);
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
            btnNuevo.BackColor = Color.FromArgb(194, 24, 91);
            btnNuevo.FlatStyle = FlatStyle.Flat;
            btnNuevo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnNuevo.ForeColor = Color.White;
            btnNuevo.Location = new Point(350, 500);
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
            lblTitulo.Size = new Size(185, 54);
            lblTitulo.TabIndex = 25;
            lblTitulo.Text = "Usuarios";
            // 
            // frmUsuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 242, 245);
            ClientSize = new Size(1316, 603);
            Controls.Add(dgvUsuarios);
            Controls.Add(txtBuscar);
            Controls.Add(pcbUsuarios);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnNuevo);
            Controls.Add(lblTitulo);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmUsuarios";
            Text = "Módulo de Usuarios";
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvUsuarios;
        private TextBox txtBuscar;
        private PictureBox pcbUsuarios;
        private Button btnEliminar;
        private Button btnEditar;
        private Button btnNuevo;
        private Label lblTitulo;
    }
}