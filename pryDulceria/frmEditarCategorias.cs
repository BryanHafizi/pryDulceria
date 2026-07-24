using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pryDulceria
{
    public partial class frmEditarCategorias : Form
    {
        clsCategoria categoria = new clsCategoria();
        
        public frmEditarCategorias()
        {
            InitializeComponent();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                categoria.Id_categoria = int.Parse(txtCodigoCategoria.Text);
                categoria.Categoria = txtCategoria.Text;

                // Llamamos a la clase para que haga el Insert o el Update
                string msg = categoria.Actualizar();
                MessageBox.Show(msg, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Le decimos al Formulario Principal que todo fue un éxito y nos cerramos
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
