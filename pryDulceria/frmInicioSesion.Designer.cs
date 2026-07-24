namespace pryDulceria
{
    partial class frmInicioSesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicioSesion));
            lblUsuario = new Label();
            txtUsuario = new TextBox();
            lblContraseña = new Label();
            txtContraseña = new TextBox();
            btnAcceder = new Button();
            pcbLogo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pcbLogo).BeginInit();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(95, 180);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(83, 28);
            lblUsuario.TabIndex = 6;
            lblUsuario.Text = "Usuario:";
            // 
            // txtUsuario
            // 
            txtUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtUsuario.Location = new Point(95, 210);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(260, 34);
            txtUsuario.TabIndex = 0;
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Location = new Point(95, 270);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(114, 28);
            lblContraseña.TabIndex = 4;
            lblContraseña.Text = "Contraseña:";
            // 
            // txtContraseña
            // 
            txtContraseña.BorderStyle = BorderStyle.FixedSingle;
            txtContraseña.Location = new Point(95, 310);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '*';
            txtContraseña.Size = new Size(260, 34);
            txtContraseña.TabIndex = 1;
            // 
            // btnAcceder
            // 
            btnAcceder.BackColor = Color.FromArgb(194, 24, 91);
            btnAcceder.FlatStyle = FlatStyle.Flat;
            btnAcceder.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAcceder.ForeColor = Color.White;
            btnAcceder.Location = new Point(150, 380);
            btnAcceder.Name = "btnAcceder";
            btnAcceder.Size = new Size(150, 50);
            btnAcceder.TabIndex = 2;
            btnAcceder.Text = "Acceder";
            btnAcceder.UseVisualStyleBackColor = false;
            btnAcceder.Click += btnAcceder_Click_1;
            // 
            // pcbLogo
            // 
            pcbLogo.Image = (Image)resources.GetObject("pcbLogo.Image");
            pcbLogo.Location = new Point(125, 60);
            pcbLogo.Name = "pcbLogo";
            pcbLogo.Size = new Size(200, 100);
            pcbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbLogo.TabIndex = 7;
            pcbLogo.TabStop = false;
            // 
            // frmInicioSesion
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 242, 245);
            ClientSize = new Size(432, 503);
            Controls.Add(pcbLogo);
            Controls.Add(btnAcceder);
            Controls.Add(txtContraseña);
            Controls.Add(lblContraseña);
            Controls.Add(txtUsuario);
            Controls.Add(lblUsuario);
            Font = new Font("Segoe UI", 12F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmInicioSesion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Acceso al Sistema";
            ((System.ComponentModel.ISupportInitialize)pcbLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Button btnAcceder;
        private PictureBox pcbLogo;
    }
}