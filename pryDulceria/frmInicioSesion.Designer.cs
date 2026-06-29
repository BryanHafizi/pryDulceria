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
            lblPassword = new Label();
            txtPassword = new TextBox();
            lblRol = new Label();
            cmbRol = new ComboBox();
            btnAcceder = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(50, 206);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(67, 21);
            lblUsuario.TabIndex = 6;
            lblUsuario.Text = "Usuario:";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(50, 230);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(280, 29);
            txtUsuario.TabIndex = 5;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(50, 276);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(92, 21);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Contraseña:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(50, 300);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(280, 29);
            txtPassword.TabIndex = 3;
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Location = new Point(50, 127);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(122, 21);
            lblRol.TabIndex = 2;
            lblRol.Text = "Tipo de Usuario:";
            // 
            // cmbRol
            // 
            cmbRol.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRol.FormattingEnabled = true;
            cmbRol.Items.AddRange(new object[] { "Administrador", "Cajero" });
            cmbRol.Location = new Point(50, 163);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(280, 29);
            cmbRol.TabIndex = 1;
            // 
            // btnAcceder
            // 
            btnAcceder.BackColor = Color.FromArgb(255, 105, 180);
            btnAcceder.FlatStyle = FlatStyle.Flat;
            btnAcceder.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAcceder.ForeColor = Color.White;
            btnAcceder.Location = new Point(50, 370);
            btnAcceder.Name = "btnAcceder";
            btnAcceder.Size = new Size(280, 40);
            btnAcceder.TabIndex = 0;
            btnAcceder.Text = "Acceder";
            btnAcceder.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(61, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(257, 92);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // frmInicioSesion
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 228, 225);
            ClientSize = new Size(384, 461);
            Controls.Add(pictureBox1);
            Controls.Add(btnAcceder);
            Controls.Add(cmbRol);
            Controls.Add(lblRol);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtUsuario);
            Controls.Add(lblUsuario);
            Font = new Font("Segoe UI", 12F);
            Name = "frmInicioSesion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Acceso al Sistema";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.ComboBox cmbRol;
        private System.Windows.Forms.Button btnAcceder;
        private PictureBox pictureBox1;
    }
}