namespace pryDulceria
{
    partial class frmMenuPrincipal
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
            pbLogo = new PictureBox();
            pnlMenu = new Panel();
            btnProveedores = new Button();
            pbCerrarSesion = new PictureBox();
            btnReportes = new Button();
            btnVentas = new Button();
            btnInventario = new Button();
            pnlContenedor = new Panel();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbCerrarSesion).BeginInit();
            SuspendLayout();
            // 
            // pbLogo
            // 
            pbLogo.Image = Properties.Resources.Screenshot_2026_06_28_220345_removebg_preview;
            pbLogo.Location = new Point(10, 6);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(150, 50);
            pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogo.TabIndex = 2;
            pbLogo.TabStop = false;
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.Pink;
            pnlMenu.Controls.Add(btnProveedores);
            pnlMenu.Controls.Add(pbCerrarSesion);
            pnlMenu.Controls.Add(btnReportes);
            pnlMenu.Controls.Add(btnVentas);
            pnlMenu.Controls.Add(btnInventario);
            pnlMenu.Controls.Add(pbLogo);
            pnlMenu.Location = new Point(2, 3);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(1000, 60);
            pnlMenu.TabIndex = 7;
            // 
            // btnProveedores
            // 
            btnProveedores.Location = new Point(680, 6);
            btnProveedores.Name = "btnProveedores";
            btnProveedores.Size = new Size(150, 40);
            btnProveedores.TabIndex = 3;
            btnProveedores.Text = "proveedores";
            btnProveedores.UseVisualStyleBackColor = true;
            // 
            // pbCerrarSesion
            // 
            pbCerrarSesion.Image = Properties.Resources.Screenshot_2026_06_28_224006;
            pbCerrarSesion.Location = new Point(840, 6);
            pbCerrarSesion.Name = "pbCerrarSesion";
            pbCerrarSesion.Size = new Size(150, 40);
            pbCerrarSesion.SizeMode = PictureBoxSizeMode.StretchImage;
            pbCerrarSesion.TabIndex = 8;
            pbCerrarSesion.TabStop = false;
            // 
            // btnReportes
            // 
            btnReportes.Location = new Point(520, 6);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(150, 40);
            btnReportes.TabIndex = 2;
            btnReportes.Text = "reportes";
            btnReportes.UseVisualStyleBackColor = true;
            // 
            // btnVentas
            // 
            btnVentas.Location = new Point(200, 6);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(150, 40);
            btnVentas.TabIndex = 0;
            btnVentas.Text = "ventas";
            btnVentas.UseVisualStyleBackColor = true;
            // 
            // btnInventario
            // 
            btnInventario.Location = new Point(360, 6);
            btnInventario.Name = "btnInventario";
            btnInventario.Size = new Size(150, 40);
            btnInventario.TabIndex = 1;
            btnInventario.Text = "Inventario";
            btnInventario.UseVisualStyleBackColor = true;
            // 
            // pnlContenedor
            // 
            pnlContenedor.Location = new Point(2, 69);
            pnlContenedor.Name = "pnlContenedor";
            pnlContenedor.Size = new Size(1000, 650);
            pnlContenedor.TabIndex = 8;
            // 
            // frmMenuAdmin
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 228, 225);
            ClientSize = new Size(1006, 721);
            Controls.Add(pnlContenedor);
            Controls.Add(pnlMenu);
            Font = new Font("Segoe UI", 12F);
            Name = "frmMenuAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menú Administrador";
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbCerrarSesion).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pbLogo;
        private Panel pnlMenu;
        private Button btnInventario;
        private Button btnVentas;
        private Button btnProveedores;
        private Button btnReportes;
        private PictureBox pbCerrarSesion;
        private Panel pnlContenedor;
    }
}