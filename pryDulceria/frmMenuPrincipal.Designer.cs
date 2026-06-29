namespace pryDulceria
{
    partial class frmMenuAdmin
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) { components.Dispose(); }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            lblBienvenida = new Label();
            pnlContenedorMenu = new Panel();
            btnCerrarSesion = new Button();
            button1 = new Button();
            btnProveedores = new Button();
            btnInventario = new Button();
            btnVentas = new Button();
            pnlContenedorMenu.SuspendLayout();
            SuspendLayout();
            // 
            // lblBienvenida
            // 
            lblBienvenida.AutoSize = true;
            lblBienvenida.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblBienvenida.ForeColor = Color.FromArgb(51, 51, 51);
            lblBienvenida.Location = new Point(30, 30);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(459, 37);
            lblBienvenida.TabIndex = 2;
            lblBienvenida.Text = "Panel de Control - Dulcería Marlyn";
            // 
            // pnlContenedorMenu
            // 
            pnlContenedorMenu.BackColor = Color.FromArgb(255, 192, 203);
            pnlContenedorMenu.Controls.Add(btnCerrarSesion);
            pnlContenedorMenu.Controls.Add(button1);
            pnlContenedorMenu.Controls.Add(btnProveedores);
            pnlContenedorMenu.Controls.Add(btnInventario);
            pnlContenedorMenu.Controls.Add(btnVentas);
            pnlContenedorMenu.Location = new Point(30, 100);
            pnlContenedorMenu.Name = "pnlContenedorMenu";
            pnlContenedorMenu.Size = new Size(950, 400);
            pnlContenedorMenu.TabIndex = 1;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.BackColor = Color.FromArgb(240, 128, 128);
            btnCerrarSesion.FlatStyle = FlatStyle.Flat;
            btnCerrarSesion.ForeColor = Color.White;
            btnCerrarSesion.Location = new Point(813, 347);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(123, 35);
            btnCerrarSesion.TabIndex = 3;
            btnCerrarSesion.Text = "Cerrar Sesion";
            btnCerrarSesion.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 105, 180);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(491, 120);
            button1.Name = "button1";
            button1.Size = new Size(166, 150);
            button1.TabIndex = 3;
            button1.Text = "Reportes";
            button1.UseVisualStyleBackColor = false;
            // 
            // btnProveedores
            // 
            btnProveedores.BackColor = Color.FromArgb(255, 105, 180);
            btnProveedores.FlatStyle = FlatStyle.Flat;
            btnProveedores.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnProveedores.ForeColor = Color.White;
            btnProveedores.Location = new Point(702, 120);
            btnProveedores.Name = "btnProveedores";
            btnProveedores.Size = new Size(166, 150);
            btnProveedores.TabIndex = 0;
            btnProveedores.Text = "Proveedores";
            btnProveedores.UseVisualStyleBackColor = false;
            // 
            // btnInventario
            // 
            btnInventario.BackColor = Color.FromArgb(255, 105, 180);
            btnInventario.FlatStyle = FlatStyle.Flat;
            btnInventario.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnInventario.ForeColor = Color.White;
            btnInventario.Location = new Point(281, 120);
            btnInventario.Name = "btnInventario";
            btnInventario.Size = new Size(162, 150);
            btnInventario.TabIndex = 1;
            btnInventario.Text = "Inventario";
            btnInventario.UseVisualStyleBackColor = false;
            // 
            // btnVentas
            // 
            btnVentas.BackColor = Color.FromArgb(255, 105, 180);
            btnVentas.FlatStyle = FlatStyle.Flat;
            btnVentas.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnVentas.ForeColor = Color.White;
            btnVentas.Location = new Point(75, 120);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(161, 150);
            btnVentas.TabIndex = 2;
            btnVentas.Text = "Ventas";
            btnVentas.UseVisualStyleBackColor = false;
            // 
            // frmMenuAdmin
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 228, 225);
            ClientSize = new Size(1024, 768);
            Controls.Add(pnlContenedorMenu);
            Controls.Add(lblBienvenida);
            Font = new Font("Segoe UI", 12F);
            Name = "frmMenuAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menú Principal - Administrador";
            pnlContenedorMenu.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.Panel pnlContenedorMenu;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.Button btnProveedores;
        private Button button1;
        private Button btnCerrarSesion;
    }
}