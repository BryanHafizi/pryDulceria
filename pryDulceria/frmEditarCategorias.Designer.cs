namespace pryDulceria
{
    partial class frmEditarCategorias
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
            label1 = new Label();
            lblImpuesto = new Label();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(29, 53, 87);
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
            txtCategoria.Font = new Font("Segoe UI", 12F);
            txtCategoria.Location = new Point(345, 164);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(260, 34);
            txtCategoria.TabIndex = 1;
            // 
            // txtCodigoCategoria
            // 
            txtCodigoCategoria.Font = new Font("Segoe UI", 12F);
            txtCodigoCategoria.Location = new Point(345, 257);
            txtCodigoCategoria.Name = "txtCodigoCategoria";
            txtCodigoCategoria.Size = new Size(260, 34);
            txtCodigoCategoria.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(113, 160);
            label1.Name = "label1";
            label1.Size = new Size(223, 28);
            label1.TabIndex = 35;
            label1.Text = "Nombre de la categoria:";
            // 
            // lblImpuesto
            // 
            lblImpuesto.AutoSize = true;
            lblImpuesto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblImpuesto.ForeColor = Color.Black;
            lblImpuesto.Location = new Point(113, 260);
            lblImpuesto.Name = "lblImpuesto";
            lblImpuesto.Size = new Size(215, 28);
            lblImpuesto.TabIndex = 36;
            lblImpuesto.Text = "Codigo de la categoria:";
            // 
            // frmEditarCategorias
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 553);
            Controls.Add(lblImpuesto);
            Controls.Add(label1);
            Controls.Add(txtCodigoCategoria);
            Controls.Add(txtCategoria);
            Controls.Add(btnGuardar);
            Name = "frmEditarCategorias";
            Text = "frmEditarCategorias";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuardar;
        private Label label1;
        private Label lblImpuesto;
        public TextBox txtCategoria;
        public TextBox txtCodigoCategoria;
    }
}