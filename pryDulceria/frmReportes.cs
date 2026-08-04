using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pryDulceria
{
    public partial class frmReportes : Form
    {
        clsReportes reportes = new clsReportes();

        public frmReportes()
        {
            InitializeComponent();
            dtpFechaCorte.Value = DateTime.Now;
            dtpFechaFin.Value = DateTime.Now;

        }

        public void CargarGrid()
        {
            dgvReportes.DataSource = null;
            dgvReportes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            try
            {
                dgvReportes.DataSource = reportes.buscarReporte();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCargarDatos_click(object sender, EventArgs e)
        {
            // Validamos que el usuario realmente haya elegido una opción en el ComboBox
            if (cmbTipoReporte.SelectedItem != null)
            {
                reportes.Fechacorte = dtpFechaCorte.Value;
                reportes.Tiporeporte = cmbTipoReporte.SelectedItem.ToString();
                reportes.Fechafin = dtpFechaFin.Value;


                CargarGrid();
            }
            else
            {
                MessageBox.Show("Por favor seleccione un tipo de reporte de la lista.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            reportes = new clsReportes();
            reportes.exportarPDF(dgvReportes.DataSource as DataTable, cmbTipoReporte.SelectedItem.ToString(), "Reporte.pdf");
        }

        private void cmbTipoReporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verificamos qué opción eligió el usuario
            string opcionSeleccionada = cmbTipoReporte.SelectedItem.ToString();

            // Si la opción es el reporte por rango/mensual, mostramos el segundo calendario
            if (opcionSeleccionada == "Ventas por rango (Personalizada)" || opcionSeleccionada == "Compras por rango" || opcionSeleccionada == "Ranking de productos ")
            {
                dtpFechaFin.Visible = true;
                lblFechaFin.Visible = true; 
            }
            else
            {
                
                dtpFechaFin.Visible = false;
                lblFechaFin.Visible = false;
            }
        }
    }
}