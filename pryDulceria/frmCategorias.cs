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
        private int idCategoriaSeleccionada = 0;
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
            txtNombre.Clear();

            idCategoriaSeleccionada = 0;

            txtNombre.Focus();
        }

        private void dgvCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                idCategoriaSeleccionada = Convert.ToInt32(dgvCategorias.Rows[e.RowIndex].Cells[0].Value);
                txtNombre.Text = dgvCategorias.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
          

        }

        private void frmCategorias_Load(object sender, EventArgs e)
        {
         
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
