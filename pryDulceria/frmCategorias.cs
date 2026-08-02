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
        private void dgvCategorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                idCategoriaSeleccionada = Convert.ToInt32(dgvCategorias.Rows[e.RowIndex].Cells[0].Value);
                txtNombre.Text = Convert.ToString(dgvCategorias.Rows[e.RowIndex].Cells[1].Value);
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idCategoriaSeleccionada == 0)
            {
                MessageBox.Show("Por favor, selecciona una categoría de la tabla para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult respuesta = MessageBox.Show("¿Estás seguro de que deseas eliminar esta categoría?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                try
                {
                    categoria.Id_categoria = idCategoriaSeleccionada;
                    MessageBox.Show(categoria.Eliminar(), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNombre.Clear();
                    idCategoriaSeleccionada = 0;
                    CargarGrid();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void frmCategorias_Load(object sender, EventArgs e)
        {
            CargarGrid();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("¡Ingrese un nombre valido!.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                string msg = "";

                if (idCategoriaSeleccionada == 0)
                {
                    categoria.Categoria = txtNombre.Text;
                    msg = categoria.AgregarCategoria();
                }
                else
                {
                    categoria.Id_categoria = idCategoriaSeleccionada;
                    categoria.Categoria = txtNombre.Text;
                    msg = categoria.Actualizar();
                }
                MessageBox.Show(msg, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtNombre.Clear();
                idCategoriaSeleccionada = 0;
                CargarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        //Validaciones para que no se guarden categorías vacías
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            clsValidaciones.SoloLetras(e);
        }
    }
}
