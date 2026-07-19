namespace pryDulceria
{
    partial class frmProveedoresEdicion
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
            txtAp = new TextBox();
            lblAp = new Label();
            txtNombre = new TextBox();
            btnAceptar = new Button();
            lblNombre = new Label();
            lblTitulo = new Label();
            pcbIcono = new PictureBox();
            txtTelSecundario = new TextBox();
            label1 = new Label();
            txtTel = new TextBox();
            label3 = new Label();
            txtAm = new TextBox();
            lblAm = new Label();
            ((System.ComponentModel.ISupportInitialize)pcbIcono).BeginInit();
            SuspendLayout();
            // 
            // txtAp
            // 
            txtAp.Font = new Font("Segoe UI", 12F);
            txtAp.ForeColor = Color.Black;
            txtAp.Location = new Point(164, 102);
            txtAp.Margin = new Padding(3, 2, 3, 2);
            txtAp.Name = "txtAp";
            txtAp.Size = new Size(263, 29);
            txtAp.TabIndex = 55;
            // 
            // lblAp
            // 
            lblAp.AutoSize = true;
            lblAp.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAp.ForeColor = Color.Black;
            lblAp.Location = new Point(12, 105);
            lblAp.Name = "lblAp";
            lblAp.Size = new Size(128, 21);
            lblAp.TabIndex = 54;
            lblAp.Text = "Apellido paterno:";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 12F);
            txtNombre.ForeColor = Color.Black;
            txtNombre.Location = new Point(164, 66);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(263, 29);
            txtNombre.TabIndex = 53;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.FromArgb(77, 130, 188);
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAceptar.ForeColor = Color.White;
            btnAceptar.Location = new Point(462, 207);
            btnAceptar.Margin = new Padding(3, 2, 3, 2);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(131, 38);
            btnAceptar.TabIndex = 51;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnGuardar_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombre.ForeColor = Color.Black;
            lblNombre.Location = new Point(12, 69);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(71, 21);
            lblNombre.TabIndex = 52;
            lblNombre.Text = "Nombre:";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.Black;
            lblTitulo.Location = new Point(106, 12);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(235, 37);
            lblTitulo.TabIndex = 50;
            lblTitulo.Text = "Editar Proveedor";
            // 
            // pcbIcono
            // 
            pcbIcono.Image = Properties.Resources._1782681922009;
            pcbIcono.Location = new Point(12, 11);
            pcbIcono.Margin = new Padding(3, 2, 3, 2);
            pcbIcono.Name = "pcbIcono";
            pcbIcono.Size = new Size(88, 38);
            pcbIcono.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbIcono.TabIndex = 49;
            pcbIcono.TabStop = false;
            // 
            // txtTelSecundario
            // 
            txtTelSecundario.Font = new Font("Segoe UI", 12F);
            txtTelSecundario.ForeColor = Color.Black;
            txtTelSecundario.Location = new Point(164, 213);
            txtTelSecundario.Margin = new Padding(3, 2, 3, 2);
            txtTelSecundario.Name = "txtTelSecundario";
            txtTelSecundario.Size = new Size(263, 29);
            txtTelSecundario.TabIndex = 59;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(7, 216);
            label1.Name = "label1";
            label1.Size = new Size(151, 21);
            label1.TabIndex = 58;
            label1.Text = "Telefono secundario:\r\n";
            // 
            // txtTel
            // 
            txtTel.Font = new Font("Segoe UI", 12F);
            txtTel.ForeColor = Color.Black;
            txtTel.Location = new Point(164, 175);
            txtTel.Margin = new Padding(3, 2, 3, 2);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(263, 29);
            txtTel.TabIndex = 63;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(12, 178);
            label3.Name = "label3";
            label3.Size = new Size(71, 21);
            label3.TabIndex = 62;
            label3.Text = "Telefono:";
            // 
            // txtAm
            // 
            txtAm.Font = new Font("Segoe UI", 12F);
            txtAm.ForeColor = Color.Black;
            txtAm.Location = new Point(164, 137);
            txtAm.Margin = new Padding(3, 2, 3, 2);
            txtAm.Name = "txtAm";
            txtAm.Size = new Size(263, 29);
            txtAm.TabIndex = 61;
            // 
            // lblAm
            // 
            lblAm.AutoSize = true;
            lblAm.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAm.ForeColor = Color.Black;
            lblAm.Location = new Point(7, 140);
            lblAm.Name = "lblAm";
            lblAm.Size = new Size(133, 21);
            lblAm.TabIndex = 60;
            lblAm.Text = "Apellido materno:";
            // 
            // frmProveedoresEdicion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(838, 271);
            Controls.Add(txtTel);
            Controls.Add(label3);
            Controls.Add(txtAm);
            Controls.Add(lblAm);
            Controls.Add(txtTelSecundario);
            Controls.Add(label1);
            Controls.Add(txtAp);
            Controls.Add(lblAp);
            Controls.Add(txtNombre);
            Controls.Add(btnAceptar);
            Controls.Add(lblNombre);
            Controls.Add(lblTitulo);
            Controls.Add(pcbIcono);
            Name = "frmProveedoresEdicion";
            Text = "Editar Proveedor ";
            ((System.ComponentModel.ISupportInitialize)pcbIcono).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtAp;
        private Label lblAp;
        private TextBox txtNombre;
        private Button btnAceptar;
        private Label lblNombre;
        private Label lblTitulo;
        private PictureBox pcbIcono;
        private TextBox txtTelSecundario;
        private Label label1;
        private TextBox txtTel;
        private Label label3;
        private TextBox txtAm;
        private Label lblAm;
    }
}