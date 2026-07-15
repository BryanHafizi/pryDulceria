using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pryDulceria
{
    public partial class frmUsuariosEdicion : Form
    {
        int tipoOperacion; // 0 = Nuevo, 1 = Editar
        int idUsuarioModificar;
        clsUsuarios usuarios = new clsUsuarios();

        // 1er Constructor: Se dispara cuando presionas "Nuevo"
        public frmUsuariosEdicion(int operacion)
        {
            InitializeComponent();
            tipoOperacion = operacion;
            idUsuarioModificar = 0; // Como es nuevo, no hay ID aún

            CargarComboRoles(); // Llenamos el combobox
        }

        // 2do Constructor: Se dispara cuando presionas "Editar"
        public frmUsuariosEdicion(int operacion, int id, string nombre, string pass, string rol)
        {
            InitializeComponent();
            tipoOperacion = operacion;
            idUsuarioModificar = id;

            CargarComboRoles(); // Llenamos el combobox

            // Rellenamos las cajas y el combo con la info que nos mandó el form principal
            txtUsuario.Text = nombre;
            txtPassword.Text = pass;
            cmbRol.Text = rol; // Esto va a seleccionar automáticamente el rol en el combo
        }

        // METODO NUEVO: Como es una sola tabla, metemos los datos manuales al combo
        private void CargarComboRoles()
        {
            cmbRol.Items.Clear();
            cmbRol.Items.Add("-- Selecciona un Rol --");
            cmbRol.Items.Add("Administrador"); // Igualito a como está en tu Base de Datos
            cmbRol.Items.Add("Cajero");

            // DropDownList evita que el usuario escriba a lo loco en el combo
            cmbRol.DropDownStyle = ComboBoxStyle.DropDownList;

            // Hacemos que por defecto muestre "-- Selecciona un Rol --"
            cmbRol.SelectedIndex = 0;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Mini validación para que no guarden el placeholder "-- Selecciona un Rol --"
                if (cmbRol.SelectedIndex == 0)
                {
                    MessageBox.Show("Por favor, selecciona un rol de la lista.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Detenemos el guardado aquí
                }

                usuarios.IdUsuario = idUsuarioModificar;
                usuarios.NombreUsuario = txtUsuario.Text;
                usuarios.Password = txtPassword.Text;
                usuarios.Rol = cmbRol.Text; // Extraemos el texto del combo seleccionado

                // Llamamos a la clase para que haga el Insert o el Update
                string msg = usuarios.GuardarActualizarRegistros(tipoOperacion);
                MessageBox.Show(msg, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Le decimos al Formulario Principal que todo fue un éxito y nos cerramos
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Cerramos la ventana sin hacer nada
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }
    }
}
