namespace pryDulceria
{
    partial class frmInventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInventario));
            lblTitulo = new Label();
            btnNuevo = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            pbLogo = new PictureBox();
            pbIventario = new PictureBox();
            cmbInventario = new ComboBox();
            dgyInventario = new DataGridView();
            clmClave = new DataGridViewTextBoxColumn();
            clmNombreProv = new DataGridViewTextBoxColumn();
            clmEmpresa = new DataGridViewTextBoxColumn();
            clmContacto = new DataGridViewTextBoxColumn();
            lblBuscar = new Label();
            txtBuscarInventario = new TextBox();
            pbBuscar = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbIventario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgyInventario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbBuscar).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitulo.Location = new Point(195, 33);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(280, 37);
            lblTitulo.TabIndex = 3;
            lblTitulo.Text = "Inventario de Dulces";
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = Color.FromArgb(240, 128, 128);
            btnNuevo.FlatStyle = FlatStyle.Flat;
            btnNuevo.ForeColor = Color.White;
            btnNuevo.Location = new Point(299, 477);
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
            btnEditar.Location = new Point(422, 477);
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
            btnEliminar.Location = new Point(546, 477);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(100, 35);
            btnEliminar.TabIndex = 0;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // pbLogo
            // 
            pbLogo.Image = (Image)resources.GetObject("pbLogo.Image");
            pbLogo.Location = new Point(30, 20);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(159, 50);
            pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogo.TabIndex = 4;
            pbLogo.TabStop = false;
            // 
            // pbIventario
            // 
            pbIventario.Image = Properties.Resources.Code_Generated_Image__1_;
            pbIventario.Location = new Point(892, 12);
            pbIventario.Name = "pbIventario";
            pbIventario.Size = new Size(88, 58);
            pbIventario.SizeMode = PictureBoxSizeMode.StretchImage;
            pbIventario.TabIndex = 7;
            pbIventario.TabStop = false;
            // 
            // cmbInventario
            // 
            cmbInventario.FormattingEnabled = true;
            cmbInventario.Location = new Point(299, 96);
            cmbInventario.Name = "cmbInventario";
            cmbInventario.Size = new Size(121, 29);
            cmbInventario.TabIndex = 8;
            // 
            // dgyInventario
            // 
            dgyInventario.BackgroundColor = Color.White;
            dgyInventario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgyInventario.Columns.AddRange(new DataGridViewColumn[] { clmClave, clmNombreProv, clmEmpresa, clmContacto });
            dgyInventario.GridColor = Color.FromArgb(224, 176, 255);
            dgyInventario.Location = new Point(299, 131);
            dgyInventario.Name = "dgyInventario";
            dgyInventario.Size = new Size(443, 319);
            dgyInventario.TabIndex = 9;
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
            lblBuscar.Location = new Point(209, 96);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(84, 21);
            lblBuscar.TabIndex = 10;
            lblBuscar.Text = "Buscar por";
            // 
            // txtBuscarInventario
            // 
            txtBuscarInventario.Location = new Point(439, 96);
            txtBuscarInventario.Name = "txtBuscarInventario";
            txtBuscarInventario.Size = new Size(303, 29);
            txtBuscarInventario.TabIndex = 11;
            txtBuscarInventario.Text = "Buscar";
            // 
            // pbBuscar
            // 
            pbBuscar.BackColor = Color.White;
            pbBuscar.Image = Properties.Resources._1782681978865;
            pbBuscar.Location = new Point(700, 96);
            pbBuscar.Name = "pbBuscar";
            pbBuscar.Size = new Size(40, 29);
            pbBuscar.SizeMode = PictureBoxSizeMode.StretchImage;
            pbBuscar.TabIndex = 12;
            pbBuscar.TabStop = false;
            // 
            // frmInventario
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 228, 225);
            ClientSize = new Size(1024, 749);
            Controls.Add(pbBuscar);
            Controls.Add(txtBuscarInventario);
            Controls.Add(dgyInventario);
            Controls.Add(lblBuscar);
            Controls.Add(cmbInventario);
            Controls.Add(pbIventario);
            Controls.Add(pbLogo);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnNuevo);
            Controls.Add(lblTitulo);
            Font = new Font("Segoe UI", 12F);
            Name = "frmInventario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inventario";
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbIventario).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgyInventario).EndInit();
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
        private PictureBox pbIventario;
        private ComboBox cmbInventario;
        private DataGridView dgyInventario;
        private DataGridViewTextBoxColumn clmClave;
        private DataGridViewTextBoxColumn clmNombreProv;
        private DataGridViewTextBoxColumn clmEmpresa;
        private DataGridViewTextBoxColumn clmContacto;
        private Label lblBuscar;
        private TextBox txtBuscarInventario;
        private PictureBox pbBuscar;
    }
}