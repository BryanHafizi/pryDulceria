namespace pryDulceria
{
    partial class frmInventario
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
            txtBuscar = new TextBox();
            pcbInventario = new PictureBox();
            btnEliminar = new Button();
            btnEditar = new Button();
            btnNuevo = new Button();
            lblTitulo = new Label();
            dgvInventario = new DataGridView();
            btnCategorias = new Button();
            ((System.ComponentModel.ISupportInitialize)pcbInventario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvInventario).BeginInit();
            SuspendLayout();
            // 
            // txtBuscar
            // 
            txtBuscar.BorderStyle = BorderStyle.FixedSingle;
            txtBuscar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscar.Location = new Point(350, 33);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(600, 34);
            txtBuscar.TabIndex = 0;
            txtBuscar.Text = "Buscar Producto";
            // 
            // pcbInventario
            // 
            pcbInventario.AccessibleRole = AccessibleRole.None;
            pcbInventario.Image = Properties.Resources.Code_Generated_Image__1_;
            pcbInventario.Location = new Point(232, 13);
            pcbInventario.Name = "pcbInventario";
            pcbInventario.Size = new Size(100, 50);
            pcbInventario.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbInventario.TabIndex = 19;
            pcbInventario.TabStop = false;
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
            lblTitulo.Size = new Size(217, 54);
            lblTitulo.TabIndex = 17;
            lblTitulo.Text = "Inventario";
            // 
            // dgvInventario
            // 
            dgvInventario.AllowUserToAddRows = false;
            dgvInventario.AllowUserToDeleteRows = false;
            dgvInventario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvInventario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInventario.BackgroundColor = Color.White;
            dgvInventario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventario.Location = new Point(350, 80);
            dgvInventario.Name = "dgvInventario";
            dgvInventario.ReadOnly = true;
            dgvInventario.RowHeadersVisible = false;
            dgvInventario.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Padding = new Padding(3);
            dgvInventario.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvInventario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInventario.Size = new Size(900, 400);
            dgvInventario.TabIndex = 4;
            // 
            // btnCategorias
            // 
            btnCategorias.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCategorias.BackColor = Color.LightCoral;
            btnCategorias.FlatStyle = FlatStyle.Flat;
            btnCategorias.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCategorias.ForeColor = Color.White;
            btnCategorias.Location = new Point(1100, 500);
            btnCategorias.Name = "btnCategorias";
            btnCategorias.Size = new Size(150, 50);
            btnCategorias.TabIndex = 20;
            btnCategorias.Text = "Categorías";
            btnCategorias.UseVisualStyleBackColor = false;
            btnCategorias.Click += btnCategorias_Click;
            // 
            // frmInventario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 242, 245);
            ClientSize = new Size(1316, 603);
            ControlBox = false;
            Controls.Add(btnCategorias);
            Controls.Add(dgvInventario);
            Controls.Add(txtBuscar);
            Controls.Add(pcbInventario);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnNuevo);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmInventario";
            Text = "frmInventario";
            ((System.ComponentModel.ISupportInitialize)pcbInventario).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvInventario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBuscar;
        private PictureBox pcbInventario;
        private Button btnEliminar;
        private Button btnEditar;
        private Button btnNuevo;
        private Label lblTitulo;
        private DataGridView dgvInventario;
        private Button btnCategorias;
    }
}