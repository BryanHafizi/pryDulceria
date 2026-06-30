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
            pbLogo = new PictureBox();
            dgyProveedores = new DataGridView();
            clmClave = new DataGridViewTextBoxColumn();
            clmNombreProv = new DataGridViewTextBoxColumn();
            clmEmpresa = new DataGridViewTextBoxColumn();
            clmContacto = new DataGridViewTextBoxColumn();
            lblBuscar = new Label();
            pbProveedores = new PictureBox();
            pbBuscar = new PictureBox();
            txtBuscarProv = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgyProveedores).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbProveedores).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbBuscar).BeginInit();
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
            // pbLogo
            // 
            pbLogo.Image = Properties.Resources.Screenshot_2026_06_28_220345_removebg_preview;
            pbLogo.Location = new Point(30, 20);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(159, 50);
            pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogo.TabIndex = 5;
            pbLogo.TabStop = false;
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
            // pbProveedores
            // 
            pbProveedores.AccessibleRole = AccessibleRole.None;
            pbProveedores.Image = Properties.Resources._1782681922009;
            pbProveedores.Location = new Point(910, 20);
            pbProveedores.Name = "pbProveedores";
            pbProveedores.Size = new Size(88, 58);
            pbProveedores.SizeMode = PictureBoxSizeMode.StretchImage;
            pbProveedores.TabIndex = 9;
            pbProveedores.TabStop = false;
            // 
            // pbBuscar
            // 
            pbBuscar.BackColor = Color.White;
            pbBuscar.Image = Properties.Resources._1782681978865;
            pbBuscar.Location = new Point(741, 72);
            pbBuscar.Name = "pbBuscar";
            pbBuscar.Size = new Size(40, 29);
            pbBuscar.SizeMode = PictureBoxSizeMode.StretchImage;
            pbBuscar.TabIndex = 14;
            pbBuscar.TabStop = false;
            // 
            // txtBuscarProv
            // 
            txtBuscarProv.Location = new Point(371, 72);
            txtBuscarProv.Name = "txtBuscarProv";
            txtBuscarProv.Size = new Size(410, 29);
            txtBuscarProv.TabIndex = 13;
            txtBuscarProv.Text = "Buscar";
            // 
            // frmProveedores
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 228, 225);
            ClientSize = new Size(1024, 749);
            Controls.Add(pbBuscar);
            Controls.Add(txtBuscarProv);
            Controls.Add(pbProveedores);
            Controls.Add(dgyProveedores);
            Controls.Add(lblBuscar);
            Controls.Add(pbLogo);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnNuevo);
            Controls.Add(lblTitulo);
            Font = new Font("Segoe UI", 12F);
            Name = "frmProveedores";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de Proveedores";
            Load += frmProveedores_Load;
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgyProveedores).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbProveedores).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbBuscar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private PictureBox pbLogo;
        private DataGridView dgyProveedores;
        private Label lblBuscar;
        private DataGridViewTextBoxColumn clmClave;
        private DataGridViewTextBoxColumn clmNombreProv;
        private DataGridViewTextBoxColumn clmEmpresa;
        private DataGridViewTextBoxColumn clmContacto;
        private PictureBox pbProveedores;
        private PictureBox pbBuscar;
        private TextBox txtBuscarProv;
    }
}