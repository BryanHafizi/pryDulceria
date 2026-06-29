using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pryDulceria
{
    public partial class frmVender : Form
    {
        public frmVender()
        {
            InitializeComponent();
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void dgyVenta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void frmVender_Load(object sender, EventArgs e)
        {
            // Recuerda que el orden es: Cantidad, Producto, Precio uni, Subtotal
            dgyVenta.Rows.Add("2", "Paleta Payaso", "$15.00", "$30.00");
            dgyVenta.Rows.Add("5", "Chicles Canel's", "$2.00", "$10.00");
            dgyVenta.Rows.Add("1", "Mazapán Gigante", "$8.50", "$8.50");
            dgyVenta.Rows.Add("3", "Bolsa de Totis", "$12.00", "$36.00");
            dgyVenta.Rows.Add("10", "Gansito", "$18.00", "$180.00");
        }
    }
}
