using System;
using System.Security.Principal;
using System.Windows.Forms;

namespace pryDulceria
{
    public partial class frmMenuPrincipal : Form
    {
        clsMenuPrincipal principal;
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }
        private void pcbGeneral_MouseDown(object pictureSeleccionado, MouseEventArgs e)
        {
            PictureBox pcb = (PictureBox)pictureSeleccionado;
            pcb.Location = new Point(pcb.Location.X + 3, pcb.Location.Y + 3);
        }
        private void pcbGeneral_MouseUp(object pictureSeleccionado, MouseEventArgs e)
        {
            PictureBox pcb = (PictureBox)pictureSeleccionado;
            pcb.Location = new Point(pcb.Location.X - 3, pcb.Location.Y - 3);

        }
        private void pbVentas_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new frmVentas());
        
        }
        private void pbInventarios_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new frmInventario());
        }
        private void pbReportes_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new frmReportes());
        }
        private void pbProveedores_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new frmProveedores());
        }
            private void pbUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormularioEnPanel(new frmUsuarios());
        }

        private void pbCerrarSesion_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
        private void AbrirFormularioEnPanel(Form formHijo)
        {
            if (this.pnlContenedor.Controls.Count > 0)
            {
                this.pnlContenedor.Controls.RemoveAt(0);
            }

            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;

            formHijo.Dock = DockStyle.Fill;

            this.pnlContenedor.Controls.Add(formHijo);
            this.pnlContenedor.Tag = formHijo;
            formHijo.Show();
        }

    }
}