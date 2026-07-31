using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace pryDulceria
{
    public partial class frmVentas : Form
    {
        clsVentas ventas = new clsVentas();

        public frmVentas()
        {
            InitializeComponent();
            CargarGridProductosInicial();
        }

        private void CargarGridProductosInicial()
        {
            dgvProductos.DataSource = null;
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            try
            {
                ventas.ProductoBuscar = ""; // Para que traiga todos al inicio
                dgvProductos.DataSource = ventas.ConsultarCoincidenciasProductos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void CalcularTotal()
        {
            decimal total = ventas.CalcularTotalCarrito(dgvCarrito.Rows);
            lblTotal.Text = "Total a Pagar: $" + total.ToString("0.00");
        }
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            dgvProductos.DataSource = null;
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            try
            {
                ventas.ProductoBuscar = txtBuscar.Text;
                dgvProductos.DataSource = ventas.ConsultarCoincidenciasProductos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;//Solucion al error con el column header
            {
                // Extraemos los datos del producto seleccionado
                string id = dgvProductos.CurrentRow.Cells["Id"].Value.ToString();
                string nombre = dgvProductos.CurrentRow.Cells["Nombre"].Value.ToString();
                decimal precio = Convert.ToDecimal(dgvProductos.CurrentRow.Cells["Precio"].Value);
                int stockDisponible = Convert.ToInt32(dgvProductos.CurrentRow.Cells["Stock"].Value);

                bool existeEnCarrito = false;

                // Buscamos si ya lo agregamos antes al carrito
                foreach (DataGridViewRow fila in dgvCarrito.Rows)
                {
                    if (fila.Cells["IdProducto"].Value.ToString() == id)
                    {
                        int cantActual = Convert.ToInt32(fila.Cells["Cantidad"].Value);
                        if (cantActual + 1 <= stockDisponible)
                        {
                            fila.Cells["Cantidad"].Value = cantActual + 1;
                            fila.Cells["Subtotal"].Value = ventas.CalcularSubtotalProducto(cantActual + 1, precio);
                        }
                        else
                        {
                            MessageBox.Show("No hay suficiente stock.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        existeEnCarrito = true;
                        break;
                    }
                }

                // Si no existe, lo agregamos como fila nueva
                if (!existeEnCarrito && stockDisponible > 0)
                {
                    dgvCarrito.Rows.Add(id, nombre, precio, 1, precio);
                }

                CalcularTotal();
            }
        }

        // Si editas la cantidad manual en el carrito, se debe recalcular (necesita el evento CellValueChanged del dgvCarrito)
        private void dgvCarrito_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvCarrito.Columns[e.ColumnIndex].Name == "Cantidad")
            {
                decimal precio = Convert.ToDecimal(dgvCarrito.Rows[e.RowIndex].Cells["Precio"].Value);
                int nuevaCant = Convert.ToInt32(dgvCarrito.Rows[e.RowIndex].Cells["Cantidad"].Value);
                int stockDisponible = Convert.ToInt32(dgvProductos.CurrentRow.Cells["Stock"].Value);
                // Checamos q no ponga una cantidad nulla o igual a 0
                if (nuevaCant == 0)
                {
                    MessageBox.Show("Ingresa una cantidad válida mayor a 0.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dgvCarrito.Rows[e.RowIndex].Cells["Cantidad"].Value = 1;//le damos valor de 1
                    return;
                }
                // Checamos q no sobrepase el stock
                if (nuevaCant <= stockDisponible)
                {
                    //Recalculamos el subtotal y total
                    dgvCarrito.Rows[e.RowIndex].Cells["Subtotal"].Value = ventas.CalcularSubtotalProducto(nuevaCant, precio);
                    CalcularTotal();
                }
                else
                {
                    MessageBox.Show("No hay suficiente stock.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dgvCarrito.Rows[e.RowIndex].Cells["Cantidad"].Value = stockDisponible;
                    return;
                }
            }
        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            if (dgvCarrito.Rows.Count == 0)
            {
                MessageBox.Show("Agrega productos al carrito primero.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal totalPagar = Convert.ToDecimal(lblTotal.Text.Replace("Total a Pagar: $", ""));

            // Mandamos el total a la ventana emergente de cobro
            frmCobrar emergente = new frmCobrar(totalPagar);

            if (emergente.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Asignamos propiedades (aquí pon el ID real del empleado que inició sesión)
                    ventas.TotalVenta = totalPagar;
                    ventas.IdCliente = 1; // Cliente por defecto o "Venta al mostrador"
                    ventas.IdUsuario = clsInicioSesion.IdUsuarioActual; // Trabajador/usuario que realiza la venta

                    // Mandamos a guardar pasando las filas del carrito
                    string msg = ventas.GuardarVentaTransaccion(dgvCarrito.Rows);
                    MessageBox.Show(msg, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Limpiamos pantalla
                    dgvCarrito.Rows.Clear();
                    lblTotal.Text = "Total a Pagar: $0.00";
                    CargarGridProductosInicial(); // Refrescamos para ver el stock actualizado
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Primero validamos que sí haya algo en el carrito para no preguntar si está vacío
            if (dgvCarrito.Rows.Count > 0)
            {
                var resp = MessageBox.Show("¿Confirmar que deseas cancelar la venta y vaciar el carrito?", "ALERTA!!", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

                if (resp == DialogResult.Yes)
                {
                    // Limpiamos la tabla y reiniciamos el label del total
                    dgvCarrito.Rows.Clear();
                    lblTotal.Text = "Total a Pagar: $0.00";
                }
            }
        }

        private void dgvCarrito_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Validamos que no le hayan dado clic a los títulos de arriba (RowIndex >= 0)
            // y que le hayan dado clic exactamente a la columna que se llama "Quitar"
            if (e.RowIndex >= 0 && dgvCarrito.Columns[e.ColumnIndex].Name == "Quitar")
            {
                // Extraemos el nombre del producto
                string nombreProd = dgvCarrito.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                // Lanzamos la alerta
                var resp = MessageBox.Show($"¿Seguro que deseas quitar '{nombreProd}' del carrito?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resp == DialogResult.Yes)
                {
                    // Eliminamos toda la fila de la tabla
                    dgvCarrito.Rows.RemoveAt(e.RowIndex);
                    CalcularTotal();
                }
            }
        }
        // Aquí atrapamos la celda cuando le dan doble clic y le conectamos el KeyPress
        // esto para poder ponerle la validacion de solo numeros al grid ()
        private void dgvCarrito_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control is TextBox txt)
            {
                // Desconectamos primero por si ya estaba conectado (evita que se ejecute doble)
                txt.KeyPress -= txtCantidad_KeyPress;
                // Conectamos el evento KeyPress
                txt.KeyPress += txtCantidad_KeyPress;
            }
        }
        // Le asignamos la validacion al metodo keypress del textbox del dgv
        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            clsValidaciones.SoloNumeros(e);
        }
    }
}


