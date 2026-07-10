using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pryDulceria
{
    public partial class frmVentas : Form
    {
        public frmVentas()
        {
            InitializeComponent();
        }
        private void frmVender_Load(object sender, EventArgs e)
        {
            // Recuerda que el orden es: Cantidad, Producto, Precio uni, Subtotal
            dgvVentas.Rows.Add("2", "Paleta Payaso", "$15.00", "$30.00");
            dgvVentas.Rows.Add("5", "Chicles Canel's", "$2.00", "$10.00");
            dgvVentas.Rows.Add("1", "Mazapán Gigante", "$8.50", "$8.50");
            dgvVentas.Rows.Add("3", "Bolsa de Totis", "$12.00", "$36.00");
            dgvVentas.Rows.Add("10", "Gansito", "$18.00", "$180.00");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // Acción por defecto: cerrar el formulario
            this.Close();
        }
    }
}


