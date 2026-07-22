using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pryDulceria
{
    public partial class frmNuevoProducto : Form
    {
        clsProducto producto = new clsProducto();

        public frmNuevoProducto()
        {
            InitializeComponent();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNombreProducto.Text))
                {
                    MessageBox.Show("Por favor, ingresa un nombre válido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (float.TryParse(txtCodigoProducto.Text, out float codigo))
                {
                    MessageBox.Show("Por favor, ingresa un numero válido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!float.TryParse(txtPrecioProducto.Text, out float precio))
                {
                    MessageBox.Show("Por favor, ingresa un precio válido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(txtStock.Text, out int stock))
                {
                    MessageBox.Show("Por favor, ingresa un número válido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                producto.Nombre1 = txtNombreProducto.Text.Trim();
                producto.Precio1 = precio;
                producto.Stock1 = stock;

                // Guardar
                if (producto.AgregarNuevoProducto())
                {
                    MessageBox.Show("¡Producto guardado exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ///Limpiar los campos despues de guardar
                    txtNombreProducto.Clear();
                    txtCodigoProducto.Clear();
                    txtPrecioProducto.Clear();
                    txtStock.Clear();
                    txtCategoriaProducto.Clear();
                    txtNombreProducto.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
