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
            pcbIcono = new PictureBox();
            cmbRol = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pcbIcono).BeginInit();
            SuspendLayout();
            // 
            // txtPassword
            // 
            txtPassword.ForeColor = Color.Black;
            txtPassword.Location = new Point(184, 121);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(263, 23);
            txtPassword.TabIndex = 46;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword.ForeColor = Color.Black;
            lblPassword.Location = new Point(99, 119);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(79, 21);
            lblPassword.TabIndex = 45;
            lblPassword.Text = "Password:";
            // 
            // txtUsuario
            // 
            txtUsuario.ForeColor = Color.Black;
            txtUsuario.Location = new Point(184, 83);
            txtUsuario.Margin = new Padding(3, 2, 3, 2);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(263, 23);
            txtUsuario.TabIndex = 44;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.FromArgb(240, 128, 128);
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAceptar.ForeColor = Color.White;
            btnAceptar.Location = new Point(201, 276);
            btnAceptar.Margin = new Padding(3, 2, 3, 2);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(131, 38);
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
            lblUsuario.Location = new Point(99, 81);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(67, 21);
            lblUsuario.TabIndex = 43;
            lblUsuario.Text = "Usuario:";
            lblUsuario.Click += lblTotal_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.Black;
            lblTitulo.Location = new Point(10, 8);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(232, 45);
            lblTitulo.TabIndex = 41;
            lblTitulo.Text = "Editar Usuario";
            lblTitulo.Click += lblTitulo_Click;
            // 
            // pcbIcono
            // 
            pcbIcono.Image = Properties.Resources._1782681922009;
            pcbIcono.Location = new Point(385, 8);
            pcbIcono.Margin = new Padding(3, 2, 3, 2);
            pcbIcono.Name = "pcbIcono";
            pcbIcono.Size = new Size(88, 38);
            pcbIcono.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbIcono.TabIndex = 40;
            pcbIcono.TabStop = false;
            // 
            // cmbRol
            // 
            cmbRol.FormattingEnabled = true;
            cmbRol.Location = new Point(184, 165);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(263, 23);
            cmbRol.TabIndex = 47;
            // 
            // frmUsuariosEdicion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(553, 340);
            Controls.Add(cmbRol);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtUsuario);
            Controls.Add(btnAceptar);
            Controls.Add(lblUsuario);
            Controls.Add(lblTitulo);
            Controls.Add(pcbIcono);
            Name = "frmUsuariosEdicion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmUsuariosEdicion";
            ((System.ComponentModel.ISupportInitialize)pcbIcono).EndInit();
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
        private PictureBox pcbIcono;
        private ComboBox cmbRol;
    }
}