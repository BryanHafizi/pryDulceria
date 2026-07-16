using System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pryDulceria
{
    public partial class frmProveedores : Form
    {
        clsProveedores proveedores = new clsProveedores();

        public frmProveedores()
        {
            InitializeComponent();
            CargarGrid();
        }

        public void CargarGrid()
        {
            dgvProvedores.DataSource = null;
            dgvProvedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            try
            {
                dgvProvedores.DataSource = proveedores.CargarDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e) // Evento de la caja de búsqueda
        {
            dgvProvedores.DataSource = null;
            dgvProvedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            try
            {
                proveedores.Nombre = txtBuscar.Text;
                dgvProvedores.DataSource = proveedores.ConsultarCoincidencias();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            // Mandamos un 0 para indicar que es un registro NUEVO
            frmProveedoresEdicion emergente = new frmProveedoresEdicion(0);

            // Si la ventana emergente devuelve un OK, refrescamos la tabla
            if (emergente.ShowDialog() == DialogResult.OK)
            {
                CargarGrid();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvProvedores.CurrentRow != null)
            {
                // Extraemos los datos de la fila seleccionada
                int id = int.Parse(dgvProvedores.CurrentRow.Cells[0].Value.ToString());
                string nombre = dgvProvedores.CurrentRow.Cells[1].Value.ToString();
                string ap = dgvProvedores.CurrentRow.Cells[2].Value.ToString();
                string am = dgvProvedores.CurrentRow.Cells[3].Value.ToString();
                int tel = int.Parse(dgvProvedores.CurrentRow.Cells[4].Value.ToString());
                int tel_sec = int.Parse(dgvProvedores.CurrentRow.Cells[5].Value.ToString());

                // Mandamos un 1 (EDITAR) y los datos a la ventana emergente
                frmProveedoresEdicion emergente = new frmProveedoresEdicion(1, id, nombre, ap, am, tel, tel_sec);

                if (emergente.ShowDialog() == DialogResult.OK)
                {
                    CargarGrid();
                }
            }
            else
            {
                MessageBox.Show("Selecciona un usuario de la tabla para editar.", "Aviso");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvProvedores.CurrentRow != null)
            {
                var resp = MessageBox.Show("¿Confirmar que deseas eliminar el usuario seleccionado?", "ALERTA!!", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                if (resp == DialogResult.Yes)
                {
                    proveedores.IdProveedor = int.Parse(dgvProvedores.CurrentRow.Cells[0].Value.ToString());
                    MessageBox.Show(proveedores.Eliminar());
                    CargarGrid();
                }
            }
        }
    }
}