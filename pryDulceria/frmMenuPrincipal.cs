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
            principal = new clsMenuPrincipal();
            principal.agregarAlContenedor(new frmVentas(), pnlContenedor);
        }
        private void pbInventarios_Click(object sender, EventArgs e)
        {
            principal = new clsMenuPrincipal();
            principal.agregarAlContenedor(new frmInventario(), pnlContenedor);
        }

        private void pbProveedores_Click(object sender, EventArgs e)
        {
            principal = new clsMenuPrincipal();
            principal.agregarAlContenedor(new frmProveedores(), pnlContenedor);
        }

        private void pbReportes_Click(object sender, EventArgs e)
        {

        }

        private void pbCerrarSesion_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

       

    }
}