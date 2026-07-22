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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            pcbReportes = new PictureBox();
            lblTitulo = new Label();
            txtFecha = new TextBox();
            lblIngreseFecha = new Label();
            dgvReportes = new DataGridView();
            btnGenerar = new Button();
            btnPdf = new Button();
            ((System.ComponentModel.ISupportInitialize)pcbReportes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvReportes).BeginInit();
            SuspendLayout();
            // 
            // pcbReportes
            // 
            pcbReportes.AccessibleRole = AccessibleRole.None;
            pcbReportes.Location = new Point(210, 13);
            pcbReportes.Name = "pcbReportes";
            pcbReportes.Size = new Size(100, 75);
            pcbReportes.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbReportes.TabIndex = 11;
            pcbReportes.TabStop = false;
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
            // txtFecha
            // 
            txtFecha.BorderStyle = BorderStyle.FixedSingle;
            txtFecha.Font = new Font("Segoe UI", 12F);
            txtFecha.Location = new Point(543, 115);
            txtFecha.Name = "txtFecha";
            txtFecha.PlaceholderText = "DD/MM/AAAA";
            txtFecha.Size = new Size(167, 34);
            txtFecha.TabIndex = 12;
            // 
            // lblIngreseFecha
            // 
            lblIngreseFecha.AutoSize = true;
            lblIngreseFecha.Font = new Font("Segoe UI", 12F);
            lblIngreseFecha.Location = new Point(313, 115);
            lblIngreseFecha.Name = "lblIngreseFecha";
            lblIngreseFecha.Size = new Size(207, 28);
            lblIngreseFecha.TabIndex = 14;
            lblIngreseFecha.Text = "Ingrese fecha de corte:";
            // 
            // dgvReportes
            // 
            dgvReportes.AllowUserToAddRows = false;
            dgvReportes.AllowUserToDeleteRows = false;
            dgvReportes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvReportes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReportes.BackgroundColor = Color.FromArgb(226, 232, 240);
            dgvReportes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReportes.Location = new Point(313, 169);
            dgvReportes.Name = "dgvReportes";
            dgvReportes.ReadOnly = true;
            dgvReportes.RowHeadersVisible = false;
            dgvReportes.RowHeadersWidth = 51;
            dataGridViewCellStyle1.Padding = new Padding(3);
            dgvReportes.RowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvReportes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReportes.Size = new Size(759, 317);
            dgvReportes.TabIndex = 15;
            // 
            // btnGenerar
            // 
            btnGenerar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnGenerar.BackColor = Color.FromArgb(100, 116, 139);
            btnGenerar.FlatStyle = FlatStyle.Flat;
            btnGenerar.Font = new Font("Segoe UI", 12F);
            btnGenerar.ForeColor = Color.White;
            btnGenerar.Location = new Point(759, 104);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(150, 50);
            btnGenerar.TabIndex = 16;
            btnGenerar.Text = "Generar";
            btnGenerar.UseVisualStyleBackColor = false;
            // 
            // btnPdf
            // 
            btnPdf.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnPdf.BackColor = Color.FromArgb(29, 53, 87);
            btnPdf.FlatStyle = FlatStyle.Flat;
            btnPdf.Font = new Font("Segoe UI", 12F);
            btnPdf.ForeColor = Color.White;
            btnPdf.Location = new Point(612, 508);
            btnPdf.Name = "btnPdf";
            btnPdf.Size = new Size(150, 50);
            btnPdf.TabIndex = 17;
            btnPdf.Text = "Generar PDF";
            btnPdf.UseVisualStyleBackColor = false;
            // 
            // frmReportes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 250, 252);
            ClientSize = new Size(1316, 603);
            Controls.Add(btnPdf);
            Controls.Add(btnGenerar);
            Controls.Add(dgvReportes);
            Controls.Add(lblIngreseFecha);
            Controls.Add(txtFecha);
            Controls.Add(pcbReportes);
            Controls.Add(lblTitulo);
            Name = "frmReportes";
            Text = "frmReportes";
            ((System.ComponentModel.ISupportInitialize)pcbReportes).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvReportes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pcbReportes;
        private Label lblTitulo;
        private TextBox txtFecha;
        private Label lblIngreseFecha;
        private DataGridView dgvReportes;
        private Button btnGenerar;
        private Button btnPdf;
    }
}