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
    public partial class frmCompras : Form
    {
        clsCompras compras = new clsCompras();

        public frmCompras()
        {
            InitializeComponent();
            CargarGridProductosInicial();
            CargarProveedores();
        }

        private void CargarGridProductosInicial()
        {
            dgvProductos.DataSource = null;
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            try
            {
                compras.ProductoBuscar = ""; // Para que traiga todos al inicio
                dgvProductos.DataSource = compras.ConsultarCoincidenciasProductos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CargarProveedores()
        {
            try
            {
                cmbProveedor.DataSource = compras.ConsultarProveedores();
                cmbProveedor.DisplayMember = "Nombre";
                cmbProveedor.ValueMember = "Id_proveedor";
                cmbProveedor.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CalcularTotal()
        {
            decimal total = compras.CalcularTotalCarrito(dgvCompras.Rows);
            lblTotal.Text = "Total a Pagar: $" + total.ToString("0.00");
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            dgvProductos.DataSource = null;
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            try
            {
                compras.ProductoBuscar = txtBuscar.Text;
                dgvProductos.DataSource = compras.ConsultarCoincidenciasProductos();
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
                decimal costo = Convert.ToDecimal(dgvProductos.CurrentRow.Cells["Costo"].Value);

                bool existeEnCarrito = false;

                // Buscamos si ya lo agregamos antes al carrito
                foreach (DataGridViewRow fila in dgvCompras.Rows)
                {
                    if (fila.Cells["IdProducto"].Value.ToString() == id)
                    {
                        // ASÍ DEBE QUEDAR:
                        int cantActual = Convert.ToInt32(fila.Cells["Cantidad"].Value);
                        decimal costoActualEnCarrito = Convert.ToDecimal(fila.Cells["Costo"].Value);
                        fila.Cells["Cantidad"].Value = cantActual + 1;
                        fila.Cells["Subtotal"].Value = compras.CalcularSubtotalProducto(cantActual + 1, costoActualEnCarrito);
                        existeEnCarrito = true;
                        break;
                    }
                }

                // Si no existe, lo agregamos como fila nueva
                if (!existeEnCarrito)
                {
                    dgvCompras.Rows.Add(id, nombre, costo, 1, costo);
                }

                CalcularTotal();
            }

        }

        // Si editas la cantidad manual en el carrito, se debe recalcular (necesita el evento CellValueChanged del dgvCompras)
        private void dgvCompras_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && (dgvCompras.Columns[e.ColumnIndex].Name == "Cantidad" || dgvCompras.Columns[e.ColumnIndex].Name == "Costo"))
            {
                decimal precio = Convert.ToDecimal(dgvCompras.Rows[e.RowIndex].Cells["Costo"].Value);
                int nuevaCant = Convert.ToInt32(dgvCompras.Rows[e.RowIndex].Cells["Cantidad"].Value);
                // Checamos q no ponga una cantidad nulla o igual a 0
                if (nuevaCant == 0)
                {
                    MessageBox.Show("Ingresa una cantidad válida mayor a 0.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dgvCompras.Rows[e.RowIndex].Cells["Cantidad"].Value = 1;//le damos valor de 1
                    return;
                }
                if (precio == 0)
                {
                    MessageBox.Show("Ingresa un coste válido mayor a 0.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dgvCompras.Rows[e.RowIndex].Cells["Costo"].Value = 1;//le damos valor de 1
                    return;
                }
                //Recalculamos el subtotal y total
                dgvCompras.Rows[e.RowIndex].Cells["Subtotal"].Value = compras.CalcularSubtotalProducto(nuevaCant, precio);
                CalcularTotal();
            }
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            if (cmbProveedor.SelectedIndex == -1)
            {
                MessageBox.Show("Selecciona un proveedor primero.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dgvCompras.Rows.Count == 0)
            {
                MessageBox.Show("Agrega productos al carrito primero.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var resp = MessageBox.Show("¿Confirmar compra y entrada al inventario?", "Confirmar Compra", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resp == DialogResult.Yes)
            {
                try
                {
                    decimal totalPagar = Convert.ToDecimal(lblTotal.Text.Replace("Total a Pagar: $", ""));

                    compras.TotalCompra = totalPagar;
                    compras.IdProveedor = Convert.ToInt32(cmbProveedor.SelectedValue);
                    compras.IdUsuario = clsInicioSesion.IdUsuarioActual;

                    string msg = compras.GuardarCompraTransaccion(dgvCompras.Rows);
                    MessageBox.Show(msg, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    dgvCompras.Rows.Clear();
                    lblTotal.Text = "Total a Pagar: $0.00";
                    cmbProveedor.Enabled = true;
                    cmbProveedor.SelectedIndex = -1;
                    CargarGridProductosInicial();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (dgvCompras.Rows.Count > 0)
            {
                var resp = MessageBox.Show("¿Confirmar que deseas cancelar la compra y vaciar el carrito?", "ALERTA!!", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

                if (resp == DialogResult.Yes)
                {
                    dgvCompras.Rows.Clear();
                    lblTotal.Text = "Total a Pagar: $0.00";
                    cmbProveedor.Enabled = true;
                    cmbProveedor.SelectedIndex = -1;
                }
            }
        }

        private void dgvCompras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvCompras.Columns[e.ColumnIndex].Name == "Quitar")
            {
                string nombreProd = dgvCompras.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                var resp = MessageBox.Show($"¿Seguro que deseas quitar '{nombreProd}' del carrito?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resp == DialogResult.Yes)
                {
                    dgvCompras.Rows.RemoveAt(e.RowIndex);
                    CalcularTotal();
                }
            }
        }

        // Aquí atrapamos la celda cuando le dan doble clic y le conectamos el KeyPress
        // esto para poder ponerle la validacion de solo numeros al grid ()
        private void dgvCompras_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control is TextBox txt)
            {
                txt.KeyPress -= txtCantidad_KeyPress;
                txt.KeyPress -= txtPrecio_KeyPress;
                // Dependiendo de qué columna esté editando el usuario, conectamos el evento correcto
                string Columna = dgvCompras.Columns[dgvCompras.CurrentCell.ColumnIndex].Name;

                if (Columna == "Cantidad")
                {
                    txt.KeyPress += txtCantidad_KeyPress;
                }
                else if (Columna == "Costo")
                {
                    txt.KeyPress += txtPrecio_KeyPress;
                }
            }
        }

        // Le asignamos la validacion al metodo keypress del textbox del dgv
        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            clsValidaciones.SoloNumeros(e);
        }
        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            clsValidaciones.SoloDecimales(sender, e);
        }
    }
}