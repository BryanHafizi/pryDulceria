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
            pbUsuarios = new PictureBox();
            pbProveedores = new PictureBox();
            pbReportes = new PictureBox();
            pbInventario = new PictureBox();
            pbCerrarSesion = new PictureBox();
            pbVentas = new PictureBox();
            pnlContenedor = new Panel();
            pbAyuda = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbUsuarios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbProveedores).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbReportes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbInventario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbCerrarSesion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbVentas).BeginInit();
            pnlContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbAyuda).BeginInit();
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
            pnlMenu.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlMenu.BackColor = Color.Pink;
            pnlMenu.Controls.Add(pbUsuarios);
            pnlMenu.Controls.Add(pbProveedores);
            pnlMenu.Controls.Add(pbReportes);
            pnlMenu.Controls.Add(pbInventario);
            pnlMenu.Controls.Add(pbCerrarSesion);
            pnlMenu.Controls.Add(pbLogo);
            pnlMenu.Controls.Add(pbVentas);
            pnlMenu.Location = new Point(2, 3);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(1105, 60);
            pnlMenu.TabIndex = 7;
            // 
            // pbUsuarios
            // 
            pbUsuarios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            pbUsuarios.Image = Properties.Resources._1782681922009;
            pbUsuarios.Location = new Point(790, 9);
            pbUsuarios.Name = "pbUsuarios";
            pbUsuarios.Size = new Size(150, 40);
            pbUsuarios.SizeMode = PictureBoxSizeMode.StretchImage;
            pbUsuarios.TabIndex = 9;
            pbUsuarios.TabStop = false;
            pbUsuarios.Click += pbUsuarios_Click;
            // 
            // pbProveedores
            // 
            pbProveedores.Image = Properties.Resources.Captura_de_pantalla_2026_07_13_2212111;
            pbProveedores.Location = new Point(634, 9);
            pbProveedores.Name = "pbProveedores";
            pbProveedores.Size = new Size(150, 40);
            pbProveedores.SizeMode = PictureBoxSizeMode.StretchImage;
            pbProveedores.TabIndex = 10;
            pbProveedores.TabStop = false;
            pbProveedores.Click += pbProveedores_Click;
            // 
            // pbReportes
            // 
            pbReportes.Image = Properties.Resources.Captura_de_pantalla_2026_07_13_2213191;
            pbReportes.Location = new Point(478, 9);
            pbReportes.Name = "pbReportes";
            pbReportes.Size = new Size(150, 40);
            pbReportes.SizeMode = PictureBoxSizeMode.StretchImage;
            pbReportes.TabIndex = 11;
            pbReportes.TabStop = false;
            pbReportes.Click += pbReportes_Click;
            // 
            // pbInventario
            // 
            pbInventario.Image = Properties.Resources.Captura_de_pantalla_2026_07_13_2212451;
            pbInventario.Location = new Point(322, 9);
            pbInventario.Name = "pbInventario";
            pbInventario.Size = new Size(150, 40);
            pbInventario.SizeMode = PictureBoxSizeMode.StretchImage;
            pbInventario.TabIndex = 12;
            pbInventario.TabStop = false;
            pbInventario.Click += pbInventarios_Click;
            // 
            // pbCerrarSesion
            // 
            pbCerrarSesion.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            pbCerrarSesion.Image = Properties.Resources.Screenshot_2026_06_28_224006;
            pbCerrarSesion.Location = new Point(952, 9);
            pbCerrarSesion.Name = "pbCerrarSesion";
            pbCerrarSesion.Size = new Size(150, 40);
            pbCerrarSesion.SizeMode = PictureBoxSizeMode.StretchImage;
            pbCerrarSesion.TabIndex = 8;
            pbCerrarSesion.TabStop = false;
            pbCerrarSesion.Click += pbCerrarSesion_Click;
            // 
            // pbVentas
            // 
            pbVentas.Image = Properties.Resources.Captura_de_pantalla_2026_07_13_2211531;
            pbVentas.Location = new Point(166, 9);
            pbVentas.Name = "pbVentas";
            pbVentas.Size = new Size(150, 40);
            pbVentas.SizeMode = PictureBoxSizeMode.StretchImage;
            pbVentas.TabIndex = 9;
            pbVentas.TabStop = false;
            pbVentas.Click += pbVentas_Click;
            // 
            // pnlContenedor
            // 
            pnlContenedor.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlContenedor.AutoSize = true;
            pnlContenedor.Controls.Add(pbAyuda);
            pnlContenedor.Location = new Point(2, 69);
            pnlContenedor.Name = "pnlContenedor";
            pnlContenedor.Size = new Size(1102, 650);
            pnlContenedor.TabIndex = 8;
            // 
            // pbAyuda
            // 
            pbAyuda.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            pbAyuda.Location = new Point(1213, 3);
            pbAyuda.Name = "pbAyuda";
            pbAyuda.Size = new Size(52, 40);
            pbAyuda.SizeMode = PictureBoxSizeMode.StretchImage;
            pbAyuda.TabIndex = 10;
            pbAyuda.TabStop = false;
            // 
            // frmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(255, 228, 225);
            ClientSize = new Size(1109, 721);
            Controls.Add(pnlContenedor);
            Controls.Add(pnlMenu);
            Font = new Font("Segoe UI", 12F);
            Name = "frmMenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menú Principal";
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbUsuarios).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbProveedores).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbReportes).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbInventario).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbCerrarSesion).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbVentas).EndInit();
            pnlContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbAyuda).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pbLogo;
        private Panel pnlMenu;
        private PictureBox pbCerrarSesion;
        private Panel pnlContenedor;
        private PictureBox pbInventario;
        private PictureBox pbReportes;
        private PictureBox pbProveedores;
        private PictureBox pbVentas;
        private PictureBox pbUsuarios;
        private PictureBox pbAyuda;
    }
}