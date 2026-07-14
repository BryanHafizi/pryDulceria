namespace pryDulceria
{
    partial class frmReportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportes));
            pbProveedores = new PictureBox();
            lblTitulo = new Label();
            ((System.ComponentModel.ISupportInitialize)pbProveedores).BeginInit();
            SuspendLayout();
            // 
            // pbProveedores
            // 
            pbProveedores.AccessibleRole = AccessibleRole.None;
            pbProveedores.Image = (Image)resources.GetObject("pbProveedores.Image");
            pbProveedores.Location = new Point(210, 13);
            pbProveedores.Name = "pbProveedores";
            pbProveedores.Size = new Size(100, 75);
            pbProveedores.SizeMode = PictureBoxSizeMode.StretchImage;
            pbProveedores.TabIndex = 11;
            pbProveedores.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = SystemColors.ControlText;
            lblTitulo.Location = new Point(12, 13);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(192, 54);
            lblTitulo.TabIndex = 10;
            lblTitulo.Text = "Reportes";
            // 
            // frmReportes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(982, 603);
            Controls.Add(pbProveedores);
            Controls.Add(lblTitulo);
            Name = "frmReportes";
            Text = "frmReportes";
            ((System.ComponentModel.ISupportInitialize)pbProveedores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbProveedores;
        private Label lblTitulo;
    }
}