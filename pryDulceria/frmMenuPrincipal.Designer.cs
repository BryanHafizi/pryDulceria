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
            lblTitulo = new Label();
            pcbUsuarios = new PictureBox();
            pcbProveedores = new PictureBox();
            pcbReportes = new PictureBox();
            pcbInventario = new PictureBox();
            pcbCerrarSesion = new PictureBox();
            pcbVentas = new PictureBox();
            pnlContenedor = new Panel();
            pbAyuda = new PictureBox();
            panel1 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)pcbLogo).BeginInit();
            pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbUsuarios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbProveedores).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbReportes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbInventario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbCerrarSesion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbVentas).BeginInit();
            pnlContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbAyuda).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pcbLogo
            // 
            pcbLogo.Image = Properties.Resources.Screenshot_2026_06_28_220345_removebg_preview;
            pcbLogo.Location = new Point(10, 7);
            pcbLogo.Name = "pcbLogo";
            pcbLogo.Size = new Size(150, 50);
            pcbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbLogo.TabIndex = 2;
            pcbLogo.TabStop = false;
            // 
            // pnlMenu
            // 
            pnlMenu.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            pnlMenu.BackColor = Color.Gray;
            pnlMenu.Controls.Add(lblTitulo);

            pnlMenu.BackColor = Color.MistyRose;
            pnlMenu.BorderStyle = BorderStyle.Fixed3D;
            pnlMenu.Controls.Add(pcbUsuarios);
            pnlMenu.Controls.Add(pcbProveedores);
            pnlMenu.Controls.Add(pcbReportes);
            pnlMenu.Controls.Add(pcbInventario);
            pnlMenu.Controls.Add(pcbCerrarSesion);

            pnlMenu.Controls.Add(pcbLogo);
            pnlMenu.Location = new Point(2, 3);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(1035, 60);
            pnlMenu.TabIndex = 7;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.Black;
            lblTitulo.Location = new Point(440, 7);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(258, 45);
            lblTitulo.TabIndex = 18;
            lblTitulo.Text = "Punto de Venta ";
            // 
            // pcbUsuarios
            // 
            pcbUsuarios.Image = Properties.Resources.btnUsuarios;
            pcbUsuarios.Location = new Point(10, 239);
            pcbUsuarios.Name = "pcbUsuarios";
            pcbUsuarios.Size = new Size(150, 50);
            pcbUsuarios.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbUsuarios.TabIndex = 9;
            pcbUsuarios.TabStop = false;
            pcbUsuarios.Click += pbUsuarios_Click;
            // 
            // pcbProveedores
            // 
            pcbProveedores.Image = Properties.Resources.btnProveedores;
            pcbProveedores.Location = new Point(10, 183);
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
            pcbReportes.Location = new Point(10, 127);
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
            pcbInventario.Location = new Point(10, 71);
            pcbInventario.Name = "pcbInventario";
            pcbInventario.Size = new Size(150, 50);
            pcbInventario.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbInventario.TabIndex = 12;
            pcbInventario.TabStop = false;
            pcbInventario.Click += pbInventarios_Click;
            // 
            // pcbCerrarSesion
            // 

            pbCerrarSesion.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            pbCerrarSesion.Image = Properties.Resources.Screenshot_2026_06_28_224006;
            pbCerrarSesion.Location = new Point(10, 313);
            pbCerrarSesion.Name = "pbCerrarSesion";
            pbCerrarSesion.Size = new Size(150, 50);
            pbCerrarSesion.SizeMode = PictureBoxSizeMode.StretchImage;
            pbCerrarSesion.TabIndex = 8;
            pbCerrarSesion.TabStop = false;
            pbCerrarSesion.Click += pbCerrarSesion_Click;

            pcbCerrarSesion.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            pcbCerrarSesion.Image = Properties.Resources.Screenshot_2026_06_28_224006;
            pcbCerrarSesion.Location = new Point(1176, 6);
            pcbCerrarSesion.Name = "pcbCerrarSesion";
            pcbCerrarSesion.Size = new Size(150, 46);
            pcbCerrarSesion.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbCerrarSesion.TabIndex = 8;
            pcbCerrarSesion.TabStop = false;
            pcbCerrarSesion.Click += pbCerrarSesion_Click;

            // 
            // pcbVentas
            // 
            pcbVentas.Image = Properties.Resources.btnVentas;
            pcbVentas.Location = new Point(10, 15);
            pcbVentas.Name = "pcbVentas";
            pcbVentas.Size = new Size(150, 50);
            pcbVentas.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbVentas.TabIndex = 9;
            pcbVentas.TabStop = false;
            pcbVentas.Click += pbVentas_Click;
            // 
            // pnlContenedor
            // 

            pnlContenedor.BackColor = Color.DarkGray;

            pnlContenedor.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlContenedor.AutoSize = true;
            pnlContenedor.BackColor = Color.MistyRose;
            pnlContenedor.BorderStyle = BorderStyle.Fixed3D;

            pnlContenedor.Controls.Add(pbAyuda);
            pnlContenedor.Location = new Point(183, 69);
            pnlContenedor.Name = "pnlContenedor";
            pnlContenedor.Size = new Size(854, 310);
            pnlContenedor.TabIndex = 11;
            // 
            // pbAyuda
            // 
            pbAyuda.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;

            pbAyuda.Location = new Point(965, 3);
            pbAyuda.Name = "pbAyuda";
            pbAyuda.Size = new Size(52, 77);

            pbAyuda.Location = new Point(1451, 3);
            pbAyuda.Name = "pbAyuda";
            pbAyuda.Size = new Size(52, 36);

            pbAyuda.SizeMode = PictureBoxSizeMode.StretchImage;
            pbAyuda.TabIndex = 10;
            pbAyuda.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGray;
            panel1.Controls.Add(pbCerrarSesion);
            panel1.Controls.Add(pcbUsuarios);
            panel1.Controls.Add(pcbVentas);
            panel1.Controls.Add(pcbProveedores);
            panel1.Controls.Add(pcbInventario);
            panel1.Controls.Add(pcbReportes);
            panel1.Location = new Point(2, 69);
            panel1.Name = "panel1";
            panel1.Size = new Size(175, 375);
            panel1.TabIndex = 11;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.DarkGray;
            flowLayoutPanel1.Location = new Point(183, 385);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(854, 310);
            flowLayoutPanel1.TabIndex = 13;
            // 
            // frmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;

            BackColor = Color.LightGray;
            ClientSize = new Size(1042, 749);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);

            BackColor = Color.MistyRose;
            ClientSize = new Size(1348, 721);

            Controls.Add(pnlContenedor);
            Controls.Add(pnlMenu);
            Font = new Font("Segoe UI", 12F);
            Name = "frmMenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menú Principal";
            Load += frmMenuPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)pcbLogo).EndInit();
            pnlMenu.ResumeLayout(false);
            pnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcbUsuarios).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbProveedores).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbReportes).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbInventario).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbCerrarSesion).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbVentas).EndInit();
            pnlContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbAyuda).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pcbLogo;
        private Panel pnlMenu;
        private PictureBox pcbCerrarSesion;
        private Panel pnlContenedor;
        private PictureBox pcbInventario;
        private PictureBox pcbReportes;
        private PictureBox pcbProveedores;
        private PictureBox pcbVentas;
        private PictureBox pcbUsuarios;
        private PictureBox pbAyuda;
        private Panel panel1;
        private Label lblTitulo;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}