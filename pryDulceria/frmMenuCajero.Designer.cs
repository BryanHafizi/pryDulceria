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
            pnlOpciones = new Panel();
            pbCerrarSesion = new PictureBox();
            lblBienvenida = new Label();
            btnReportes = new Button();
            btnInventario = new Button();
            btnVentas = new Button();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            pnlOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbCerrarSesion).BeginInit();
            SuspendLayout();
            // 
            // pbLogo
            // 
            pbLogo.Image = Properties.Resources.Screenshot_2026_06_28_220345_removebg_preview;
            pbLogo.Location = new Point(382, 30);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(260, 100);
            pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogo.TabIndex = 4;
            pbLogo.TabStop = false;
            // 
            // pnlOpciones
            // 
            pnlOpciones.BackColor = Color.FromArgb(255, 192, 203);
            pnlOpciones.Controls.Add(pbCerrarSesion);
            pnlOpciones.Controls.Add(lblBienvenida);
            pnlOpciones.Controls.Add(btnReportes);
            pnlOpciones.Controls.Add(btnInventario);
            pnlOpciones.Controls.Add(btnVentas);
            pnlOpciones.Location = new Point(102, 150);
            pnlOpciones.Name = "pnlOpciones";
            pnlOpciones.Size = new Size(820, 420);
            pnlOpciones.TabIndex = 3;
            // 
            // pbCerrarSesion
            // 
            pbCerrarSesion.Image = Properties.Resources.Screenshot_2026_06_28_224006;
            pbCerrarSesion.Location = new Point(656, 350);
            pbCerrarSesion.Name = "pbCerrarSesion";
            pbCerrarSesion.Size = new Size(120, 40);
            pbCerrarSesion.SizeMode = PictureBoxSizeMode.StretchImage;
            pbCerrarSesion.TabIndex = 4;
            pbCerrarSesion.TabStop = false;
            // 
            // lblBienvenida
            // 
            lblBienvenida.AutoSize = true;
            lblBienvenida.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblBienvenida.ForeColor = Color.FromArgb(51, 51, 51);
            lblBienvenida.Location = new Point(150, 30);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(553, 46);
            lblBienvenida.TabIndex = 2;
            lblBienvenida.Text = "Panel de Cajero - Dulcería Marlyn";
            // 
            // btnReportes
            // 
            btnReportes.BackColor = Color.FromArgb(255, 105, 180);
            btnReportes.FlatStyle = FlatStyle.Flat;
            btnReportes.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReportes.ForeColor = Color.White;
            btnReportes.Location = new Point(450, 150);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(150, 150);
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
            btnVentas.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVentas.ForeColor = Color.White;
            btnVentas.Location = new Point(220, 150);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(150, 150);
            btnVentas.TabIndex = 2;
            btnVentas.Text = "Ventas";
            btnVentas.UseVisualStyleBackColor = false;
            // 
            // frmMenuCajero
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(1006, 721);
            Controls.Add(pbLogo);
            Controls.Add(pnlOpciones);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "frmMenuCajero";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Cajero";
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            pnlOpciones.ResumeLayout(false);
            pnlOpciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbCerrarSesion).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbLogo;
        private Panel pnlOpciones;
        private PictureBox pbCerrarSesion;
        private Label lblBienvenida;
        private Button btnReportes;
        private Button btnInventario;
        private Button btnVentas;
    }
}