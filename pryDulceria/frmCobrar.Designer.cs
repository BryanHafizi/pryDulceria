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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCobrar));
            textBox5 = new TextBox();
            this.lblCambio = new Label();
            textBox4 = new TextBox();
            this.lblCobro = new Label();
            textBox3 = new TextBox();
            this.lblTotalPagar = new Label();
            textBox2 = new TextBox();
            this.lblImpuesto = new Label();
            textBox1 = new TextBox();
            pbLogo = new PictureBox();
            this.btnVenta = new Button();
            lblTotal = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox5
            // 
            textBox5.Location = new Point(305, 305);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(300, 27);
            textBox5.TabIndex = 27;
            // 
            // lblCambio
            // 
            this.lblCambio.AutoSize = true;
            this.lblCambio.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.lblCambio.Location = new Point(65, 311);
            this.lblCambio.Name = "lblCambio";
            this.lblCambio.Size = new Size(84, 28);
            this.lblCambio.TabIndex = 26;
            this.lblCambio.Text = "Cambio:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(305, 255);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(300, 27);
            textBox4.TabIndex = 25;
            // 
            // lblCobro
            // 
            this.lblCobro.AutoSize = true;
            this.lblCobro.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.lblCobro.Location = new Point(65, 261);
            this.lblCobro.Name = "lblCobro";
            this.lblCobro.Size = new Size(71, 28);
            this.lblCobro.TabIndex = 24;
            this.lblCobro.Text = "Cobro:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(305, 205);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(300, 27);
            textBox3.TabIndex = 23;
            // 
            // lblTotalPagar
            // 
            this.lblTotalPagar.AutoSize = true;
            this.lblTotalPagar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.lblTotalPagar.Location = new Point(65, 211);
            this.lblTotalPagar.Name = "lblTotalPagar";
            this.lblTotalPagar.Size = new Size(127, 28);
            this.lblTotalPagar.TabIndex = 22;
            this.lblTotalPagar.Text = "Total a Pagar:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(305, 155);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(300, 27);
            textBox2.TabIndex = 21;
            // 
            // lblImpuesto
            // 
            this.lblImpuesto.AutoSize = true;
            this.lblImpuesto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.lblImpuesto.Location = new Point(65, 161);
            this.lblImpuesto.Name = "lblImpuesto";
            this.lblImpuesto.Size = new Size(181, 28);
            this.lblImpuesto.TabIndex = 20;
            this.lblImpuesto.Text = "Impuesto Aplicado:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(305, 105);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(300, 27);
            textBox1.TabIndex = 19;
            // 
            // pbLogo
            // 
            pbLogo.Image = (Image)resources.GetObject("pbLogo.Image");
            pbLogo.Location = new Point(95, 35);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(150, 50);
            pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogo.TabIndex = 17;
            pbLogo.TabStop = false;
            // 
            // btnVenta
            // 
            this.btnVenta.BackColor = Color.FromArgb(240, 128, 128);
            this.btnVenta.FlatStyle = FlatStyle.Flat;
            this.btnVenta.ForeColor = Color.White;
            this.btnVenta.Location = new Point(395, 375);
            this.btnVenta.Name = "btnVenta";
            this.btnVenta.Size = new Size(150, 40);
            this.btnVenta.TabIndex = 15;
            this.btnVenta.Text = "Hacer Venta";
            this.btnVenta.UseVisualStyleBackColor = false;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(65, 105);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(58, 28);
            lblTotal.TabIndex = 16;
            lblTotal.Text = "Total:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Code_Generated_Image;
            pictureBox1.Location = new Point(635, 35);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // frmCobrar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox5);
            Controls.Add(this.lblCambio);
            Controls.Add(textBox4);
            Controls.Add(this.lblCobro);
            Controls.Add(textBox3);
            Controls.Add(this.lblTotalPagar);
            Controls.Add(textBox2);
            Controls.Add(this.lblImpuesto);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Controls.Add(pbLogo);
            Controls.Add(this.btnVenta);
            Controls.Add(lblTotal);
            Name = "frmCobrar";
            Text = "frmCobrar";
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox5;
        private Label lblStock;
        private TextBox textBox4;
        private Label lblPrecio;
        private TextBox textBox3;
        private Label lblCodigo;
        private TextBox textBox2;
        private Label lblCategoria;
        private TextBox textBox1;
        private PictureBox pbLogo;
        private Button btnGuardar;
        private Label lblTotal;
        private PictureBox pictureBox1;
    }
}