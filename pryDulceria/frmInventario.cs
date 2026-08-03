using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pryDulceria
{
    public partial class frmInventario : Form
    {
        clsInventario inventario = new clsInventario();
        public frmInventario()
        {
            InitializeComponent();
            CargarGrid();
        }

        public void CargarGrid()
        {
            dgvInventario.DataSource = null;
            dgvInventario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            try
            {
                dgvInventario.DataSource = inventario.CargarDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            // Mandamos un 0 para indicar que es un registro NUEVO
            frmInventarioEdicion emergente = new frmInventarioEdicion(0);

            // Si la ventana emergente devuelve un OK, refrescamos la tabla
            if (emergente.ShowDialog() == DialogResult.OK)
            {
                CargarGrid();
            }
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            frmCategorias emergente = new frmCategorias();

            emergente.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvInventario.CurrentRow != null)
            {
                var resp = MessageBox.Show("¿Está seguro de eliminar el producto seleccionado?", "¡ALERTA!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resp == DialogResult.Yes)
                {
                    try
                    {
                        inventario.IdProducto = int.Parse(dgvInventario.CurrentRow.Cells[0].Value.ToString());
                        MessageBox.Show(inventario.Eliminar(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarGrid();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            dgvInventario.DataSource = null;
            dgvInventario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            try
            {
                inventario.NombreProd = txtBuscar.Text;
                dgvInventario.DataSource = inventario.ConsultarCoincidencias();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvInventario.CurrentRow != null)
            {
                try
                {
                    int id = int.Parse(dgvInventario.CurrentRow.Cells[0].Value.ToString());
                    string nombre = dgvInventario.CurrentRow.Cells[1].Value.ToString();
                    float precio = float.Parse(dgvInventario.CurrentRow.Cells[2].Value.ToString()); // Costo
                    float precioVenta = float.Parse(dgvInventario.CurrentRow.Cells[3].Value.ToString()); // Precio
                    int stock = int.Parse(dgvInventario.CurrentRow.Cells[4].Value.ToString());
                    string categoria = dgvInventario.CurrentRow.Cells[5].Value.ToString();

                    float margen = 0;
                    if (precio > 0)
                    {
                        margen = (float)Math.Round(((precioVenta - precio) / precio) * 100, 2);
                    }

                    frmInventarioEdicion emergente = new frmInventarioEdicion(1, id, nombre, precio, margen, precioVenta, stock, categoria);

                    if (emergente.ShowDialog() == DialogResult.OK)
                    {
                        CargarGrid();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al extraer los datos para editar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un producto de la tabla para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
