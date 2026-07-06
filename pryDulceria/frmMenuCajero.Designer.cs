namespace pryDulceria
{
    partial class frmMenuCajero
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pbLogo = new PictureBox();
            pnlContenedorMenu = new Panel();
            pbCerrarSesion = new PictureBox();
            lblBienvenida = new Label();
            btnReportes = new Button();
            btnInventario = new Button();
            btnVentas = new Button();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            pnlContenedorMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbCerrarSesion).BeginInit();
            SuspendLayout();
            // 
            // pbLogo
            // 
            pbLogo.Image = Properties.Resources.Screenshot_2026_06_28_220345_removebg_preview;
            pbLogo.Location = new Point(406, 12);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(238, 82);
            pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogo.TabIndex = 4;
            pbLogo.TabStop = false;
            // 
            // pnlContenedorMenu
            // 
            pnlContenedorMenu.BackColor = Color.FromArgb(255, 192, 203);
            pnlContenedorMenu.Controls.Add(pbCerrarSesion);
            pnlContenedorMenu.Controls.Add(lblBienvenida);
            pnlContenedorMenu.Controls.Add(btnReportes);
            pnlContenedorMenu.Controls.Add(btnInventario);
            pnlContenedorMenu.Controls.Add(btnVentas);
            pnlContenedorMenu.Location = new Point(34, 100);
            pnlContenedorMenu.Name = "pnlContenedorMenu";
            pnlContenedorMenu.Size = new Size(950, 400);
            pnlContenedorMenu.TabIndex = 3;
            // 
            // pbCerrarSesion
            // 
            pbCerrarSesion.Image = Properties.Resources.Screenshot_2026_06_28_224006;
            pbCerrarSesion.Location = new Point(832, 333);
            pbCerrarSesion.Name = "pbCerrarSesion";
            pbCerrarSesion.Size = new Size(100, 35);
            pbCerrarSesion.SizeMode = PictureBoxSizeMode.StretchImage;
            pbCerrarSesion.TabIndex = 4;
            pbCerrarSesion.TabStop = false;
            // 
            // lblBienvenida
            // 
            lblBienvenida.AutoSize = true;
            lblBienvenida.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblBienvenida.ForeColor = Color.FromArgb(51, 51, 51);
            lblBienvenida.Location = new Point(240, 40);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(459, 37);
            lblBienvenida.TabIndex = 2;
            lblBienvenida.Text = "Panel de Control - Dulcería Marlyn";
            // 
            // btnReportes
            // 
            btnReportes.BackColor = Color.FromArgb(255, 105, 180);
            btnReportes.FlatStyle = FlatStyle.Flat;
            btnReportes.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnReportes.ForeColor = Color.White;
            btnReportes.Location = new Point(533, 120);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(166, 150);
            btnReportes.TabIndex = 3;
            btnReportes.Text = "Reportes";
            btnReportes.UseVisualStyleBackColor = false;
            // 
            // btnInventario
            // 
            btnInventario.BackColor = Color.FromArgb(255, 105, 180);
            btnInventario.FlatStyle = FlatStyle.Flat;
            btnInventario.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnInventario.ForeColor = Color.White;
            btnInventario.Location = new Point(281, 120);
            btnInventario.Name = "btnInventario";
            btnInventario.Size = new Size(0, 0);
            btnInventario.TabIndex = 1;
            btnInventario.Text = "Inventario";
            btnInventario.UseVisualStyleBackColor = false;
            // 
            // btnVentas
            // 
            btnVentas.BackColor = Color.FromArgb(255, 105, 180);
            btnVentas.FlatStyle = FlatStyle.Flat;
            btnVentas.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnVentas.ForeColor = Color.White;
            btnVentas.Location = new Point(240, 120);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(161, 150);
            btnVentas.TabIndex = 2;
            btnVentas.Text = "Ventas";
            btnVentas.UseVisualStyleBackColor = false;
            // 
            // frmMenuCajero
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(1024, 749);
            Controls.Add(pbLogo);
            Controls.Add(pnlContenedorMenu);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4, 4, 4, 4);
            Name = "frmMenuCajero";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Cajero";
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            pnlContenedorMenu.ResumeLayout(false);
            pnlContenedorMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbCerrarSesion).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbLogo;
        private Panel pnlContenedorMenu;
        private PictureBox pbCerrarSesion;
        private Label lblBienvenida;
        private Button btnReportes;
        private Button btnInventario;
        private Button btnVentas;
    }
}