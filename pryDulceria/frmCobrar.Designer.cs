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
            lblTotal = new Label();
            btnVender = new Button();
            txtCambio = new TextBox();
            txtTotal = new TextBox();
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
            lblCambio.Location = new Point(100, 250);
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
            txtMontoRecibido.Location = new Point(300, 200);
            txtMontoRecibido.Name = "txtMontoRecibido";
            txtMontoRecibido.Size = new Size(243, 34);
            txtMontoRecibido.TabIndex = 1;
            txtMontoRecibido.TextChanged += txtMontoRecibido_TextChanged;
            txtMontoRecibido.KeyPress += txtMontoRecibido_KeyPress;
            // 
            // lblMontoRecibido
            // 
            lblMontoRecibido.AutoSize = true;
            lblMontoRecibido.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMontoRecibido.ForeColor = Color.Black;
            lblMontoRecibido.Location = new Point(100, 200);
            lblMontoRecibido.Name = "lblMontoRecibido";
            lblMontoRecibido.Size = new Size(157, 28);
            lblMontoRecibido.TabIndex = 36;
            lblMontoRecibido.Text = "Monto Recibido:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotal.ForeColor = Color.Black;
            lblTotal.Location = new Point(100, 150);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(127, 28);
            lblTotal.TabIndex = 34;
            lblTotal.Text = "Total a Pagar:";
            // 
            // btnVender
            // 
            btnVender.BackColor = Color.FromArgb(30, 41, 59);
            btnVender.FlatStyle = FlatStyle.Flat;
            btnVender.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnVender.ForeColor = Color.White;
            btnVender.Location = new Point(300, 320);
            btnVender.Name = "btnVender";
            btnVender.Size = new Size(150, 50);
            btnVender.TabIndex = 3;
            btnVender.Text = "Vender";
            btnVender.UseVisualStyleBackColor = false;
            btnVender.Click += btnVender_Click;
            // 
            // txtCambio
            // 
            txtCambio.BorderStyle = BorderStyle.FixedSingle;
            txtCambio.Font = new Font("Segoe UI", 12F);
            txtCambio.ForeColor = Color.Black;
            txtCambio.Location = new Point(300, 250);
            txtCambio.Name = "txtCambio";
            txtCambio.Size = new Size(243, 34);
            txtCambio.TabIndex = 2;
            // 
            // txtTotal
            // 
            txtTotal.BorderStyle = BorderStyle.FixedSingle;
            txtTotal.Font = new Font("Segoe UI", 12F);
            txtTotal.ForeColor = Color.Black;
            txtTotal.Location = new Point(300, 150);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(243, 34);
            txtTotal.TabIndex = 0;
            // 
            // frmCobrar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 244, 246);
            ClientSize = new Size(632, 453);
            Controls.Add(txtTotal);
            Controls.Add(txtCambio);
            Controls.Add(btnVender);
            Controls.Add(lblCambio);
            Controls.Add(txtMontoRecibido);
            Controls.Add(lblMontoRecibido);
            Controls.Add(lblTotal);
            Controls.Add(lblTitulo);
            Controls.Add(pcbCarrito);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmCobrar";
            StartPosition = FormStartPosition.CenterParent;
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
        private Label lblTotal;
        private Button btnVender;
        private TextBox txtCambio;
        private TextBox txtTotal;
    }
}