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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();

            pbProveedores = new PictureBox();

            pcbReportes = new PictureBox();

            lblTitulo = new Label();
            lblFecha = new Label();
            dgvReportes = new DataGridView();
            btnGenerar = new Button();
            btnPdf = new Button();
            txtFecha = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pcbReportes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvReportes).BeginInit();
            SuspendLayout();
            // 
            // pcbReportes
            // 

            pbProveedores.AccessibleRole = AccessibleRole.None;
            pbProveedores.Image = (Image)resources.GetObject("pbProveedores.Image");
            pbProveedores.Location = new Point(12, 10);
            pbProveedores.Margin = new Padding(3, 2, 3, 2);
            pbProveedores.Name = "pbProveedores";
            pbProveedores.Size = new Size(67, 48);
            pbProveedores.SizeMode = PictureBoxSizeMode.StretchImage;
            pbProveedores.TabIndex = 11;
            pbProveedores.TabStop = false;

            pcbReportes.AccessibleRole = AccessibleRole.None;
            pcbReportes.Image = (Image)resources.GetObject("pcbReportes.Image");
            pcbReportes.Location = new Point(200, 13);
            pcbReportes.Name = "pcbReportes";
            pcbReportes.Size = new Size(100, 50);
            pcbReportes.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbReportes.TabIndex = 11;
            pcbReportes.TabStop = false;

            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = SystemColors.ControlText;
            lblTitulo.Location = new Point(76, 21);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(133, 37);
            lblTitulo.TabIndex = 10;
            lblTitulo.Text = "Reportes";
            // 
            // lblFecha
            // 

            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.Location = new Point(395, 31);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "DD/MM/AAAA";
            textBox1.Size = new Size(147, 29);
            textBox1.TabIndex = 12;
            // 
            // lblIngreseFecha
            // 
            lblIngreseFecha.AutoSize = true;
            lblIngreseFecha.Font = new Font("Segoe UI", 12F);
            lblIngreseFecha.Location = new Point(224, 34);
            lblIngreseFecha.Name = "lblIngreseFecha";
            lblIngreseFecha.Size = new Size(165, 21);
            lblIngreseFecha.TabIndex = 14;
            lblIngreseFecha.Text = "Ingrese fecha de corte:";

            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI", 12F);
            lblFecha.Location = new Point(480, 30);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(207, 28);
            lblFecha.TabIndex = 14;
            lblFecha.Text = "Ingrese fecha de corte:";

            // 
            // dgvReportes
            // 
            dgvReportes.AllowUserToAddRows = false;
            dgvReportes.AllowUserToDeleteRows = false;
            dgvReportes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvReportes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReportes.BackgroundColor = Color.White;

            dgvReportes.BorderStyle = BorderStyle.None;
            dgvReportes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReportes.Location = new Point(15, 70);
            dgvReportes.Margin = new Padding(3, 2, 3, 2);

            dgvReportes.BorderStyle = BorderStyle.Fixed3D;
            dgvReportes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReportes.Location = new Point(320, 140);

            dgvReportes.Name = "dgvReportes";
            dgvReportes.ReadOnly = true;
            dgvReportes.RowHeadersVisible = false;
            dgvReportes.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Padding = new Padding(3);
            dgvReportes.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvReportes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvReportes.Size = new Size(664, 190);

            dgvReportes.Size = new Size(900, 400);

            dgvReportes.TabIndex = 15;
            // 
            // btnGenerar
            // 
            btnGenerar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnGenerar.BackColor = Color.FromArgb(77, 130, 188);
            btnGenerar.FlatStyle = FlatStyle.Flat;
            btnGenerar.Font = new Font("Segoe UI", 12F);
            btnGenerar.ForeColor = Color.White;

            btnGenerar.Location = new Point(548, 25);
            btnGenerar.Margin = new Padding(3, 2, 3, 2);

            btnGenerar.Location = new Point(700, 80);

            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(131, 38);
            btnGenerar.TabIndex = 16;
            btnGenerar.Text = "Generar";
            btnGenerar.UseVisualStyleBackColor = false;
            // 
            // btnPdf
            // 
            btnPdf.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnPdf.BackColor = Color.FromArgb(77, 130, 188);
            btnPdf.FlatStyle = FlatStyle.Flat;
            btnPdf.Font = new Font("Segoe UI", 12F);
            btnPdf.ForeColor = Color.White;

            btnPdf.Location = new Point(685, 222);
            btnPdf.Margin = new Padding(3, 2, 3, 2);

            btnPdf.Location = new Point(700, 550);

            btnPdf.Name = "btnPdf";
            btnPdf.Size = new Size(131, 38);
            btnPdf.TabIndex = 17;
            btnPdf.Text = "Generar PDF";
            btnPdf.UseVisualStyleBackColor = false;
            // 
            // txtFecha
            // 
            txtFecha.Font = new Font("Segoe UI", 12F);
            txtFecha.Location = new Point(700, 30);
            txtFecha.Name = "txtFecha";
            txtFecha.PlaceholderText = "DD/MM/AAAA";
            txtFecha.Size = new Size(150, 34);
            txtFecha.TabIndex = 12;
            // 
            // frmReportes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(838, 271);
            Controls.Add(btnPdf);
            Controls.Add(btnGenerar);
            Controls.Add(dgvReportes);
            Controls.Add(lblFecha);
            Controls.Add(txtFecha);
            Controls.Add(pcbReportes);
            Controls.Add(lblTitulo);

            Margin = new Padding(3, 2, 3, 2);

            FormBorderStyle = FormBorderStyle.FixedSingle;

            Name = "frmReportes";
            Text = "Modulo de Generación de Reportes";
            ((System.ComponentModel.ISupportInitialize)pcbReportes).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvReportes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pcbReportes;
        private Label lblTitulo;
        private Label lblFecha;
        private DataGridView dgvReportes;
        private Button btnGenerar;
        private Button btnPdf;
        private TextBox txtFecha;
    }
}