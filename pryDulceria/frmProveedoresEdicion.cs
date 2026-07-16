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
            idProveedorModificar= 0;
            
        }

        //para Editar
        public frmProveedoresEdicion(int operacion, int id, string nombre, string ap, string am,int tel, int tel_sec)
        {
            InitializeComponent();
            tipoOperacion = operacion;
            idProveedorModificar = id;


            // Rellenamos las cajas y el combo con info del form principal
            txtNombre.Text = nombre;
            txtAp.Text =ap;
            txtAm.Text = am;
            txtTel.Text = tel.ToString(); 
            txtTel.Text = tel_sec.ToString();
        }

        

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
 
                proveedores.IdProveedor = idProveedorModificar;
                proveedores.Nombre = txtNombre.Text;
                proveedores.Ap = txtAp.Text;
                proveedores.Am = txtAm.Text;
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Cerramos la ventana sin hacer nada
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}