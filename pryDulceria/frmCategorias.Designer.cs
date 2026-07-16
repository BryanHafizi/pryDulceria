namespace pryDulceria
{
    partial class frmCategorias
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            lblTitulo = new Label();
            lblNombreCategoria = new Label();
            dgvCategorias = new DataGridView();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.Black;
            lblTitulo.Location = new Point(12, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(311, 45);
            lblTitulo.TabIndex = 16;
            lblTitulo.Text = "Agregar Categorias";
            // 
            // lblNombreCategoria
            // 
            lblNombreCategoria.AutoSize = true;
            lblNombreCategoria.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombreCategoria.Location = new Point(35, 118);
            lblNombreCategoria.Name = "lblNombreCategoria";
            lblNombreCategoria.Size = new Size(179, 21);
            lblNombreCategoria.TabIndex = 17;
            lblNombreCategoria.Text = "Nombre de la Categoria:";
            // 
            // dgvCategorias
            // 
            dgvCategorias.AllowUserToAddRows = false;
            dgvCategorias.AllowUserToDeleteRows = false;
            dgvCategorias.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvCategorias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCategorias.BackgroundColor = SystemColors.ActiveBorder;
            dgvCategorias.BorderStyle = BorderStyle.None;
            dgvCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategorias.Location = new Point(394, 73);
            dgvCategorias.Margin = new Padding(3, 2, 3, 2);
            dgvCategorias.Name = "dgvCategorias";
            dgvCategorias.ReadOnly = true;
            dgvCategorias.RowHeadersVisible = false;
            dgvCategorias.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Padding = new Padding(3);
            dgvCategorias.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvCategorias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategorias.Size = new Size(215, 243);
            dgvCategorias.TabIndex = 29;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(35, 142);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(318, 23);
            textBox1.TabIndex = 30;
            // 
            // frmCategorias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(632, 453);
            Controls.Add(textBox1);
            Controls.Add(dgvCategorias);
            Controls.Add(lblNombreCategoria);
            Controls.Add(lblTitulo);
            Name = "frmCategorias";
            Text = "frmCategorias";
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblNombreCategoria;
        private DataGridView dgvCategorias;
        private TextBox textBox1;
    }
}