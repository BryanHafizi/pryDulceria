namespace pryDulceria
{
    partial class frmProveedores
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
            lblTitulo = new Label();
            btnNuevo = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            pictureBox1 = new PictureBox();
            dgyProveedores = new DataGridView();
            clmClave = new DataGridViewTextBoxColumn();
            clmNombreProv = new DataGridViewTextBoxColumn();
            clmEmpresa = new DataGridViewTextBoxColumn();
            clmContacto = new DataGridViewTextBoxColumn();
            lblBuscar = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            txtBuscar = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgyProveedores).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(51, 51, 51);
            lblTitulo.Location = new Point(195, 33);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(179, 37);
            lblTitulo.TabIndex = 3;
            lblTitulo.Text = "Proveedores";
            lblTitulo.Click += lblTitulo_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = Color.FromArgb(240, 128, 128);
            btnNuevo.FlatStyle = FlatStyle.Flat;
            btnNuevo.ForeColor = Color.White;
            btnNuevo.Location = new Point(338, 467);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(100, 35);
            btnNuevo.TabIndex = 2;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(240, 128, 128);
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.ForeColor = Color.White;
            btnEditar.Location = new Point(457, 467);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(100, 35);
            btnEditar.TabIndex = 1;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(240, 128, 128);
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(574, 467);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(100, 35);
            btnEliminar.TabIndex = 0;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Screenshot_2026_06_28_220345_removebg_preview;
            pictureBox1.Location = new Point(30, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(159, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // dgyProveedores
            // 
            dgyProveedores.BackgroundColor = Color.White;
            dgyProveedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgyProveedores.Columns.AddRange(new DataGridViewColumn[] { clmClave, clmNombreProv, clmEmpresa, clmContacto });
            dgyProveedores.GridColor = Color.FromArgb(224, 176, 255);
            dgyProveedores.Location = new Point(338, 118);
            dgyProveedores.Name = "dgyProveedores";
            dgyProveedores.Size = new Size(443, 319);
            dgyProveedores.TabIndex = 6;
            // 
            // clmClave
            // 
            clmClave.HeaderText = "Clave";
            clmClave.Name = "clmClave";
            // 
            // clmNombreProv
            // 
            clmNombreProv.HeaderText = "Nombre del proveedor";
            clmNombreProv.Name = "clmNombreProv";
            // 
            // clmEmpresa
            // 
            clmEmpresa.HeaderText = "Empresa";
            clmEmpresa.Name = "clmEmpresa";
            // 
            // clmContacto
            // 
            clmContacto.HeaderText = "Contacto";
            clmContacto.Name = "clmContacto";
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Location = new Point(233, 75);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(132, 21);
            lblBuscar.TabIndex = 8;
            lblBuscar.Text = "Buscar proveedor";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._1782681922009;
            pictureBox2.Location = new Point(910, 20);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(88, 58);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.White;
            pictureBox3.Image = Properties.Resources._1782681978865;
            pictureBox3.Location = new Point(741, 72);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(40, 29);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 14;
            pictureBox3.TabStop = false;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(371, 72);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(410, 29);
            txtBuscar.TabIndex = 13;
            txtBuscar.Text = "Buscar";
            // 
            // frmProveedores
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 228, 225);
            ClientSize = new Size(1024, 749);
            Controls.Add(pictureBox3);
            Controls.Add(txtBuscar);
            Controls.Add(pictureBox2);
            Controls.Add(dgyProveedores);
            Controls.Add(lblBuscar);
            Controls.Add(pictureBox1);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnNuevo);
            Controls.Add(lblTitulo);
            Font = new Font("Segoe UI", 12F);
            Name = "frmProveedores";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de Proveedores";
            Load += frmProveedores_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgyProveedores).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private PictureBox pictureBox1;
        private DataGridView dgyProveedores;
        private Label lblBuscar;
        private DataGridViewTextBoxColumn clmClave;
        private DataGridViewTextBoxColumn clmNombreProv;
        private DataGridViewTextBoxColumn clmEmpresa;
        private DataGridViewTextBoxColumn clmContacto;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private TextBox txtBuscar;
    }
}