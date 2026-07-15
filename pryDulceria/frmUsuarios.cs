using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pryDulceria
{
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void txtBuscarUsuarrios_TextChanged(object sender, EventArgs e)
        {
            usuarios = new clsUsuarios();
            dgvTutores.DataSource = null;
            dgvTutores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            try
            {
                tutores.NombreTutor = txtBuscarTutores.Text;
                dgvTutores.DataSource = tutores.ConsultarCoincidencias();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
