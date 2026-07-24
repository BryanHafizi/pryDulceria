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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            pcbReportes = new PictureBox();
            lblTitulo = new Label();
            lblFecha = new Label();
            dgvReportes = new DataGridView();
            btnCargarDatos = new Button();
            btnPdf = new Button();
            dtpFechaCorte = new DateTimePicker();
            lblTipoReporte = new Label();
            cmbTipoReporte = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pcbReportes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvReportes).BeginInit();
            SuspendLayout();
            // 
            // pcbReportes
            // 
            pcbReportes.AccessibleRole = AccessibleRole.None;
            pcbReportes.Image = (Image)resources.GetObject("pcbReportes.Image");
            pcbReportes.Location = new Point(210, 13);
            pcbReportes.Name = "pcbReportes";
            pcbReportes.Size = new Size(100, 50);
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
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFecha.Location = new Point(330, 50);
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
            dgvReportes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReportes.GridColor = Color.Black;
            dgvReportes.Location = new Point(330, 150);
            dgvReportes.Name = "dgvReportes";
            dgvReportes.ReadOnly = true;
            dgvReportes.RowHeadersVisible = false;
            dgvReportes.RowHeadersWidth = 51;
            dataGridViewCellStyle1.Padding = new Padding(3);
            dgvReportes.RowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvReportes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReportes.Size = new Size(800, 300);
            dgvReportes.TabIndex = 15;
            // 
            // btnCargarDatos
            // 
            btnCargarDatos.BackColor = Color.FromArgb(194, 24, 91);
            btnCargarDatos.FlatStyle = FlatStyle.Flat;
            btnCargarDatos.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCargarDatos.ForeColor = Color.White;
            btnCargarDatos.Location = new Point(330, 460);
            btnCargarDatos.Name = "btnCargarDatos";
            btnCargarDatos.Size = new Size(150, 50);
            btnCargarDatos.TabIndex = 16;
            btnCargarDatos.Text = "Cargar datos";
            btnCargarDatos.UseVisualStyleBackColor = false;
            // 
            // btnPdf
            // 
            btnPdf.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnPdf.BackColor = Color.FromArgb(194, 24, 91);
            btnPdf.FlatStyle = FlatStyle.Flat;
            btnPdf.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPdf.ForeColor = Color.White;
            btnPdf.Location = new Point(490, 460);
            btnPdf.Name = "btnPdf";
            btnPdf.Size = new Size(150, 50);
            btnPdf.TabIndex = 17;
            btnPdf.Text = "Generar PDF";
            btnPdf.UseVisualStyleBackColor = false;
            // 
            // dtpFechaCorte
            // 
            dtpFechaCorte.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFechaCorte.CalendarForeColor = Color.Black;
            dtpFechaCorte.CalendarTitleForeColor = Color.Black;
            dtpFechaCorte.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFechaCorte.Format = DateTimePickerFormat.Short;
            dtpFechaCorte.Location = new Point(550, 50);
            dtpFechaCorte.Name = "dtpFechaCorte";
            dtpFechaCorte.Size = new Size(260, 34);
            dtpFechaCorte.TabIndex = 18;
            dtpFechaCorte.Value = new DateTime(2026, 7, 23, 20, 38, 4, 0);
            // 
            // lblTipoReporte
            // 
            lblTipoReporte.AutoSize = true;
            lblTipoReporte.Font = new Font("Segoe UI", 12F);
            lblTipoReporte.Location = new Point(330, 100);
            lblTipoReporte.Name = "lblTipoReporte";
            lblTipoReporte.Size = new Size(152, 28);
            lblTipoReporte.TabIndex = 19;
            lblTipoReporte.Text = "Tipo de reporte:";
            // 
            // cmbTipoReporte
            // 
            cmbTipoReporte.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbTipoReporte.ForeColor = Color.Black;
            cmbTipoReporte.FormattingEnabled = true;
            cmbTipoReporte.Location = new Point(550, 100);
            cmbTipoReporte.Name = "cmbTipoReporte";
            cmbTipoReporte.Size = new Size(260, 36);
            cmbTipoReporte.TabIndex = 20;
            cmbTipoReporte.Tag = "";
            cmbTipoReporte.Text = "Seleccione un tipo";
            // 
            // frmReportes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 242, 245);
            ClientSize = new Size(1316, 603);
            Controls.Add(cmbTipoReporte);
            Controls.Add(lblTipoReporte);
            Controls.Add(dtpFechaCorte);
            Controls.Add(btnPdf);
            Controls.Add(btnCargarDatos);
            Controls.Add(dgvReportes);
            Controls.Add(lblFecha);
            Controls.Add(pcbReportes);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
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
        private Label lblFecha;
        private DataGridView dgvReportes;
        private Button btnCargarDatos;
        private Button btnPdf;
        private DateTimePicker dtpFechaCorte;
        private Label lblTipoReporte;
        private ComboBox cmbTipoReporte;
    }
}