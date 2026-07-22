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
            textBox5 = new TextBox();
            lblCambio = new Label();
            textBox4 = new TextBox();
            lblMontoRecibido = new Label();
            textBox3 = new TextBox();
            lblTotalPagar = new Label();
            textBox2 = new TextBox();
            lblImpuesto = new Label();
            textBox1 = new TextBox();
            btnCancelar = new Button();
            lblTotal = new Label();
            btnVender = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.Black;
            lblTitulo.Location = new Point(12, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(354, 54);
            lblTitulo.TabIndex = 28;
            lblTitulo.Text = "Sistema de Cobro";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Code_Generated_Image;
            pictureBox1.Location = new Point(440, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // textBox5
            // 
            textBox5.BorderStyle = BorderStyle.FixedSingle;
            textBox5.ForeColor = Color.Black;
            textBox5.Location = new Point(306, 313);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(300, 27);
            textBox5.TabIndex = 39;
            // 
            // lblCambio
            // 
            lblCambio.AutoSize = true;
            lblCambio.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCambio.ForeColor = Color.Black;
            lblCambio.Location = new Point(66, 313);
            lblCambio.Name = "lblCambio";
            lblCambio.Size = new Size(84, 28);
            lblCambio.TabIndex = 38;
            lblCambio.Text = "Cambio:";
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.ForeColor = Color.Black;
            textBox4.Location = new Point(306, 263);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(300, 27);
            textBox4.TabIndex = 37;
            // 
            // lblMontoRecibido
            // 
            lblMontoRecibido.AutoSize = true;
            lblMontoRecibido.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMontoRecibido.ForeColor = Color.Black;
            lblMontoRecibido.Location = new Point(66, 263);
            lblMontoRecibido.Name = "lblMontoRecibido";
            lblMontoRecibido.Size = new Size(157, 28);
            lblMontoRecibido.TabIndex = 36;
            lblMontoRecibido.Text = "Monto Recibido:";
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.ForeColor = Color.Black;
            textBox3.Location = new Point(306, 213);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(300, 27);
            textBox3.TabIndex = 35;
            // 
            // lblTotalPagar
            // 
            lblTotalPagar.AutoSize = true;
            lblTotalPagar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalPagar.ForeColor = Color.Black;
            lblTotalPagar.Location = new Point(66, 213);
            lblTotalPagar.Name = "lblTotalPagar";
            lblTotalPagar.Size = new Size(127, 28);
            lblTotalPagar.TabIndex = 34;
            lblTotalPagar.Text = "Total a Pagar:";
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.ForeColor = Color.Black;
            textBox2.Location = new Point(306, 163);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(300, 27);
            textBox2.TabIndex = 33;
            // 
            // lblImpuesto
            // 
            lblImpuesto.AutoSize = true;
            lblImpuesto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblImpuesto.ForeColor = Color.Black;
            lblImpuesto.Location = new Point(66, 163);
            lblImpuesto.Name = "lblImpuesto";
            lblImpuesto.Size = new Size(181, 28);
            lblImpuesto.TabIndex = 32;
            lblImpuesto.Text = "Impuesto Aplicado:";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.ForeColor = Color.Black;
            textBox1.Location = new Point(306, 113);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(300, 27);
            textBox1.TabIndex = 31;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(100, 116, 139);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(476, 379);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(150, 50);
            btnCancelar.TabIndex = 29;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotal.ForeColor = Color.Black;
            lblTotal.Location = new Point(66, 113);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(58, 28);
            lblTotal.TabIndex = 30;
            lblTotal.Text = "Total:";
            // 
            // btnVender
            // 
            btnVender.BackColor = Color.FromArgb(29, 53, 87);
            btnVender.FlatStyle = FlatStyle.Flat;
            btnVender.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVender.ForeColor = Color.White;
            btnVender.Location = new Point(281, 379);
            btnVender.Name = "btnVender";
            btnVender.Size = new Size(150, 50);
            btnVender.TabIndex = 40;
            btnVender.Text = "Vender";
            btnVender.UseVisualStyleBackColor = false;
            // 
            // frmCobrar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 250, 252);
            ClientSize = new Size(782, 553);
            Controls.Add(btnVender);
            Controls.Add(textBox5);
            Controls.Add(lblCambio);
            Controls.Add(textBox4);
            Controls.Add(lblMontoRecibido);
            Controls.Add(textBox3);
            Controls.Add(lblTotalPagar);
            Controls.Add(textBox2);
            Controls.Add(lblImpuesto);
            Controls.Add(textBox1);
            Controls.Add(btnCancelar);
            Controls.Add(lblTotal);
            Controls.Add(lblTitulo);
            Controls.Add(pictureBox1);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "frmCobrar";
            Text = "frmCobrar";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private PictureBox pictureBox1;
        private TextBox textBox5;
        private Label lblCambio;
        private TextBox textBox4;
        private Label lblMontoRecibido;
        private TextBox textBox3;
        private Label lblTotalPagar;
        private TextBox textBox2;
        private Label lblImpuesto;
        private TextBox textBox1;
        private Button btnCancelar;
        private Label lblTotal;
        private Button btnVender;
    }
}