using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pryDulceria
{
    public partial class frmCategorias : Form
    {
        clsCategoria categoria = new clsCategoria();
        public frmCategorias()
        {
            InitializeComponent();
            CargarGrid();
        }
        public void CargarGrid()
        {
            dgvCategorias.DataSource = null;
            dgvCategorias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            try
            {
                dgvCategorias.DataSource = categoria.CargarDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void txtBuscar_TextChanged(object sender, EventArgs e) // Evento de la caja de búsqueda
        {
            dgvCategorias.DataSource = null;
            dgvCategorias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            try
            {
                categoria.Categoria = txtBuscar.Text;
                dgvCategorias.DataSource = categoria.ConsultarCoincidencias();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmAgregarCategoria formularioAgregar = new frmAgregarCategoria();

            formularioAgregar.ShowDialog();
            
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvCategorias.CurrentRow != null)
            {
                // Extraemos los datos de la fila seleccionada
                int id = int.Parse(dgvCategorias.CurrentRow.Cells[0].Value.ToString());
                string nombre = dgvCategorias.CurrentRow.Cells[1].Value.ToString();

                // Mandamos un 1 (EDITAR) y los datos a la ventana emergente
                frmEditarCategorias emergente = new frmEditarCategorias();
                ///Esto es para que los textbox esten con sus datos xd
                emergente.txtCategoria.Text = nombre;
                emergente.txtCodigoCategoria.Text = id.ToString();
                
                if (emergente.ShowDialog() == DialogResult.OK)
                {
                    CargarGrid();
                }
            }
            else
            {
                MessageBox.Show("Selecciona una categoria de la tabla para editar.", "Aviso");
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvCategorias.CurrentRow != null)
            {
                var resp = MessageBox.Show("¿Confirmar que deseas eliminar la categoria seleccionada?", "ALERTA!!", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                if (resp == DialogResult.Yes)
                {
                    categoria.Id_categoria = int.Parse(dgvCategorias.CurrentRow.Cells[0].Value.ToString());
                    MessageBox.Show(categoria.Eliminar());
                    CargarGrid();
                }
            }
        }
    }
}
