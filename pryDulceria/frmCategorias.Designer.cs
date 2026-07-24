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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            lblTitulo = new Label();
            dgvCategorias = new DataGridView();
            txtBuscar = new TextBox();
            btnGuardar = new Button();
            btnEliminar = new Button();
            lblNombre = new Label();
            txtNombre = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).BeginInit();
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
            dgvCategorias.Location = new Point(60, 200);
            dgvCategorias.Name = "dgvCategorias";
            dgvCategorias.ReadOnly = true;
            dgvCategorias.RowHeadersVisible = false;
            dgvCategorias.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Padding = new Padding(3);
            dgvCategorias.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvCategorias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategorias.Size = new Size(500, 200);
            dgvCategorias.TabIndex = 29;
            dgvCategorias.CellContentClick += dgvCategorias_CellContentClick;
            // 
            // txtBuscar
            // 
            txtBuscar.BorderStyle = BorderStyle.FixedSingle;
            txtBuscar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscar.Location = new Point(60, 150);
            txtBuscar.Margin = new Padding(3, 4, 3, 4);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(200, 34);
            txtBuscar.TabIndex = 30;
            txtBuscar.Text = "Buscar Categoria";
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(194, 24, 91);
            btnGuardar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(60, 420);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(150, 50);
            btnGuardar.TabIndex = 31;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnNuevo_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.LightCoral;
            btnEliminar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(220, 420);
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
            lblNombre.Location = new Point(50, 100);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(231, 28);
            lblNombre.TabIndex = 34;
            lblNombre.Text = "Nombre de la Categoría: ";
            // 
            // txtNombre
            // 
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(300, 100);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(200, 34);
            txtNombre.TabIndex = 35;
            // 
            // frmCategorias
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 242, 245);
            ClientSize = new Size(632, 603);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(txtBuscar);
            Controls.Add(dgvCategorias);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmCategorias";
            Text = "Módulo de Categorías";
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private DataGridView dgvCategorias;
        private TextBox txtBuscar;
        private Button btnGuardar;
        private Button btnEliminar;
        private Label lblNombre;
        private TextBox txtNombre;
    }
}