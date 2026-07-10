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
            lblTitulo.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.FromArgb(51, 51, 51);
            lblTitulo.Location = new Point(225, 40);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(259, 54);
            lblTitulo.TabIndex = 3;
            lblTitulo.Text = "Proveedores";
            lblTitulo.Click += lblTitulo_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = Color.HotPink;
            btnNuevo.FlatStyle = FlatStyle.Flat;
            btnNuevo.ForeColor = Color.White;
            btnNuevo.Location = new Point(320, 600);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(120, 40);
            btnNuevo.TabIndex = 2;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.HotPink;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.ForeColor = Color.White;
            btnEditar.Location = new Point(470, 600);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(120, 40);
            btnEditar.TabIndex = 1;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(240, 128, 128);
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(620, 600);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(120, 40);
            btnEliminar.TabIndex = 0;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // pbLogo
            // 
            pbLogo.Image = Properties.Resources.Screenshot_2026_06_28_220345_removebg_preview;
            pbLogo.Location = new Point(50, 40);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(150, 50);
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
            dgyProveedores.Location = new Point(320, 180);
            dgyProveedores.Name = "dgyProveedores";
            dgyProveedores.RowHeadersWidth = 51;
            dgyProveedores.Size = new Size(550, 400);
            dgyProveedores.TabIndex = 6;
            // 
            // clmClave
            // 
            clmClave.HeaderText = "Clave";
            clmClave.MinimumWidth = 6;
            clmClave.Name = "clmClave";
            clmClave.Width = 125;
            // 
            // clmNombreProv
            // 
            clmNombreProv.HeaderText = "Nombre del proveedor";
            clmNombreProv.MinimumWidth = 6;
            clmNombreProv.Name = "clmNombreProv";
            clmNombreProv.Width = 125;
            // 
            // clmEmpresa
            // 
            clmEmpresa.HeaderText = "Empresa";
            clmEmpresa.MinimumWidth = 6;
            clmEmpresa.Name = "clmEmpresa";
            clmEmpresa.Width = 125;
            // 
            // clmContacto
            // 
            clmContacto.HeaderText = "Contacto";
            clmContacto.MinimumWidth = 6;
            clmContacto.Name = "clmContacto";
            clmContacto.Width = 125;
            // 
            // pbProveedores
            // 
            pbProveedores.AccessibleRole = AccessibleRole.None;
            pbProveedores.Image = Properties.Resources._1782681922009;
            pbProveedores.Location = new Point(890, 40);
            pbProveedores.Name = "pbProveedores";
            pbProveedores.Size = new Size(80, 60);
            pbProveedores.SizeMode = PictureBoxSizeMode.StretchImage;
            pbProveedores.TabIndex = 9;
            pbProveedores.TabStop = false;
            // 
            // pbBuscar
            // 
            pbBuscar.BackColor = Color.White;
            pbBuscar.Image = Properties.Resources._1782681978865;
            pbBuscar.Location = new Point(790, 112);
            pbBuscar.Name = "pbBuscar";
            pbBuscar.Size = new Size(30, 30);
            pbBuscar.SizeMode = PictureBoxSizeMode.StretchImage;
            pbBuscar.TabIndex = 14;
            pbBuscar.TabStop = false;
            // 
            // txtBuscarProv
            // 
            txtBuscarProv.Location = new Point(380, 110);
            txtBuscarProv.Name = "txtBuscarProv";
            txtBuscarProv.Size = new Size(450, 34);
            txtBuscarProv.TabIndex = 13;
            txtBuscarProv.Text = "Buscar";
            // 
            // frmProveedores
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 228, 225);
            ClientSize = new Size(1006, 721);
            Controls.Add(pbBuscar);
            Controls.Add(txtBuscarProv);
            Controls.Add(pbProveedores);
            Controls.Add(dgyProveedores);
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
        private DataGridViewTextBoxColumn clmClave;
        private DataGridViewTextBoxColumn clmNombreProv;
        private DataGridViewTextBoxColumn clmEmpresa;
        private DataGridViewTextBoxColumn clmContacto;
        private PictureBox pbProveedores;
        private PictureBox pbBuscar;
        private TextBox txtBuscarProv;
    }
}