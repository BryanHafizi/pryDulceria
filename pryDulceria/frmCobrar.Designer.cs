namespace pryDulceria
{
    partial class frmCobrar
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
            lblTitulo = new Label();
            pcbCarrito = new PictureBox();
            lblCambio = new Label();
            txtMontoRecibido = new TextBox();
            lblMontoRecibido = new Label();
            lblTotalPagar = new Label();
            btnVender = new Button();
            txtCambio = new TextBox();
            txtTotalAPagar = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pcbCarrito).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.Black;
            lblTitulo.Location = new Point(12, 13);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(354, 54);
            lblTitulo.TabIndex = 28;
            lblTitulo.Text = "Sistema de Cobro";
            // 
            // pcbCarrito
            // 
            pcbCarrito.Image = Properties.Resources.Code_Generated_Image;
            pcbCarrito.Location = new Point(365, 13);
            pcbCarrito.Name = "pcbCarrito";
            pcbCarrito.Size = new Size(100, 50);
            pcbCarrito.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbCarrito.TabIndex = 18;
            pcbCarrito.TabStop = false;
            // 
            // lblCambio
            // 
            lblCambio.AutoSize = true;
            lblCambio.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCambio.ForeColor = Color.Black;
            lblCambio.Location = new Point(94, 279);
            lblCambio.Name = "lblCambio";
            lblCambio.Size = new Size(84, 28);
            lblCambio.TabIndex = 38;
            lblCambio.Text = "Cambio:";
            // 
            // txtMontoRecibido
            // 
            txtMontoRecibido.BorderStyle = BorderStyle.FixedSingle;
            txtMontoRecibido.Font = new Font("Segoe UI", 12F);
            txtMontoRecibido.ForeColor = Color.Black;
            txtMontoRecibido.Location = new Point(299, 206);
            txtMontoRecibido.Name = "txtMontoRecibido";
            txtMontoRecibido.Size = new Size(243, 34);
            txtMontoRecibido.TabIndex = 1;
            // 
            // lblMontoRecibido
            // 
            lblMontoRecibido.AutoSize = true;
            lblMontoRecibido.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMontoRecibido.ForeColor = Color.Black;
            lblMontoRecibido.Location = new Point(92, 208);
            lblMontoRecibido.Name = "lblMontoRecibido";
            lblMontoRecibido.Size = new Size(157, 28);
            lblMontoRecibido.TabIndex = 36;
            lblMontoRecibido.Text = "Monto Recibido:";
            // 
            // lblTotalPagar
            // 
            lblTotalPagar.AutoSize = true;
            lblTotalPagar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalPagar.ForeColor = Color.Black;
            lblTotalPagar.Location = new Point(92, 143);
            lblTotalPagar.Name = "lblTotalPagar";
            lblTotalPagar.Size = new Size(127, 28);
            lblTotalPagar.TabIndex = 34;
            lblTotalPagar.Text = "Total a Pagar:";
            // 
            // btnVender
            // 
            btnVender.BackColor = Color.FromArgb(194, 24, 91);
            btnVender.FlatStyle = FlatStyle.Flat;
            btnVender.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnVender.ForeColor = Color.White;
            btnVender.Location = new Point(240, 353);
            btnVender.Name = "btnVender";
            btnVender.Size = new Size(150, 50);
            btnVender.TabIndex = 3;
            btnVender.Text = "Vender";
            btnVender.UseVisualStyleBackColor = false;
            // 
            // txtCambio
            // 
            txtCambio.BorderStyle = BorderStyle.FixedSingle;
            txtCambio.Font = new Font("Segoe UI", 12F);
            txtCambio.ForeColor = Color.Black;
            txtCambio.Location = new Point(299, 269);
            txtCambio.Name = "txtCambio";
            txtCambio.Size = new Size(243, 34);
            txtCambio.TabIndex = 2;
            // 
            // txtTotalAPagar
            // 
            txtTotalAPagar.BorderStyle = BorderStyle.FixedSingle;
            txtTotalAPagar.Font = new Font("Segoe UI", 12F);
            txtTotalAPagar.ForeColor = Color.Black;
            txtTotalAPagar.Location = new Point(299, 147);
            txtTotalAPagar.Name = "txtTotalAPagar";
            txtTotalAPagar.Size = new Size(243, 34);
            txtTotalAPagar.TabIndex = 0;
            // 
            // frmCobrar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 242, 245);
            ClientSize = new Size(632, 453);
            Controls.Add(txtTotalAPagar);
            Controls.Add(txtCambio);
            Controls.Add(btnVender);
            Controls.Add(lblCambio);
            Controls.Add(txtMontoRecibido);
            Controls.Add(lblMontoRecibido);
            Controls.Add(lblTotalPagar);
            Controls.Add(lblTitulo);
            Controls.Add(pcbCarrito);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmCobrar";
            Text = "Módulo de Cobro";
            ((System.ComponentModel.ISupportInitialize)pcbCarrito).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private PictureBox pcbCarrito;
        private Label lblCambio;
        private TextBox txtMontoRecibido;
        private Label lblMontoRecibido;
        private Label lblTotalPagar;
        private Button btnVender;
        private TextBox txtCambio;
        private TextBox txtTotalAPagar;
    }
}