namespace pryDulceria
{
    partial class frmAgregarCategoria
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
            btnGuardar = new Button();
            txtCategoria = new TextBox();
            txtCodigoCategoria = new TextBox();
            lblImpuesto = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.LightCoral;
            btnGuardar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(321, 387);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(150, 50);
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(345, 164);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(300, 27);
            txtCategoria.TabIndex = 2;
            // 
            // txtCodigoCategoria
            // 
            txtCodigoCategoria.Location = new Point(345, 264);
            txtCodigoCategoria.Name = "txtCodigoCategoria";
            txtCodigoCategoria.Size = new Size(300, 27);
            txtCodigoCategoria.TabIndex = 3;
            // 
            // lblImpuesto
            // 
            lblImpuesto.AutoSize = true;
            lblImpuesto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblImpuesto.ForeColor = Color.Black;
            lblImpuesto.Location = new Point(113, 260);
            lblImpuesto.Name = "lblImpuesto";
            lblImpuesto.Size = new Size(215, 28);
            lblImpuesto.TabIndex = 33;
            lblImpuesto.Text = "Codigo de la categoria:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(113, 160);
            label1.Name = "label1";
            label1.Size = new Size(223, 28);
            label1.TabIndex = 34;
            label1.Text = "Nombre de la categoria:";
            // 
            // frmAgregarCategoria
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(782, 553);
            Controls.Add(label1);
            Controls.Add(lblImpuesto);
            Controls.Add(txtCodigoCategoria);
            Controls.Add(txtCategoria);
            Controls.Add(btnGuardar);
            Name = "frmAgregarCategoria";
            Text = "frmAgregarCategoria";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuardar;
        private TextBox txtCategoria;
        private TextBox txtCodigoCategoria;
        private Label lblImpuesto;
        private Label label1;
    }
}