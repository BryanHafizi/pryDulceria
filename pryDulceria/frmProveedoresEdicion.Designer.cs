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
            txtAP = new TextBox();
            lblAp = new Label();
            txtNombre = new TextBox();
            btnAceptar = new Button();
            lblNombre = new Label();
            lblTitulo = new Label();
            pcbProveedores = new PictureBox();
            txtTelSecundario = new TextBox();
            lblTelefonoSecundario = new Label();
            txtTel = new TextBox();
            lblTel = new Label();
            txtAM = new TextBox();
            lblAm = new Label();
            ((System.ComponentModel.ISupportInitialize)pcbProveedores).BeginInit();
            SuspendLayout();
            // 
            // txtAP
            // 
            txtAP.BorderStyle = BorderStyle.FixedSingle;
            txtAP.Font = new Font("Segoe UI", 12F);
            txtAP.ForeColor = Color.Black;
            txtAP.Location = new Point(300, 150);
            txtAP.Name = "txtAP";
            txtAP.Size = new Size(260, 34);
            txtAP.TabIndex = 55;
            // 
            // lblAp
            // 
            lblAp.AutoSize = true;
            lblAp.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAp.ForeColor = Color.Black;
            lblAp.Location = new Point(100, 150);
            lblAp.Name = "lblAp";
            lblAp.Size = new Size(164, 28);
            lblAp.TabIndex = 54;
            lblAp.Text = "Apellido paterno:";
            // 
            // txtNombre
            // 
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Font = new Font("Segoe UI", 12F);
            txtNombre.ForeColor = Color.Black;
            txtNombre.Location = new Point(300, 100);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(260, 34);
            txtNombre.TabIndex = 53;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.FromArgb(194, 24, 91);
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAceptar.ForeColor = Color.White;
            btnAceptar.Location = new Point(350, 366);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(150, 50);
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
            lblNombre.Location = new Point(100, 100);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(89, 28);
            lblNombre.TabIndex = 52;
            lblNombre.Text = "Nombre:";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.Black;
            lblTitulo.Location = new Point(12, 13);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(341, 54);
            lblTitulo.TabIndex = 50;
            lblTitulo.Text = "Editar Proveedor";
            // 
            // pcbProveedores
            // 
            pcbProveedores.Image = Properties.Resources._1782681922009;
            pcbProveedores.Location = new Point(350, 13);
            pcbProveedores.Name = "pcbProveedores";
            pcbProveedores.Size = new Size(101, 51);
            pcbProveedores.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbProveedores.TabIndex = 49;
            pcbProveedores.TabStop = false;
            // 
            // txtTelSecundario
            // 
            txtTelSecundario.BorderStyle = BorderStyle.FixedSingle;
            txtTelSecundario.Font = new Font("Segoe UI", 12F);
            txtTelSecundario.ForeColor = Color.Black;
            txtTelSecundario.Location = new Point(300, 300);
            txtTelSecundario.Name = "txtTelSecundario";
            txtTelSecundario.Size = new Size(260, 34);
            txtTelSecundario.TabIndex = 59;
            // 
            // lblTelefonoSecundario
            // 
            lblTelefonoSecundario.AutoSize = true;
            lblTelefonoSecundario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTelefonoSecundario.ForeColor = Color.Black;
            lblTelefonoSecundario.Location = new Point(100, 300);
            lblTelefonoSecundario.Name = "lblTelefonoSecundario";
            lblTelefonoSecundario.Size = new Size(190, 28);
            lblTelefonoSecundario.TabIndex = 58;
            lblTelefonoSecundario.Text = "Teléfono secundario:\r\n";
            // 
            // txtTel
            // 
            txtTel.BorderStyle = BorderStyle.FixedSingle;
            txtTel.Font = new Font("Segoe UI", 12F);
            txtTel.ForeColor = Color.Black;
            txtTel.Location = new Point(300, 250);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(260, 34);
            txtTel.TabIndex = 63;
            // 
            // lblTel
            // 
            lblTel.AutoSize = true;
            lblTel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTel.ForeColor = Color.Black;
            lblTel.Location = new Point(100, 250);
            lblTel.Name = "lblTel";
            lblTel.Size = new Size(90, 28);
            lblTel.TabIndex = 62;
            lblTel.Text = "Teléfono:";
            // 
            // txtAM
            // 
            txtAM.BorderStyle = BorderStyle.FixedSingle;
            txtAM.Font = new Font("Segoe UI", 12F);
            txtAM.ForeColor = Color.Black;
            txtAM.Location = new Point(300, 200);
            txtAM.Name = "txtAM";
            txtAM.Size = new Size(260, 34);
            txtAM.TabIndex = 61;
            // 
            // lblAm
            // 
            lblAm.AutoSize = true;
            lblAm.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAm.ForeColor = Color.Black;
            lblAm.Location = new Point(100, 200);
            lblAm.Name = "lblAm";
            lblAm.Size = new Size(169, 28);
            lblAm.TabIndex = 60;
            lblAm.Text = "Apellido materno:";
            // 
            // frmProveedoresEdicion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 242, 245);
            ClientSize = new Size(632, 453);
            Controls.Add(txtTel);
            Controls.Add(lblTel);
            Controls.Add(txtAM);
            Controls.Add(lblAm);
            Controls.Add(txtTelSecundario);
            Controls.Add(lblTelefonoSecundario);
            Controls.Add(txtAP);
            Controls.Add(lblAp);
            Controls.Add(txtNombre);
            Controls.Add(btnAceptar);
            Controls.Add(lblNombre);
            Controls.Add(lblTitulo);
            Controls.Add(pcbProveedores);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmProveedoresEdicion";
            Text = "Editar Proveedor ";
            ((System.ComponentModel.ISupportInitialize)pcbProveedores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtAP;
        private Label lblAp;
        private TextBox txtNombre;
        private Button btnAceptar;
        private Label lblNombre;
        private Label lblTitulo;
        private PictureBox pcbProveedores;
        private TextBox txtTelSecundario;
        private Label lblTelefonoSecundario;
        private TextBox txtTel;
        private Label lblTel;
        private TextBox txtAM;
        private Label lblAm;
    }
}