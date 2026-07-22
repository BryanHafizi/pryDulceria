using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pryDulceria
{
    public partial class frmAgregarCategoria : Form
    {
        clsCategoria categoria = new clsCategoria();
        public frmAgregarCategoria()
        {
            InitializeComponent();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtCategoria.Text))
                {
                    MessageBox.Show("Ingresa un nombre para la categoría.");
                    return;
                }

                if (!int.TryParse(txtCodigoCategoria.Text.Trim(), out int codigo))
                {
                    MessageBox.Show("Ingresa un numero válido (número entero).");
                    return;
                }

                categoria.Categoria = txtCategoria.Text.Trim();
                categoria.Id_categoria = codigo;

                if (categoria.AgregarCategoria())
                {
                    MessageBox.Show("¡Categoria guardado exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtCategoria.Clear();
                    txtCodigoCategoria.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
