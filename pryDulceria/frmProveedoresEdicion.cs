using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pryDulceria
{
    public partial class frmProveedoresEdicion : Form
    {
        int tipoOperacion; // 0 = Nuevo, 1 = Editar
        int idProveedorModificar;
        clsProveedores proveedores = new clsProveedores();

        // para Nuevo
        public frmProveedoresEdicion(int operacion)
        {
            InitializeComponent();
            tipoOperacion = operacion;
            idProveedorModificar = 0;
            lblTitulo.Text = "Agregar Proveedor";
        }

        //para Editar
        public frmProveedoresEdicion(int operacion, int id, string nombre, string ap, string am, string tel, string tel_sec)
        {
            InitializeComponent();
            tipoOperacion = operacion;
            idProveedorModificar = id;
            lblTitulo.Text = "Editar Proveedor";

            // Rellenamos las cajas y el combo con info del form principal
            txtNombre.Text = nombre;
            txtAP.Text = ap;
            txtAM.Text = am;
            txtTel.Text = tel;
            txtTelSecundario.Text = tel_sec;
        }



        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validamos que esten llenos campos obligatorios (txtAP y txtTelSecundario son opcionales)
            if (clsValidaciones.EstaVacio(txtNombre, "Nombre")) return;
            if (clsValidaciones.EstaVacio(txtAM, "Apellido materno")) return;
            if (clsValidaciones.EstaVacio(txtTel, "Teléfono")) return;
            // Validamos q el telefono tenga 10 digitos exactos
            if (txtTel.Text.Trim().Length != 10)
            {
                MessageBox.Show("El teléfono principal debe tener exactamente 10 dígitos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTel.Focus();
                return;
            }
            // Validar 10 dígitos del teléfono secundario (SOLO si escribieron algo)
            if (!string.IsNullOrWhiteSpace(txtTelSecundario.Text) && txtTelSecundario.Text.Trim().Length != 10)
            {
                MessageBox.Show("El teléfono secundario debe tener exactamente 10 dígitos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTelSecundario.Focus();
                return;
            }
            //
            try
            {

                proveedores.IdProveedor = idProveedorModificar;
                proveedores.Nombre = txtNombre.Text;
                proveedores.Ap = txtAP.Text;
                proveedores.Am = txtAM.Text;
                proveedores.Tel = txtTel.Text;
                proveedores.Tel_secundario = txtTelSecundario.Text;


                // Llamamos a la clase para que haga el Insert o el Update
                string msg = proveedores.GuardarActualizarRegistros(tipoOperacion);
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
        //Validaciones en los TxtBox
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            clsValidaciones.SoloLetras(e);
        }

        private void txtAP_KeyPress(object sender, KeyPressEventArgs e)
        {
            clsValidaciones.SoloLetras(e);
        }

        private void txtAM_KeyPress(object sender, KeyPressEventArgs e)
        {
            clsValidaciones.SoloLetras(e);
        }

        private void txtTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            clsValidaciones.SoloNumeros(e);
        }

        private void txtTelSecundario_KeyPress(object sender, KeyPressEventArgs e)
        {
            clsValidaciones.SoloNumeros(e);
        }
        // Terminan los metodos de validacion
    }
}