namespace pryDulceria
{
    partial class frmUsuariosEdicion
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
            txtPassword = new TextBox();
            lblPassword = new Label();
            txtUsuario = new TextBox();
            btnAceptar = new Button();
            lblUsuario = new Label();
            lblTitulo = new Label();
            pcbUsuario = new PictureBox();
            cmbRol = new ComboBox();
            lblRol = new Label();
            ((System.ComponentModel.ISupportInitialize)pcbUsuario).BeginInit();
            SuspendLayout();
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 12F);
            txtPassword.ForeColor = Color.Black;
            txtPassword.Location = new Point(330, 160);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(260, 34);
            txtPassword.TabIndex = 46;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword.ForeColor = Color.Black;
            lblPassword.Location = new Point(230, 160);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(97, 28);
            lblPassword.TabIndex = 45;
            lblPassword.Text = "Password:";
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 12F);
            txtUsuario.ForeColor = Color.Black;
            txtUsuario.Location = new Point(330, 100);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(260, 34);
            txtUsuario.TabIndex = 44;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.HotPink;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAceptar.ForeColor = Color.White;
            btnAceptar.Location = new Point(380, 300);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(150, 51);
            btnAceptar.TabIndex = 42;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnGuardar_Click;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsuario.ForeColor = Color.Black;
            lblUsuario.Location = new Point(230, 100);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(83, 28);
            lblUsuario.TabIndex = 43;
            lblUsuario.Text = "Usuario:";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.Black;
            lblTitulo.Location = new Point(12, 13);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(289, 54);
            lblTitulo.TabIndex = 41;
            lblTitulo.Text = "Editar Usuario";
            // 
            // pcbUsuario
            // 
            pcbUsuario.Image = Properties.Resources._1782681922009;
            pcbUsuario.Location = new Point(300, 13);
            pcbUsuario.Name = "pcbUsuario";
            pcbUsuario.Size = new Size(100, 50);
            pcbUsuario.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbUsuario.TabIndex = 40;
            pcbUsuario.TabStop = false;
            // 
            // cmbRol
            // 
            cmbRol.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRol.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbRol.FormattingEnabled = true;
            cmbRol.Location = new Point(330, 220);
            cmbRol.Margin = new Padding(3, 4, 3, 4);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(260, 36);
            cmbRol.TabIndex = 47;
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRol.ForeColor = Color.Black;
            lblRol.Location = new Point(230, 220);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(44, 28);
            lblRol.TabIndex = 48;
            lblRol.Text = "Rol:";
            // 
            // frmUsuariosEdicion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(782, 553);
            Controls.Add(lblRol);
            Controls.Add(cmbRol);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtUsuario);
            Controls.Add(btnAceptar);
            Controls.Add(lblUsuario);
            Controls.Add(lblTitulo);
            Controls.Add(pcbUsuario);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmUsuariosEdicion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Módulo de Edición de Usuarios";
            ((System.ComponentModel.ISupportInitialize)pcbUsuario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox5;
        private Label lblCambio;
        private TextBox textBox4;
        private Label lblMontoRecibido;
        private TextBox textBox3;
        private Label lblTotalPagar;
        private TextBox txtPassword;
        private Label lblPassword;
        private TextBox txtUsuario;
        private Button btnAceptar;
        private Label lblUsuario;
        private Label lblTitulo;
        private PictureBox pcbUsuario;
        private ComboBox cmbRol;
        private Label lblRol;
    }
}