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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
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
            lblTitulo.Location = new Point(12, 13);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(224, 54);
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
            dgvCategorias.Location = new Point(604, 126);
            dgvCategorias.Name = "dgvCategorias";
            dgvCategorias.ReadOnly = true;
            dgvCategorias.RowHeadersVisible = false;
            dgvCategorias.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Padding = new Padding(3);
            dgvCategorias.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvCategorias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategorias.Size = new Size(648, 361);
            dgvCategorias.TabIndex = 40;
            dgvCategorias.CellContentClick += dgvCategorias_CellContentClick;
            // 
            // txtBuscar
            // 
            txtBuscar.BorderStyle = BorderStyle.FixedSingle;
            txtBuscar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscar.Location = new Point(640, 86);
            txtBuscar.Margin = new Padding(3, 4, 3, 4);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Buscar categoria";
            txtBuscar.Size = new Size(464, 34);
            txtBuscar.TabIndex = 30;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = Color.FromArgb(194, 24, 91);
            btnNuevo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnNuevo.ForeColor = Color.White;
            btnNuevo.Location = new Point(60, 77);
            btnNuevo.Margin = new Padding(3, 4, 3, 4);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(150, 50);
            btnNuevo.TabIndex = 31;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.LightCoral;
            btnEliminar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(410, 77);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(150, 50);
            btnEliminar.TabIndex = 33;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(60, 199);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(231, 28);
            lblNombre.TabIndex = 34;
            lblNombre.Text = "Nombre de la Categoría: ";
            // 
            // txtNombre
            // 
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(297, 199);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(263, 34);
            txtNombre.TabIndex = 35;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(194, 24, 91);
            btnGuardar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(238, 437);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(150, 50);
            btnGuardar.TabIndex = 36;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // pcbBuscar
            // 
            pcbBuscar.Image = Properties.Resources.buscar;
            pcbBuscar.Location = new Point(604, 86);
            pcbBuscar.Name = "pcbBuscar";
            pcbBuscar.Size = new Size(30, 34);
            pcbBuscar.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbBuscar.TabIndex = 37;
            pcbBuscar.TabStop = false;
            // 
            // lblListaCategoria
            // 
            lblListaCategoria.AutoSize = true;
            lblListaCategoria.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblListaCategoria.Location = new Point(604, 55);
            lblListaCategoria.Name = "lblListaCategoria";
            lblListaCategoria.Size = new Size(177, 28);
            lblListaCategoria.TabIndex = 41;
            lblListaCategoria.Text = "Lista de categorias:";
            // 
            // frmCategorias
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 242, 245);
            ClientSize = new Size(1316, 603);
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
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmCategorias";
            Text = "Módulo de Categorías";
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