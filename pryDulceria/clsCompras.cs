using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace pryDulceria
{
    internal class clsCompras
    {
        // Propiedades
        private string productoBuscar;
        private decimal totalCompra;
        private int idProveedor;
        private int idUsuario;

        private MySqlDataAdapter consulta;
        private MySqlCommand comando;
        private DataTable tabla;

        public string ProductoBuscar { get => productoBuscar; set => productoBuscar = value; }
        public decimal TotalCompra { get => totalCompra; set => totalCompra = value; }
        public int IdProveedor { get => idProveedor; set => idProveedor = value; }
        public int IdUsuario { get => idUsuario; set => idUsuario = value; }

        public decimal CalcularSubtotalProducto(int cantidad, decimal precio)
        {
            return cantidad * precio;
        }

        public decimal CalcularTotalCarrito(DataGridViewRowCollection filas)
        {
            decimal total = 0;
            foreach (DataGridViewRow fila in filas)
            {
                total += Convert.ToDecimal(fila.Cells["Subtotal"].Value);
            }
            return total;
        }

        public DataTable ConsultarCoincidenciasProductos()
        {
            tabla = new DataTable();
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "SELECT Id_producto AS Id, codigo_barras AS Codigo, Nombre, Costo, Precio, Stock FROM tblproductos WHERE Nombre LIKE @nombre OR codigo_barras LIKE @nombre;";
                    using (var consultar = new MySqlCommand(sql, conexion))
                    {
                        consultar.Parameters.AddWithValue("@nombre", "%" + ProductoBuscar + "%");
                        using (var consulta = new MySqlDataAdapter(consultar)) { consulta.Fill(tabla); }
                    }
                }
            }
            catch (Exception ex) { throw new Exception("Error: " + ex.Message); }
            return tabla;
        }

        public DataTable ConsultarProveedores()
        {
            tabla = new DataTable();
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    string sql = "SELECT Id_proveedor, Nombre FROM tblproveedor;";
                    using (var consultar = new MySqlCommand(sql, conexion))
                    {
                        using (var consulta = new MySqlDataAdapter(consultar)) { consulta.Fill(tabla); }
                    }
                }
            }
            catch (Exception ex) { throw new Exception("Error: " + ex.Message); }
            return tabla;
        }

        public string GuardarCompraTransaccion(DataGridViewRowCollection carrito)
        {
            string msg = "";
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    using (var transaccion = conexion.BeginTransaction())
                    {
                        try
                        {
                            string sqlCompra = "INSERT INTO tblcompra (fecha, Total, Id_proveedor, intidUsuario) VALUES (CURDATE(), @total, @idProveedor, @idUsuario); SELECT LAST_INSERT_ID();";
                            int idCompraGenerada;

                            using (comando = new MySqlCommand(sqlCompra, conexion, transaccion))
                            {
                                comando.Parameters.AddWithValue("@total", TotalCompra);
                                comando.Parameters.AddWithValue("@idProveedor", IdProveedor);
                                comando.Parameters.AddWithValue("@idUsuario", IdUsuario);

                                idCompraGenerada = Convert.ToInt32(comando.ExecuteScalar());
                            }

                            foreach (DataGridViewRow fila in carrito)
                            {
                                int idProd = Convert.ToInt32(fila.Cells["IdProducto"].Value);
                                int cant = Convert.ToInt32(fila.Cells["Cantidad"].Value);
                                decimal precioUnitario = Convert.ToDecimal(fila.Cells["Costo"].Value);

                                string sqlDetalle = "INSERT INTO tbldet_compra (Id_compra, Id_producto, Cantidad, Precio_Unitario) VALUES (@idCompra, @idProd, @cant, @precio);";
                                using (var cmdDetalle = new MySqlCommand(sqlDetalle, conexion, transaccion))
                                {
                                    cmdDetalle.Parameters.AddWithValue("@idCompra", idCompraGenerada);
                                    cmdDetalle.Parameters.AddWithValue("@idProd", idProd);
                                    cmdDetalle.Parameters.AddWithValue("@cant", cant);
                                    cmdDetalle.Parameters.AddWithValue("@precio", precioUnitario);
                                    cmdDetalle.ExecuteNonQuery();
                                }

                                // Actualizamos el Stock Y tambien el nuevo Costo en tblproductos
                                string sqlStock = "UPDATE tblproductos SET Stock = Stock + @cant, Costo = @costo WHERE Id_producto = @idProd;";
                                using (var cmdStock = new MySqlCommand(sqlStock, conexion, transaccion))
                                {
                                    cmdStock.Parameters.AddWithValue("@cant", cant);
                                    cmdStock.Parameters.AddWithValue("@costo", precioUnitario);
                                    cmdStock.Parameters.AddWithValue("@idProd", idProd);
                                    cmdStock.ExecuteNonQuery();
                                }

                                string sqlConsulta = "SELECT Precio FROM tblproductos WHERE Id_producto = @idProd;";
                                decimal precioVentaActual = 0;
                                using (var cmdConsulta = new MySqlCommand(sqlConsulta, conexion, transaccion))
                                {
                                    cmdConsulta.Parameters.AddWithValue("@idProd", idProd);
                                    precioVentaActual = Convert.ToDecimal(cmdConsulta.ExecuteScalar());
                                }

                                if (precioUnitario >= precioVentaActual)
                                {
                                    decimal nuevoPrecioVenta = Math.Round(precioUnitario * 1.30m, 2);
                                    string sqlPrecio = "UPDATE tblproductos SET Precio = @nuevoPrecio WHERE Id_producto = @idProd;";
                                    using (var cmdPrecio = new MySqlCommand(sqlPrecio, conexion, transaccion))
                                    {
                                        cmdPrecio.Parameters.AddWithValue("@nuevoPrecio", nuevoPrecioVenta);
                                        cmdPrecio.Parameters.AddWithValue("@idProd", idProd);
                                        cmdPrecio.ExecuteNonQuery();
                                    }

                                    MessageBox.Show($"¡Aviso de Protección de Ganancias!\n\nEn el producto con ID '{idProd}' el costo de compra (${precioUnitario:0.00}) era mayor o igual al precio de venta actual (${precioVentaActual:0.00}).\n\nEl precio de venta se actualizó automáticamente a ${nuevoPrecioVenta:0.00} con un porcentaje del 30% de margen para evitar pérdidas.", "Precio de Venta Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }

                            transaccion.Commit();
                            msg = "Compra registrada exitosamente";
                        }
                        catch (Exception ex)
                        {
                            transaccion.Rollback();
                            throw new Exception("Error al guardar detalles: " + ex.Message);
                        }
                    }
                }
            }
            catch (Exception ex) { throw new Exception("Error: " + ex.Message); }
            return msg;
        }
    }
}