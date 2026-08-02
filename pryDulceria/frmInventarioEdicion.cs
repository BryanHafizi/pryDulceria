using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pryDulceria
{
    public partial class frmInventarioEdicion : Form
    {
        int tipoOperacion; // 0 = Nuevo, 1 = Editar
        int idProductoModificar;
        clsInventario inventario = new clsInventario();

        //Para un producto nuevo
        public frmInventarioEdicion(int operacion)
        {
            InitializeComponent();
            tipoOperacion = operacion;
            idProductoModificar = 0;
            CargarCombos(); // Llenamos el combobox
            if (tipoOperacion == 0)
            {
                cmbCategoria.SelectedIndex = -1;
            }
            lblTitulo.Text = "Agregar Producto";
        }
        //para Editar
        public frmInventarioEdicion(int operacion, int id, string nombre, float precio, int margenGan, float precioVenta, int stock, string categoria)
        {
            InitializeComponent();
            tipoOperacion = operacion;
            idProductoModificar = id;
            lblTitulo.Text = "Editar Producto";

            // Rellenamos las cajas y el combo con info del form principal
            txtNombre.Text = nombre;
            txtPrecio.Text = precio.ToString();
            txtMargenGanancia.Text = margenGan.ToString();
            txtPrecioVenta.Text = precioVenta.ToString();
            txtStock.Text = stock.ToString();
            cmbCategoria.Text = categoria;
        }
        //Botón Guardar
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validamos que esten llenos campos obligatorios
            if (clsValidaciones.EstaVacio(txtNombre, "Nombre del producto")) return;
            if (clsValidaciones.EstaVacio(txtPrecio, "Precio del producto")) return;
            if (clsValidaciones.EstaVacio(txtMargenGanancia, "Margen de ganancia")) return;
            if (clsValidaciones.EstaVacio(txtPrecioVenta, "Precio de venta")) return;
            if (clsValidaciones.EstaVacio(txtStock, "Stock del producto")) return;
            try
            {

                inventario.IdProducto = idProductoModificar;
                inventario.NombreProd = txtNombre.Text;
                inventario.PrecioProd = float.Parse(txtPrecio.Text);
                inventario.MargenGanancia = int.Parse(txtMargenGanancia.Text);
                inventario.PrecioVentaProd = float.Parse(txtPrecioVenta.Text);
                inventario.StockProd = int.Parse(txtStock.Text);
                // Extraemos el ID numérico de la categoría seleccionada
                inventario.IdCategoria = Convert.ToInt32(cmbCategoria.SelectedValue);

                // Llamamos a la clase para que haga el Insert o el Update
                string msg = inventario.GuardarActualizarRegistros(tipoOperacion);
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
        //Cargar el combo de categorías
        private void CargarCombos()
        {
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    // Traemos las categorías directo de la base de datos
                    string sql = "SELECT id_categoria, categoria FROM tblcategorias;";

                    using (var comando = new MySqlConnector.MySqlCommand(sql, conexion))
                    using (var adaptador = new MySqlConnector.MySqlDataAdapter(comando))
                    {
                        System.Data.DataTable tablaCategorias = new System.Data.DataTable();
                        adaptador.Fill(tablaCategorias);

                        cmbCategoria.DataSource = tablaCategorias;
                        cmbCategoria.DisplayMember = "categoria";
                        cmbCategoria.ValueMember = "id_categoria";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las categorías: " + ex.Message, "Error");
            }
        }
        //Calcular el precio de venta sugerido
        private void CalcularPrecioVenta()
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txtPrecio.Text) && !string.IsNullOrWhiteSpace(txtMargenGanancia.Text))
                {
                    float costo = float.Parse(txtPrecio.Text);
                    int margen = int.Parse(txtMargenGanancia.Text);

                    txtPrecioVenta.Text = inventario.CalcularPrecioSugerido(costo, margen).ToString("0.00");
                }
            }
            catch
            {

            }
        }

        //Validaciones en los TextBox
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            clsValidaciones.Alfanumerico(e);
        }
        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            clsValidaciones.SoloDecimales(sender, e);
        }
        private void txtPrecioVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            clsValidaciones.SoloDecimales(sender, e);
        }
        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            clsValidaciones.SoloNumeros(e);
        }
        //Actualizar el precio sugerido
        private void txtMargenGanancia_TextChanged(object sender, EventArgs e)
        {
            CalcularPrecioVenta();
        }
    }
}
