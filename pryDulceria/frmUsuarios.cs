using System;
using System.Windows.Forms;

namespace pryDulceria
{
    public partial class frmUsuarios : Form
    {
        clsUsuarios usuarios = new clsUsuarios();

        public frmUsuarios()
        {
            InitializeComponent();
            CargarGrid();
        }

        public void CargarGrid()
        {
            dgvUsuarios.DataSource = null;
            dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            try
            {
                dgvUsuarios.DataSource = usuarios.CargarDataGrid();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e) // Evento de la caja de búsqueda
        {
            dgvUsuarios.DataSource = null;
            dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            try
            {
                usuarios.NombreUsuario = txtBuscar.Text;
                dgvUsuarios.DataSource = usuarios.ConsultarCoincidencias();
            }
            catch (Exception ex) 
            { 
                MessageBox.Show(ex.Message); 
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            // Mandamos un 0 para indicar que es un registro NUEVO
            frmUsuariosEdicion emergente = new frmUsuariosEdicion(0);

            // Si la ventana emergente devuelve un OK, refrescamos la tabla
            if (emergente.ShowDialog() == DialogResult.OK)
            {
                CargarGrid();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow != null)
            {
                // Extraemos los datos de la fila seleccionada
                int id = int.Parse(dgvUsuarios.CurrentRow.Cells[0].Value.ToString());
                string nombre = dgvUsuarios.CurrentRow.Cells[1].Value.ToString();
                string pass = dgvUsuarios.CurrentRow.Cells[2].Value.ToString();
                string rol = dgvUsuarios.CurrentRow.Cells[3].Value.ToString();

                // Mandamos un 1 (EDITAR) y los datos a la ventana emergente
                frmUsuariosEdicion emergente = new frmUsuariosEdicion(1, id, nombre, pass, rol);

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
            if (dgvUsuarios.CurrentRow != null)
            {
                var resp = MessageBox.Show("¿Confirmar que deseas eliminar el usuario seleccionado?", "ALERTA!!", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                if (resp == DialogResult.Yes)
                {
                    usuarios.IdUsuario = int.Parse(dgvUsuarios.CurrentRow.Cells[0].Value.ToString());
                    MessageBox.Show(usuarios.Eliminar());
                    CargarGrid();
                }
            }
        }
    }
}