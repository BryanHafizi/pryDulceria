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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuPrincipal));
            pcbLogo = new PictureBox();
            pnlMenu = new Panel();
            pcbUsuarios = new PictureBox();
            pcbProveedores = new PictureBox();
            pcbReportes = new PictureBox();
            pcbInventario = new PictureBox();
            pbCerrarSesion = new PictureBox();
            pcbVentas = new PictureBox();
            pnlContenedor = new Panel();
            pbAyuda = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pcbLogo).BeginInit();
            pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbUsuarios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbProveedores).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbReportes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbInventario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbCerrarSesion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbVentas).BeginInit();
            pnlContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbAyuda).BeginInit();
            SuspendLayout();
            // 
            // pcbLogo
            // 
            pcbLogo.Image = Properties.Resources.Screenshot_2026_06_28_220345_removebg_preview;
            pcbLogo.Location = new Point(10, 6);
            pcbLogo.Name = "pcbLogo";
            pcbLogo.Size = new Size(150, 50);
            pcbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbLogo.TabIndex = 2;
            pcbLogo.TabStop = false;
            // 
            // pnlMenu
            // 
            pnlMenu.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlMenu.BackColor = Color.Pink;
            pnlMenu.Controls.Add(pcbUsuarios);
            pnlMenu.Controls.Add(pcbProveedores);
            pnlMenu.Controls.Add(pcbReportes);
            pnlMenu.Controls.Add(pcbInventario);
            pnlMenu.Controls.Add(pbCerrarSesion);
            pnlMenu.Controls.Add(pcbLogo);
            pnlMenu.Controls.Add(pcbVentas);
            pnlMenu.Location = new Point(2, 3);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(1344, 60);
            pnlMenu.TabIndex = 7;
            // 
            // pcbUsuarios
            // 
            pcbUsuarios.Image = (Image)resources.GetObject("pcbUsuarios.Image");
            pcbUsuarios.Location = new Point(920, 6);
            pcbUsuarios.Name = "pcbUsuarios";
            pcbUsuarios.Size = new Size(150, 50);
            pcbUsuarios.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbUsuarios.TabIndex = 9;
            pcbUsuarios.TabStop = false;
            pcbUsuarios.Click += pbUsuarios_Click;
            // 
            // pcbProveedores
            // 
            pcbProveedores.Image = (Image)resources.GetObject("pcbProveedores.Image");
            pcbProveedores.Location = new Point(740, 6);
            pcbProveedores.Name = "pcbProveedores";
            pcbProveedores.Size = new Size(150, 50);
            pcbProveedores.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbProveedores.TabIndex = 10;
            pcbProveedores.TabStop = false;
            pcbProveedores.Click += pbProveedores_Click;
            // 
            // pcbReportes
            // 
            pcbReportes.Image = (Image)resources.GetObject("pcbReportes.Image");
            pcbReportes.Location = new Point(560, 6);
            pcbReportes.Name = "pcbReportes";
            pcbReportes.Size = new Size(150, 50);
            pcbReportes.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbReportes.TabIndex = 11;
            pcbReportes.TabStop = false;
            pcbReportes.Click += pbReportes_Click;
            // 
            // pcbInventario
            // 
            pcbInventario.Image = (Image)resources.GetObject("pcbInventario.Image");
            pcbInventario.Location = new Point(380, 6);
            pcbInventario.Name = "pcbInventario";
            pcbInventario.Size = new Size(150, 50);
            pcbInventario.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbInventario.TabIndex = 12;
            pcbInventario.TabStop = false;
            pcbInventario.Click += pbInventarios_Click;
            // 
            // pbCerrarSesion
            // 
            pbCerrarSesion.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            pbCerrarSesion.Image = Properties.Resources.Screenshot_2026_06_28_224006;
            pbCerrarSesion.Location = new Point(1180, 6);
            pbCerrarSesion.Name = "pbCerrarSesion";
            pbCerrarSesion.Size = new Size(150, 50);
            pbCerrarSesion.SizeMode = PictureBoxSizeMode.StretchImage;
            pbCerrarSesion.TabIndex = 8;
            pbCerrarSesion.TabStop = false;
            pbCerrarSesion.Click += pbCerrarSesion_Click;
            // 
            // pcbVentas
            // 
            pcbVentas.Image = (Image)resources.GetObject("pcbVentas.Image");
            pcbVentas.Location = new Point(200, 6);
            pcbVentas.Name = "pcbVentas";
            pcbVentas.Size = new Size(150, 50);
            pcbVentas.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbVentas.TabIndex = 9;
            pcbVentas.TabStop = false;
            pcbVentas.Click += pbVentas_Click;
            // 
            // pnlContenedor
            // 
            pnlContenedor.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlContenedor.AutoSize = true;
            pnlContenedor.Controls.Add(pbAyuda);
            pnlContenedor.Location = new Point(2, 69);
            pnlContenedor.Name = "pnlContenedor";
            pnlContenedor.Size = new Size(1344, 650);
            pnlContenedor.TabIndex = 8;
            // 
            // pbAyuda
            // 
            pbAyuda.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            pbAyuda.Location = new Point(1455, 3);
            pbAyuda.Name = "pbAyuda";
            pbAyuda.Size = new Size(52, 40);
            pbAyuda.SizeMode = PictureBoxSizeMode.StretchImage;
            pbAyuda.TabIndex = 10;
            pbAyuda.TabStop = false;
            // 
            // frmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(255, 228, 225);
            ClientSize = new Size(1348, 721);
            Controls.Add(pnlContenedor);
            Controls.Add(pnlMenu);
            Font = new Font("Segoe UI", 12F);
            Name = "frmMenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menú Principal";
            ((System.ComponentModel.ISupportInitialize)pcbLogo).EndInit();
            pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pcbUsuarios).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbProveedores).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbReportes).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbInventario).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbCerrarSesion).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbVentas).EndInit();
            pnlContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbAyuda).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pcbLogo;
        private Panel pnlMenu;
        private PictureBox pbCerrarSesion;
        private Panel pnlContenedor;
        private PictureBox pcbInventario;
        private PictureBox pcbReportes;
        private PictureBox pcbProveedores;
        private PictureBox pcbVentas;
        private PictureBox pcbUsuarios;
        private PictureBox pbAyuda;
    }
}