namespace pryDulceria
{
    partial class frmCategorias
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
            lblTitulo = new Label();
            dgvCategorias = new DataGridView();
            txtBuscar = new TextBox();
            btnNuevo = new Button();
            btnEliminar = new Button();
            lblNombre = new Label();
            txtNombre = new TextBox();
            btnGuardar = new Button();
            pcbBuscar = new PictureBox();
            lblListaCategoria = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbBuscar).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.Black;
            lblTitulo.Location = new Point(10, 7);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(179, 45);
            lblTitulo.TabIndex = 16;
            lblTitulo.Text = "Categorías";
            // 
            // dgvCategorias
            // 
            dgvCategorias.AllowUserToAddRows = false;
            dgvCategorias.AllowUserToDeleteRows = false;
            dgvCategorias.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvCategorias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCategorias.BackgroundColor = Color.White;
            dgvCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategorias.Location = new Point(525, 94);
            dgvCategorias.Margin = new Padding(3, 2, 3, 2);
            dgvCategorias.Name = "dgvCategorias";
            dgvCategorias.ReadOnly = true;
            dgvCategorias.RowHeadersVisible = false;
            dgvCategorias.RowHeadersWidth = 51;
            dataGridViewCellStyle1.Padding = new Padding(3);
            dgvCategorias.RowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvCategorias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategorias.Size = new Size(569, 300);
            dgvCategorias.TabIndex = 40;
            dgvCategorias.CellClick += dgvCategorias_CellClick;
            // 
            // txtBuscar
            // 
            txtBuscar.BorderStyle = BorderStyle.FixedSingle;
            txtBuscar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscar.Location = new Point(561, 64);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Buscar categoria";
            txtBuscar.Size = new Size(438, 29);
            txtBuscar.TabIndex = 30;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = Color.FromArgb(30, 41, 59);
            btnNuevo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnNuevo.ForeColor = Color.White;
            btnNuevo.Location = new Point(22, 66);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(131, 38);
            btnNuevo.TabIndex = 31;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(108, 117, 125);
            btnEliminar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(178, 66);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(131, 38);
            btnEliminar.TabIndex = 33;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(22, 140);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(183, 21);
            lblNombre.TabIndex = 34;
            lblNombre.Text = "Nombre de la Categoría: ";
            // 
            // txtNombre
            // 
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(229, 140);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(228, 29);
            txtNombre.TabIndex = 35;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(30, 41, 59);
            btnGuardar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(135, 213);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(131, 38);
            btnGuardar.TabIndex = 36;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // pcbBuscar
            // 
            pcbBuscar.Image = Properties.Resources.buscar;
            pcbBuscar.Location = new Point(525, 63);
            pcbBuscar.Margin = new Padding(3, 2, 3, 2);
            pcbBuscar.Name = "pcbBuscar";
            pcbBuscar.Size = new Size(31, 26);
            pcbBuscar.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbBuscar.TabIndex = 37;
            pcbBuscar.TabStop = false;
            // 
            // lblListaCategoria
            // 
            lblListaCategoria.AutoSize = true;
            lblListaCategoria.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblListaCategoria.Location = new Point(525, 19);
            lblListaCategoria.Name = "lblListaCategoria";
            lblListaCategoria.Size = new Size(196, 30);
            lblListaCategoria.TabIndex = 41;
            lblListaCategoria.Text = "Lista de categorias";
            // 
            // frmCategorias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 246, 249);
            ClientSize = new Size(1152, 452);
            Controls.Add(lblListaCategoria);
            Controls.Add(pcbBuscar);
            Controls.Add(btnGuardar);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(btnEliminar);
            Controls.Add(btnNuevo);
            Controls.Add(txtBuscar);
            Controls.Add(dgvCategorias);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmCategorias";
            Text = "Módulo de Categorías";
            Load += frmCategorias_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbBuscar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private DataGridView dgvCategorias;
        private TextBox txtBuscar;
        private Button btnNuevo;
        private Button btnEliminar;
        private Label lblNombre;
        private TextBox txtNombre;
        private Button btnGuardar;
        private PictureBox pcbBuscar;
        private Label lblListaCategoria;
    }
}