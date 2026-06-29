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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            comboBox1 = new ComboBox();
            dgyProveedores = new DataGridView();
            clmClave = new DataGridViewTextBoxColumn();
            clmNombreProv = new DataGridViewTextBoxColumn();
            clmEmpresa = new DataGridViewTextBoxColumn();
            clmContacto = new DataGridViewTextBoxColumn();
            lblBuscar = new Label();
            txtBuscar = new TextBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgyProveedores).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
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
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(30, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(159, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Code_Generated_Image__1_;
            pictureBox2.Location = new Point(892, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(88, 58);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(299, 96);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 29);
            comboBox1.TabIndex = 8;
            // 
            // dgyProveedores
            // 
            dgyProveedores.BackgroundColor = Color.White;
            dgyProveedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgyProveedores.Columns.AddRange(new DataGridViewColumn[] { clmClave, clmNombreProv, clmEmpresa, clmContacto });
            dgyProveedores.GridColor = Color.FromArgb(224, 176, 255);
            dgyProveedores.Location = new Point(299, 131);
            dgyProveedores.Name = "dgyProveedores";
            dgyProveedores.Size = new Size(443, 319);
            dgyProveedores.TabIndex = 9;
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
            // txtBuscar
            // 
            txtBuscar.Location = new Point(439, 96);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(303, 29);
            txtBuscar.TabIndex = 11;
            txtBuscar.Text = "Buscar";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.White;
            pictureBox3.Image = Properties.Resources._1782681978865;
            pictureBox3.Location = new Point(700, 96);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(40, 29);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            // 
            // frmInventario
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 228, 225);
            ClientSize = new Size(1024, 749);
            Controls.Add(pictureBox3);
            Controls.Add(txtBuscar);
            Controls.Add(dgyProveedores);
            Controls.Add(lblBuscar);
            Controls.Add(comboBox1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnNuevo);
            Controls.Add(lblTitulo);
            Font = new Font("Segoe UI", 12F);
            Name = "frmInventario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inventario";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgyProveedores).EndInit();
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
        private PictureBox pictureBox2;
        private ComboBox comboBox1;
        private DataGridView dgyProveedores;
        private DataGridViewTextBoxColumn clmClave;
        private DataGridViewTextBoxColumn clmNombreProv;
        private DataGridViewTextBoxColumn clmEmpresa;
        private DataGridViewTextBoxColumn clmContacto;
        private Label lblBuscar;
        private TextBox txtBuscar;
        private PictureBox pictureBox3;
    }
}