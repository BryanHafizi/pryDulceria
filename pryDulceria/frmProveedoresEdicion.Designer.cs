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
            txtApellidoP = new TextBox();
            lblApellidoP = new Label();
            txtNombre = new TextBox();
            btnAceptar = new Button();
            lblNombre = new Label();
            lblTitulo = new Label();
            pcbProveedor = new PictureBox();
            txtTelSecundario = new TextBox();
            lblTelSecundario = new Label();
            txtTel = new TextBox();
            lblTel = new Label();
            txtApellidoM = new TextBox();
            lblApellidoM = new Label();
            ((System.ComponentModel.ISupportInitialize)pcbProveedor).BeginInit();
            SuspendLayout();
            // 
            // txtApellidoP
            // 

            txtAp.Font = new Font("Segoe UI", 12F);
            txtAp.ForeColor = Color.Black;
            txtAp.Location = new Point(164, 102);
            txtAp.Margin = new Padding(3, 2, 3, 2);
            txtAp.Name = "txtAp";
            txtAp.Size = new Size(263, 29);
            txtAp.TabIndex = 55;

            txtApellidoP.Font = new Font("Segoe UI", 12F);
            txtApellidoP.ForeColor = Color.Black;
            txtApellidoP.Location = new Point(350, 160);
            txtApellidoP.Name = "txtApellidoP";
            txtApellidoP.Size = new Size(300, 34);
            txtApellidoP.TabIndex = 55;

            // 
            // lblApellidoP
            // 

            lblAp.AutoSize = true;
            lblAp.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAp.ForeColor = Color.Black;
            lblAp.Location = new Point(12, 105);
            lblAp.Name = "lblAp";
            lblAp.Size = new Size(128, 21);
            lblAp.TabIndex = 54;
            lblAp.Text = "Apellido paterno:";

            lblApellidoP.AutoSize = true;
            lblApellidoP.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblApellidoP.ForeColor = Color.Black;
            lblApellidoP.Location = new Point(160, 160);
            lblApellidoP.Name = "lblApellidoP";
            lblApellidoP.Size = new Size(164, 28);
            lblApellidoP.TabIndex = 54;
            lblApellidoP.Text = "Apellido paterno:";

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

            btnAceptar.BackColor = Color.HotPink;
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAceptar.ForeColor = Color.White;
            btnAceptar.Location = new Point(380, 400);

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
            // pcbProveedor
            // 

            pcbIcono.Image = Properties.Resources._1782681922009;
            pcbIcono.Location = new Point(12, 11);
            pcbIcono.Margin = new Padding(3, 2, 3, 2);
            pcbIcono.Name = "pcbIcono";
            pcbIcono.Size = new Size(88, 38);
            pcbIcono.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbIcono.TabIndex = 49;
            pcbIcono.TabStop = false;

            pcbProveedor.Image = Properties.Resources._1782681922009;
            pcbProveedor.Location = new Point(350, 13);
            pcbProveedor.Name = "pcbProveedor";
            pcbProveedor.Size = new Size(101, 51);
            pcbProveedor.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbProveedor.TabIndex = 49;
            pcbProveedor.TabStop = false;

            // 
            // txtTelSecundario
            // 
            txtTelSecundario.Font = new Font("Segoe UI", 12F);
            txtTelSecundario.ForeColor = Color.Black;

            txtTelSecundario.Location = new Point(164, 213);
            txtTelSecundario.Margin = new Padding(3, 2, 3, 2);

            txtTelSecundario.Location = new Point(350, 340);

            txtTelSecundario.Name = "txtTelSecundario";
            txtTelSecundario.Size = new Size(263, 29);
            txtTelSecundario.TabIndex = 59;
            // 
            // lblTelSecundario
            // 

            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(7, 216);
            label1.Name = "label1";
            label1.Size = new Size(151, 21);
            label1.TabIndex = 58;
            label1.Text = "Telefono secundario:\r\n";

            lblTelSecundario.AutoSize = true;
            lblTelSecundario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTelSecundario.ForeColor = Color.Black;
            lblTelSecundario.Location = new Point(160, 340);
            lblTelSecundario.Name = "lblTelSecundario";
            lblTelSecundario.Size = new Size(190, 28);
            lblTelSecundario.TabIndex = 58;
            lblTelSecundario.Text = "Telefono secundario:\r\n";

            // 
            // txtTel
            // 
            txtTel.Font = new Font("Segoe UI", 12F);
            txtTel.ForeColor = Color.Black;

            txtTel.Location = new Point(164, 175);
            txtTel.Margin = new Padding(3, 2, 3, 2);

            txtTel.Location = new Point(350, 280);

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

            // lblTel
            // 
            lblTel.AutoSize = true;
            lblTel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTel.ForeColor = Color.Black;
            lblTel.Location = new Point(160, 280);
            lblTel.Name = "lblTel";
            lblTel.Size = new Size(90, 28);
            lblTel.TabIndex = 62;
            lblTel.Text = "Telefono:";
            // 
            // txtApellidoM
            // 
            txtApellidoM.Font = new Font("Segoe UI", 12F);
            txtApellidoM.ForeColor = Color.Black;
            txtApellidoM.Location = new Point(350, 220);
            txtApellidoM.Name = "txtApellidoM";
            txtApellidoM.Size = new Size(300, 34);
            txtApellidoM.TabIndex = 61;
            // 
            // lblApellidoM
            // 
            lblApellidoM.AutoSize = true;
            lblApellidoM.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblApellidoM.ForeColor = Color.Black;
            lblApellidoM.Location = new Point(160, 220);
            lblApellidoM.Name = "lblApellidoM";
            lblApellidoM.Size = new Size(169, 28);
            lblApellidoM.TabIndex = 60;
            lblApellidoM.Text = "Apellido materno:";

            // 
            // frmProveedoresEdicion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(838, 271);
            Controls.Add(txtTel);
            Controls.Add(lblTel);
            Controls.Add(txtApellidoM);
            Controls.Add(lblApellidoM);
            Controls.Add(txtTelSecundario);
            Controls.Add(lblTelSecundario);
            Controls.Add(txtApellidoP);
            Controls.Add(lblApellidoP);
            Controls.Add(txtNombre);
            Controls.Add(btnAceptar);
            Controls.Add(lblNombre);
            Controls.Add(lblTitulo);

            Controls.Add(pcbIcono);

            Controls.Add(pcbProveedor);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);

            Name = "frmProveedoresEdicion";
            Text = "Módulo de Edición de Proveedores";
            ((System.ComponentModel.ISupportInitialize)pcbProveedor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtApellidoP;
        private Label lblApellidoP;
        private TextBox txtNombre;
        private Button btnAceptar;
        private Label lblNombre;
        private Label lblTitulo;
        private PictureBox pcbProveedor;
        private TextBox txtTelSecundario;
        private Label lblTelSecundario;
        private TextBox txtTel;
        private Label lblTel;
        private TextBox txtApellidoM;
        private Label lblApellidoM;
    }
}