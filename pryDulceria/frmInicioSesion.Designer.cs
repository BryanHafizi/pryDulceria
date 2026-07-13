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
            txtPassword = new TextBox();
            lblTipoUsuario = new Label();
            cmbRol = new ComboBox();
            btnAcceder = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(95, 265);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(83, 28);
            lblUsuario.TabIndex = 6;
            lblUsuario.Text = "Usuario:";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(95, 295);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(260, 34);
            txtUsuario.TabIndex = 5;
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Location = new Point(95, 340);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(114, 28);
            lblContraseña.TabIndex = 4;
            lblContraseña.Text = "Contraseña:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(95, 370);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(260, 34);
            txtPassword.TabIndex = 3;
            // 
            // lblTipoUsuario
            // 
            lblTipoUsuario.AutoSize = true;
            lblTipoUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTipoUsuario.Location = new Point(95, 190);
            lblTipoUsuario.Name = "lblTipoUsuario";
            lblTipoUsuario.Size = new Size(154, 28);
            lblTipoUsuario.TabIndex = 2;
            lblTipoUsuario.Text = "Tipo de Usuario:";
            // 
            // cmbRol
            // 
            cmbRol.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRol.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbRol.FormattingEnabled = true;
            cmbRol.Items.AddRange(new object[] { "Administrador", "Cajero" });
            cmbRol.Location = new Point(95, 220);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(260, 36);
            cmbRol.TabIndex = 1;
            // 
            // btnAcceder
            // 
            btnAcceder.BackColor = Color.FromArgb(255, 105, 180);
            btnAcceder.FlatStyle = FlatStyle.Flat;
            btnAcceder.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAcceder.ForeColor = Color.White;
            btnAcceder.Location = new Point(150, 440);
            btnAcceder.Name = "btnAcceder";
            btnAcceder.Size = new Size(150, 40);
            btnAcceder.TabIndex = 0;
            btnAcceder.Text = "Acceder";
            btnAcceder.UseVisualStyleBackColor = false;
            btnAcceder.Click += btnAcceder_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(95, 50);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(260, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // frmInicioSesion
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 228, 225);
            ClientSize = new Size(432, 553);
            Controls.Add(pictureBox1);
            Controls.Add(btnAcceder);
            Controls.Add(cmbRol);
            Controls.Add(lblTipoUsuario);
            Controls.Add(txtPassword);
            Controls.Add(lblContraseña);
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
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblTipoUsuario;
        private System.Windows.Forms.ComboBox cmbRol;
        private System.Windows.Forms.Button btnAcceder;
        private PictureBox pictureBox1;
    }
}