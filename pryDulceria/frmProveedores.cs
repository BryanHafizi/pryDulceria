using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pryDulceria
{
    public partial class frmProveedores : Form
    {
        public frmProveedores()
        {
            InitializeComponent();
        }

        private void frmProveedores_Load(object sender, EventArgs e)
        {
            // El orden es: Clave, Nombre del proveedor, Empresa, Contacto
            dgvProveedores.Rows.Add("1", "Carlos Mendoza", "Dulces Vero", "551-234-5678");
            dgvProveedores.Rows.Add("2", "Ana María Gómez", "Grupo Bimbo / Barcel", "558-765-4321");
            dgvProveedores.Rows.Add("3", "Luis Fernando López", "Ricolino", "811-999-8887");
            dgvProveedores.Rows.Add("4", "Sofía Hernández", "Dulces de la Rosa", "333-444-5556");
            dgvProveedores.Rows.Add("5", "Jorge Ramírez", "Nestlé México", "555-111-2223");
        }
    }
}
