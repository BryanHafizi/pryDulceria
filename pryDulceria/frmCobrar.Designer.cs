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
            pictureBox1 = new PictureBox();
            txtCambio = new TextBox();
            lblCambio = new Label();
            txtMontoRecibido = new TextBox();
            lblMontoRecibido = new Label();
            txtTotalPagar = new TextBox();
            lblTotalPagar = new Label();
            txtImpuesto = new TextBox();
            lblImpuesto = new Label();
            txtTotal = new TextBox();
            btnVender = new Button();
            lblTotal = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Code_Generated_Image;
            pictureBox1.Location = new Point(380, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // txtCambio
            // 
            txtCambio.Font = new Font("Segoe UI", 12F);
            txtCambio.ForeColor = Color.Black;
            txtCambio.Location = new Point(300, 340);
            txtCambio.Name = "txtCambio";
            txtCambio.Size = new Size(260, 34);
            txtCambio.TabIndex = 39;
            // 
            // lblCambio
            // 
            lblCambio.AutoSize = true;
            lblCambio.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCambio.ForeColor = Color.Black;
            lblCambio.Location = new Point(80, 340);
            lblCambio.Name = "lblCambio";
            lblCambio.Size = new Size(84, 28);
            lblCambio.TabIndex = 38;
            lblCambio.Text = "Cambio:";
            // 
            // txtMontoRecibido
            // 
            txtMontoRecibido.Font = new Font("Segoe UI", 12F);
            txtMontoRecibido.ForeColor = Color.Black;
            txtMontoRecibido.Location = new Point(300, 280);
            txtMontoRecibido.Name = "txtMontoRecibido";
            txtMontoRecibido.Size = new Size(260, 34);
            txtMontoRecibido.TabIndex = 37;
            // 
            // lblMontoRecibido
            // 
            lblMontoRecibido.AutoSize = true;
            lblMontoRecibido.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMontoRecibido.ForeColor = Color.Black;
            lblMontoRecibido.Location = new Point(80, 280);
            lblMontoRecibido.Name = "lblMontoRecibido";
            lblMontoRecibido.Size = new Size(157, 28);
            lblMontoRecibido.TabIndex = 36;
            lblMontoRecibido.Text = "Monto Recibido:";
            // 
            // txtTotalPagar
            // 
            txtTotalPagar.Font = new Font("Segoe UI", 12F);
            txtTotalPagar.ForeColor = Color.Black;
            txtTotalPagar.Location = new Point(300, 220);
            txtTotalPagar.Name = "txtTotalPagar";
            txtTotalPagar.Size = new Size(260, 34);
            txtTotalPagar.TabIndex = 35;
            // 
            // lblTotalPagar
            // 
            lblTotalPagar.AutoSize = true;
            lblTotalPagar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalPagar.ForeColor = Color.Black;
            lblTotalPagar.Location = new Point(80, 220);
            lblTotalPagar.Name = "lblTotalPagar";
            lblTotalPagar.Size = new Size(127, 28);
            lblTotalPagar.TabIndex = 34;
            lblTotalPagar.Text = "Total a Pagar:";
            // 
            // txtImpuesto
            // 
            txtImpuesto.Font = new Font("Segoe UI", 12F);
            txtImpuesto.ForeColor = Color.Black;
            txtImpuesto.Location = new Point(300, 160);
            txtImpuesto.Name = "txtImpuesto";
            txtImpuesto.Size = new Size(260, 34);
            txtImpuesto.TabIndex = 33;
            // 
            // lblImpuesto
            // 
            lblImpuesto.AutoSize = true;
            lblImpuesto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblImpuesto.ForeColor = Color.Black;
            lblImpuesto.Location = new Point(80, 160);
            lblImpuesto.Name = "lblImpuesto";
            lblImpuesto.Size = new Size(181, 28);
            lblImpuesto.TabIndex = 32;
            lblImpuesto.Text = "Impuesto Aplicado:";
            // 
            // txtTotal
            // 
            txtTotal.Font = new Font("Segoe UI", 12F);
            txtTotal.ForeColor = Color.Black;
            txtTotal.Location = new Point(300, 100);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(260, 34);
            txtTotal.TabIndex = 31;
            // 
            // btnVender
            // 
            btnVender.BackColor = Color.HotPink;
            btnVender.FlatStyle = FlatStyle.Flat;
            btnVender.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVender.ForeColor = Color.White;
            btnVender.Location = new Point(360, 400);
            btnVender.Name = "btnVender";
            btnVender.Size = new Size(150, 50);
            btnVender.TabIndex = 29;
            btnVender.Text = "Hacer venta";
            btnVender.UseVisualStyleBackColor = false;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotal.ForeColor = Color.Black;
            lblTotal.Location = new Point(80, 100);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(58, 28);
            lblTotal.TabIndex = 30;
            lblTotal.Text = "Total:";
            // 
            // frmCobrar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(782, 553);
            Controls.Add(txtCambio);
            Controls.Add(lblCambio);
            Controls.Add(txtMontoRecibido);
            Controls.Add(lblMontoRecibido);
            Controls.Add(txtTotalPagar);
            Controls.Add(lblTotalPagar);
            Controls.Add(txtImpuesto);
            Controls.Add(lblImpuesto);
            Controls.Add(txtTotal);
            Controls.Add(btnVender);
            Controls.Add(lblTotal);
            Controls.Add(lblTitulo);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmCobrar";
            Text = "Módulo de Cobro";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private PictureBox pictureBox1;
        private TextBox txtCambio;
        private Label lblCambio;
        private TextBox txtMontoRecibido;
        private Label lblMontoRecibido;
        private TextBox txtTotalPagar;
        private Label lblTotalPagar;
        private TextBox txtImpuesto;
        private Label lblImpuesto;
        private TextBox txtTotal;
        private Button btnVender;
        private Label lblTotal;
    }
}