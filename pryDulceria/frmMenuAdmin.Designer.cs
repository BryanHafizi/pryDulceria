namespace pryDulceria
{
    partial class frmMenuAdmin
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
            lblBienvenida = new Label();
            pnlOpciones = new Panel();
            btnCerrarSesion = new PictureBox();
            btnReportes = new Button();
            btnProveedores = new Button();
            btnInventario = new Button();
            btnVentas = new Button();
            pbLogo = new PictureBox();
            pnlOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnCerrarSesion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            SuspendLayout();
            // 
            // lblBienvenida
            // 
            lblBienvenida.AutoSize = true;
            lblBienvenida.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBienvenida.ForeColor = Color.FromArgb(51, 51, 51);
            lblBienvenida.Location = new Point(124, 30);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(572, 46);
            lblBienvenida.TabIndex = 2;
            lblBienvenida.Text = "Panel de Control - Dulcería Marlyn";
            // 
            // pnlOpciones
            // 
            pnlOpciones.BackColor = Color.FromArgb(255, 192, 203);
            pnlOpciones.Controls.Add(btnCerrarSesion);
            pnlOpciones.Controls.Add(lblBienvenida);
            pnlOpciones.Controls.Add(btnReportes);
            pnlOpciones.Controls.Add(btnProveedores);
            pnlOpciones.Controls.Add(btnInventario);
            pnlOpciones.Controls.Add(btnVentas);
            pnlOpciones.Location = new Point(102, 150);
            pnlOpciones.Name = "pnlOpciones";
            pnlOpciones.Size = new Size(820, 420);
            pnlOpciones.TabIndex = 1;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Image = Properties.Resources.Screenshot_2026_06_28_224006;
            btnCerrarSesion.Location = new Point(656, 350);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(120, 40);
            btnCerrarSesion.SizeMode = PictureBoxSizeMode.StretchImage;
            btnCerrarSesion.TabIndex = 4;
            btnCerrarSesion.TabStop = false;
            // 
            // btnReportes
            // 
            btnReportes.BackColor = Color.FromArgb(255, 105, 180);
            btnReportes.FlatStyle = FlatStyle.Flat;
            btnReportes.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReportes.ForeColor = Color.White;
            btnReportes.Location = new Point(432, 150);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(150, 150);
            btnReportes.TabIndex = 3;
            btnReportes.Text = "Reportes";
            btnReportes.UseVisualStyleBackColor = false;
            // 
            // btnProveedores
            // 
            btnProveedores.BackColor = Color.FromArgb(255, 105, 180);
            btnProveedores.FlatStyle = FlatStyle.Flat;
            btnProveedores.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProveedores.ForeColor = Color.White;
            btnProveedores.Location = new Point(626, 150);
            btnProveedores.Name = "btnProveedores";
            btnProveedores.Size = new Size(150, 150);
            btnProveedores.TabIndex = 0;
            btnProveedores.Text = "Proveedores";
            btnProveedores.UseVisualStyleBackColor = false;
            // 
            // btnInventario
            // 
            btnInventario.BackColor = Color.FromArgb(255, 105, 180);
            btnInventario.FlatStyle = FlatStyle.Flat;
            btnInventario.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInventario.ForeColor = Color.White;
            btnInventario.Location = new Point(238, 150);
            btnInventario.Name = "btnInventario";
            btnInventario.Size = new Size(150, 150);
            btnInventario.TabIndex = 1;
            btnInventario.Text = "Inventario";
            btnInventario.UseVisualStyleBackColor = false;
            // 
            // btnVentas
            // 
            btnVentas.BackColor = Color.FromArgb(255, 105, 180);
            btnVentas.FlatStyle = FlatStyle.Flat;
            btnVentas.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVentas.ForeColor = Color.White;
            btnVentas.Location = new Point(44, 150);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(150, 150);
            btnVentas.TabIndex = 2;
            btnVentas.Text = "Ventas";
            btnVentas.UseVisualStyleBackColor = false;
            // 
            // pbLogo
            // 
            pbLogo.Image = Properties.Resources.Screenshot_2026_06_28_220345_removebg_preview;
            pbLogo.Location = new Point(382, 30);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(200, 100);
            pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogo.TabIndex = 2;
            pbLogo.TabStop = false;
            // 
            // frmMenuAdmin
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 228, 225);
            ClientSize = new Size(1006, 721);
            Controls.Add(pbLogo);
            Controls.Add(pnlOpciones);
            Font = new Font("Segoe UI", 12F);
            Name = "frmMenuAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menú Administrador";
            pnlOpciones.ResumeLayout(false);
            pnlOpciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnCerrarSesion).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);
        }
        #endregion

        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.Panel pnlOpciones;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.Button btnProveedores;
        private Button btnReportes;
        private PictureBox btnCerrarSesion;
        private PictureBox pbLogo;
    }
}