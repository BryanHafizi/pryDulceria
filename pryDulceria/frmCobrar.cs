using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pryDulceria
{
    public partial class frmCobrar : Form
    {
        decimal totalPagarCobro;
        decimal cambioActual;
        clsVentas ventas = new clsVentas();

        public frmCobrar(decimal total)
        {
            InitializeComponent();
            totalPagarCobro = total;

            // Llenamos la caja de texto del total
            txtTotal.Text = totalPagarCobro.ToString("0.00");
            txtTotal.Enabled = false;
            txtCambio.Enabled = false;
        }

        private void txtMontoRecibido_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtMontoRecibido.Text, out decimal montoRecibido))// convertimos si o si a decimal
            {
                cambioActual = ventas.CalcularCambioCobrado(montoRecibido, totalPagarCobro);

                if (cambioActual >= 0)
                {
                    txtCambio.Text = cambioActual.ToString("0.00");
                }
                else
                {
                    txtCambio.Text = "Insuficiente";
                }
            }
            else
            {
                txtCambio.Clear();
            }
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            // Validamos que alcance el dinero
            if (decimal.TryParse(txtMontoRecibido.Text, out decimal monto) && cambioActual >= 0)
            {
                // Le decimos al Formulario Principal (frmVentas) que sí se cobró
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("El monto recibido no es suficiente para cubrir el total.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //validacion para el txtMontoRecibido
        private void txtMontoRecibido_KeyPress(object sender, KeyPressEventArgs e)
        {
            clsValidaciones.SoloDecimales(sender, e);
        }
    }
}