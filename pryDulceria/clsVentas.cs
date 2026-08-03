using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace pryDulceria
{
    internal class clsVentas
    {
        // Propiedades
        private string productoBuscar;
        private decimal totalVenta;
        private int idCliente;
        private int idUsuario;

        private MySqlDataAdapter consulta;
        private MySqlCommand comando;
        private DataTable tabla;

        public string ProductoBuscar { get => productoBuscar; set => productoBuscar = value; }
        public decimal TotalVenta { get => totalVenta; set => totalVenta = value; }
        public int IdCliente { get => idCliente; set => idCliente = value; }
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

        public decimal CalcularCambioCobrado(decimal montoRecibido, decimal totalPagar)
        {
            return montoRecibido - totalPagar;
        }

        public DataTable ConsultarCoincidenciasProductos()
        {
            tabla = new DataTable();
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    // Consultamos los productos a la base de datos
                    string sql = "SELECT Id_producto AS Id, codigo_barras AS Codigo, Nombre, Precio, Stock FROM tblproductos WHERE (Nombre LIKE @nombre OR codigo_barras LIKE @nombre) AND Stock > 0;";
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

        public string GuardarVentaTransaccion(DataGridViewRowCollection carrito)
        {
            string msg = "";
            try
            {
                clsConexion conexionBD = new clsConexion();
                using (var conexion = conexionBD.AbrirConexion())
                {
                    // Usamos una transacción por si falla un insert, no se guarde la venta a medias
                    using (var transaccion = conexion.BeginTransaction())
                    {
                        try
                        {
                            // 1. Insertamos la Venta
                            // Ahora insertamos en intidUsuario en lugar de Id_Empleado
                            string sqlVenta = "INSERT INTO tblventa (fecha, Total, Id_cliente, intidUsuario) VALUES (CURDATE(), @total, @idCliente, @idUsuario); SELECT LAST_INSERT_ID();";
                            int idVentaGenerada;

                            using (comando = new MySqlCommand(sqlVenta, conexion, transaccion))
                            {
                                comando.Parameters.AddWithValue("@total", TotalVenta);
                                comando.Parameters.AddWithValue("@idCliente", IdCliente);
                                comando.Parameters.AddWithValue("@idUsuario", IdUsuario);

                                // Ejecutamos y obtenemos el ID de la venta recién creada
                                idVentaGenerada = Convert.ToInt32(comando.ExecuteScalar());
                            }

                            // Insertamos el detalle  del DataGridView y actualizamos el stock
                            foreach (DataGridViewRow fila in carrito)
                            {
                                
                                int idProd = Convert.ToInt32(fila.Cells["IdProducto"].Value);
                                int cant = Convert.ToInt32(fila.Cells["Cantidad"].Value);
                                decimal precioUnitario = Convert.ToDecimal(fila.Cells["Precio"].Value);

                                // Insertar en tbldet_venta
                                string sqlDetalle = "INSERT INTO tbldet_venta (Id_venta, Id_producto, Cantidad, Precio_Unitario) VALUES (@idVenta, @idProd, @cant, @precio);";
                                using (var cmdDetalle = new MySqlCommand(sqlDetalle, conexion, transaccion))
                                {
                                cmdDetalle.Parameters.AddWithValue("@idVenta", idVentaGenerada);
                                cmdDetalle.Parameters.AddWithValue("@idProd", idProd);
                                cmdDetalle.Parameters.AddWithValue("@cant", cant);
                                cmdDetalle.Parameters.AddWithValue("@precio", precioUnitario);
                                cmdDetalle.ExecuteNonQuery();
                                }

                                // Descontar Stock en tblproductos
                                string sqlStock = "UPDATE tblproductos SET Stock = Stock - @cant WHERE Id_producto = @idProd;";
                                using (var cmdStock = new MySqlCommand(sqlStock, conexion, transaccion))
                                {
                                cmdStock.Parameters.AddWithValue("@cant", cant);
                                cmdStock.Parameters.AddWithValue("@idProd", idProd);
                                cmdStock.ExecuteNonQuery();
                                }
                                
                            }

                            // Si todo salió bien, confirmamos los cambios
                            transaccion.Commit();
                            msg = "Venta registrada y cobrada exitosamente";
                        }
                        catch (Exception ex)
                        {
                            transaccion.Rollback(); // Cancelamos todo si hay error
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
