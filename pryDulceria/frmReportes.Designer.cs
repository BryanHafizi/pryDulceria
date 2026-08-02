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
            pcbReportes = new PictureBox();
            lblTitulo = new Label();
            lblFecha = new Label();
            dgvReportes = new DataGridView();
            btnCargarDatos = new Button();
            btnPdf = new Button();
            dtpFechaCorte = new DateTimePicker();
            lblTipoReporte = new Label();
            cmbTipoReporte = new ComboBox();
            dtpFechaFin = new DateTimePicker();
            lblFechaFin = new Label();
            ((System.ComponentModel.ISupportInitialize)pcbReportes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvReportes).BeginInit();
            SuspendLayout();
            // 
            // pcbReportes
            // 
            pcbReportes.AccessibleRole = AccessibleRole.None;
            pcbReportes.Image = (Image)resources.GetObject("pcbReportes.Image");
            pcbReportes.Location = new Point(184, 10);
            pcbReportes.Margin = new Padding(3, 2, 3, 2);
            pcbReportes.Name = "pcbReportes";
            pcbReportes.Size = new Size(88, 38);
            pcbReportes.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbReportes.TabIndex = 11;
            pcbReportes.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = SystemColors.ControlText;
            lblTitulo.Location = new Point(10, 10);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(154, 45);
            lblTitulo.TabIndex = 10;
            lblTitulo.Text = "Reportes";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFecha.Location = new Point(289, 38);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(165, 21);
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
            dgvReportes.Location = new Point(289, 112);
            dgvReportes.Margin = new Padding(3, 2, 3, 2);
            dgvReportes.Name = "dgvReportes";
            dgvReportes.ReadOnly = true;
            dgvReportes.RowHeadersVisible = false;
            dgvReportes.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Padding = new Padding(3);
            dgvReportes.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvReportes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReportes.Size = new Size(700, 225);
            dgvReportes.TabIndex = 15;
            // 
            // btnCargarDatos
            // 
            btnCargarDatos.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCargarDatos.BackColor = Color.FromArgb(30, 41, 59);
            btnCargarDatos.FlatStyle = FlatStyle.Flat;
            btnCargarDatos.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCargarDatos.ForeColor = Color.White;
            btnCargarDatos.Location = new Point(289, 345);
            btnCargarDatos.Margin = new Padding(3, 2, 3, 2);
            btnCargarDatos.Name = "btnCargarDatos";
            btnCargarDatos.Size = new Size(131, 38);
            btnCargarDatos.TabIndex = 16;
            btnCargarDatos.Text = "Cargar datos";
            btnCargarDatos.UseVisualStyleBackColor = false;
            btnCargarDatos.Click += btnCargarDatos_click;
            // 
            // btnPdf
            // 
            btnPdf.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnPdf.BackColor = Color.FromArgb(30, 41, 59);
            btnPdf.FlatStyle = FlatStyle.Flat;
            btnPdf.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPdf.ForeColor = Color.White;
            btnPdf.Location = new Point(429, 345);
            btnPdf.Margin = new Padding(3, 2, 3, 2);
            btnPdf.Name = "btnPdf";
            btnPdf.Size = new Size(131, 38);
            btnPdf.TabIndex = 17;
            btnPdf.Text = "Generar PDF";
            btnPdf.UseVisualStyleBackColor = false;
            btnPdf.Click += btnPdf_Click;
            // 
            // dtpFechaCorte
            // 
            dtpFechaCorte.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFechaCorte.CalendarForeColor = Color.Black;
            dtpFechaCorte.CalendarTitleForeColor = Color.Black;
            dtpFechaCorte.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFechaCorte.Format = DateTimePickerFormat.Short;
            dtpFechaCorte.Location = new Point(481, 38);
            dtpFechaCorte.Margin = new Padding(3, 2, 3, 2);
            dtpFechaCorte.Name = "dtpFechaCorte";
            dtpFechaCorte.Size = new Size(228, 29);
            dtpFechaCorte.TabIndex = 18;
            dtpFechaCorte.Value = new DateTime(2026, 7, 23, 20, 38, 4, 0);
            // 
            // lblTipoReporte
            // 
            lblTipoReporte.AutoSize = true;
            lblTipoReporte.Font = new Font("Segoe UI", 12F);
            lblTipoReporte.Location = new Point(289, 75);
            lblTipoReporte.Name = "lblTipoReporte";
            lblTipoReporte.Size = new Size(119, 21);
            lblTipoReporte.TabIndex = 19;
            lblTipoReporte.Text = "Tipo de reporte:";
            // 
            // cmbTipoReporte
            // 
            cmbTipoReporte.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipoReporte.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbTipoReporte.ForeColor = Color.Black;
            cmbTipoReporte.FormattingEnabled = true;
            cmbTipoReporte.Items.AddRange(new object[] { "Ventas del dia", "Ventas semanales/mensuales", "Producto más vendido", "Compras Realizadas" });
            cmbTipoReporte.Location = new Point(481, 75);
            cmbTipoReporte.Margin = new Padding(3, 2, 3, 2);
            cmbTipoReporte.Name = "cmbTipoReporte";
            cmbTipoReporte.Size = new Size(228, 29);
            cmbTipoReporte.TabIndex = 20;
            cmbTipoReporte.Tag = "";
            cmbTipoReporte.SelectedIndexChanged += cmbTipoReporte_SelectedIndexChanged;
            // 
            // dtpFechaFin
            // 
            dtpFechaFin.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFechaFin.CalendarForeColor = Color.Black;
            dtpFechaFin.CalendarTitleForeColor = Color.Black;
            dtpFechaFin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFechaFin.Format = DateTimePickerFormat.Short;
            dtpFechaFin.Location = new Point(782, 38);
            dtpFechaFin.Margin = new Padding(3, 2, 3, 2);
            dtpFechaFin.Name = "dtpFechaFin";
            dtpFechaFin.Size = new Size(228, 29);
            dtpFechaFin.TabIndex = 21;
            dtpFechaFin.Value = new DateTime(2026, 7, 23, 20, 38, 4, 0);
            dtpFechaFin.Visible = false;
            // 
            // lblFechaFin
            // 
            lblFechaFin.AutoSize = true;
            lblFechaFin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFechaFin.Location = new Point(724, 38);
            lblFechaFin.Name = "lblFechaFin";
            lblFechaFin.Size = new Size(52, 21);
            lblFechaFin.TabIndex = 22;
            lblFechaFin.Text = "Hasta:";
            lblFechaFin.Visible = false;
            // 
            // frmReportes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 244, 246);
            ClientSize = new Size(1152, 452);
            Controls.Add(lblFechaFin);
            Controls.Add(dtpFechaFin);
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
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmReportes";
            Text = "Módulo para Generar Reportes";
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
        private DateTimePicker dtpFechaFin;
        private Label lblFechaFin;
    }
}