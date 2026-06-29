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
            dgyProductos = new DataGridView();
            btnNuevo = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();

            ((System.ComponentModel.ISupportInitialize)dgyProductos).BeginInit();

            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgyProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();

            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 20F, FontStyle.Bold);

            lblTitulo.Location = new Point(175, 28);

            lblTitulo.Location = new Point(195, 33);

            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(280, 37);
            lblTitulo.TabIndex = 3;
            lblTitulo.Text = "Inventario de Dulces";
            // 
            // dgyProductos
            // 
            dgyProductos.BackgroundColor = Color.White;
            dgyProductos.GridColor = Color.FromArgb(224, 176, 255);
            dgyProductos.Location = new Point(30, 90);
            dgyProductos.Name = "dgyProductos";
            dgyProductos.Size = new Size(950, 450);
            dgyProductos.TabIndex = 1;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = Color.FromArgb(240, 128, 128);
            btnNuevo.FlatStyle = FlatStyle.Flat;
            btnNuevo.ForeColor = Color.White;
            btnNuevo.Location = new Point(640, 570);
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
            btnEditar.Location = new Point(760, 570);
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
            btnEliminar.Location = new Point(880, 570);
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

            // frmInventario
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 228, 225);

            ClientSize = new Size(1024, 749);

            ClientSize = new Size(1024, 768);
            Controls.Add(pictureBox1);

            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnNuevo);
            Controls.Add(dgyProductos);
            Controls.Add(lblTitulo);
            Font = new Font("Segoe UI", 12F);
            Name = "frmInventario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inventario";
            ((System.ComponentModel.ISupportInitialize)dgyProductos).EndInit();


            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();

            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgyProductos;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private PictureBox pictureBox1;
    }
}