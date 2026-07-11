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
            btnCerrarSesion = new PictureBox();
            pbLogo = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            pbCerrarSesion = new PictureBox();
            btnProveedores = new Button();
            btnReportes = new Button();
            btnInventario = new Button();
            btnVentas = new Button();
            panel4 = new Panel();
            ((System.ComponentModel.ISupportInitialize)btnCerrarSesion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbCerrarSesion).BeginInit();
            SuspendLayout();
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Image = Properties.Resources.Screenshot_2026_06_28_224006;
            btnCerrarSesion.Location = new Point(675, 17);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(120, 40);
            btnCerrarSesion.SizeMode = PictureBoxSizeMode.StretchImage;
            btnCerrarSesion.TabIndex = 4;
            btnCerrarSesion.TabStop = false;
            // 
            // pbLogo
            // 
            pbLogo.Image = Properties.Resources.Screenshot_2026_06_28_220345_removebg_preview;
            pbLogo.Location = new Point(0, 3);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(156, 50);
            pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogo.TabIndex = 2;
            pbLogo.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Pink;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btnCerrarSesion);
            panel1.Controls.Add(pbLogo);
            panel1.Location = new Point(12, 7);
            panel1.Name = "panel1";
            panel1.Size = new Size(156, 56);
            panel1.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Plum;
            panel2.Location = new Point(160, 13);
            panel2.Name = "panel2";
            panel2.Size = new Size(865, 51);
            panel2.TabIndex = 7;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Pink;
            panel3.Controls.Add(pbCerrarSesion);
            panel3.Controls.Add(btnProveedores);
            panel3.Controls.Add(btnReportes);
            panel3.Controls.Add(btnInventario);
            panel3.Controls.Add(btnVentas);
            panel3.Location = new Point(166, 15);
            panel3.Name = "panel3";
            panel3.Size = new Size(868, 46);
            panel3.TabIndex = 7;
            // 
            // pbCerrarSesion
            // 
            pbCerrarSesion.Image = Properties.Resources.Screenshot_2026_06_28_224006;
            pbCerrarSesion.Location = new Point(744, 4);
            pbCerrarSesion.Name = "pbCerrarSesion";
            pbCerrarSesion.Size = new Size(108, 36);
            pbCerrarSesion.SizeMode = PictureBoxSizeMode.StretchImage;
            pbCerrarSesion.TabIndex = 8;
            pbCerrarSesion.TabStop = false;
            // 
            // btnProveedores
            // 
            btnProveedores.Location = new Point(511, 5);
            btnProveedores.Name = "btnProveedores";
            btnProveedores.Size = new Size(157, 35);
            btnProveedores.TabIndex = 3;
            btnProveedores.Text = "proveedores";
            btnProveedores.UseVisualStyleBackColor = true;
            // 
            // btnReportes
            // 
            btnReportes.Location = new Point(354, 5);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(151, 36);
            btnReportes.TabIndex = 2;
            btnReportes.Text = "reportes";
            btnReportes.UseVisualStyleBackColor = true;
            // 
            // btnInventario
            // 
            btnInventario.Location = new Point(206, 5);
            btnInventario.Name = "btnInventario";
            btnInventario.Size = new Size(142, 37);
            btnInventario.TabIndex = 1;
            btnInventario.Text = "inventario";
            btnInventario.UseVisualStyleBackColor = true;
            // 
            // btnVentas
            // 
            btnVentas.Location = new Point(38, 4);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(149, 36);
            btnVentas.TabIndex = 0;
            btnVentas.Text = "ventas";
            btnVentas.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.Location = new Point(12, 62);
            panel4.Name = "panel4";
            panel4.Size = new Size(1022, 760);
            panel4.TabIndex = 8;
            // 
            // frmMenuAdmin
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 228, 225);
            ClientSize = new Size(1048, 842);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 12F);
            Name = "frmMenuAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menú Administrador";
            ((System.ComponentModel.ISupportInitialize)btnCerrarSesion).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbCerrarSesion).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox btnCerrarSesion;
        private PictureBox pbLogo;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button btnInventario;
        private Button btnVentas;
        private Button btnProveedores;
        private Button btnReportes;
        private PictureBox pbCerrarSesion;
        private Panel panel4;
    }
}